using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ToyStore.UtilityClasses
{
    public class SelectService
    {

        private ToyStoreContext _context;

        private SelectService()
        {
            _context = new ToyStoreContext();
        }

        public static SelectService Instance { get => SelectServiceCreate.instance; }

        private class SelectServiceCreate
        {
            static SelectServiceCreate() { }
            internal static readonly SelectService instance = new SelectService();

        }

        public async Task<bool> SelectWeightManuf(int id, DataGridView gridView, int min, int max)
        {
            
                       gridView.DataSource = await (from toy in _context.Toys

                                             where toy.ToyWeight < max &&
                                                   toy.ToyWeight > min &&
                                                   toy.Manufacturer_FK == id
                                                    select new
                                             {
                                                 Название_игрушки = toy.NameOfToy,
                                                 Вес = toy.ToyWeight


                                             }).ToListAsync();

                return true;


        }

        public async Task<bool> SelectWeightManuf(DataGridView gridView, int min, int max)
        {

                        
                gridView.DataSource = await (from toy in _context.Toys

                                             where toy.ToyWeight < max &&
                                                   toy.ToyWeight > min


                                             select new
                                             {
                                                 Название_игрушки = toy.NameOfToy,
                                                 Вес = toy.ToyWeight

                                             }).ToListAsync();

                return true;
            
            
        }
















        public async Task <bool> SelectByDateToStorrage(DataGridView gridView, DateTime min, DateTime max)
        {
          
            try
            {
                gridView.DataSource = await (from ST in _context.StorrageOfToys
                                             where
                                              ST.DateOfReceipt < max &&
                                              ST.DateOfReceipt > min
                                             group new
                                             {
                                                 ST.Toy,
                                                 ST
                                             }
                                             by new
                                             {
                                                 ST.Toy.NameOfToy,
                                                 ST.DateOfReceipt
                                             }
                       into g
                                             select new
                                             {
                                                 Name = g.Key.NameOfToy,
                                                 Date = g.Key.DateOfReceipt
                                             }).ToListAsync();


                return true;
            }

            catch (Exception ex)
            {
               
                return false;
            }

        }









        public async Task<bool> SelectToyByManufacture(int manufd, DataGridView gridView, int min, int max)
        {
                   
                try
                {

                    gridView.DataSource = await (from p in _context.Prices

                                                 join toy in _context.Toys on p.Toys_FK equals toy.Id
                                                 join man in _context.ToyManufacturers on toy.Manufacturer_FK equals man.Id
                                                 where p.PriceSettingDate == _context.Prices.
                                                                              Where(p => p.Toys_FK == toy.Id).
                                                                              // Where(p => p.Price1 > minP && p.Price1 < maxP).
                                                                              Where(p => toy.Manufacturer_FK == manufd).
                                                                              Max(p => p.PriceSettingDate)
                                                 select new

                                                 {
                                                     toy.NameOfToy,
                                                     man.ManufactureName

                                                 }).ToListAsync();

                     return true;

                }
                catch (Exception ex)
                {
                    return false;

                }
            }
        









        public async Task<bool> ToySelectedByPriceAndType(DataGridView gridView, decimal min, decimal max,ToyType TType)
        {

            if (TType == null)
            {
              await  ToySelectedByPriceAndType(gridView, min, max);
              
               return true;
            }
            else
            {
                try
                {
                    var t = await (from p in _context.Prices
                                   join toy in _context.Toys on p.Toys_FK equals toy.Id
                                   join toyType in _context.ToyTypes on toy.ToyTypes_FK equals toyType.Id
                                   where p.PriceSettingDate == p.Toy.Prices.
                                                               Where(p => p.Toys_FK == toy.Id).
                                                               Where(p => p.Price1 > min && p.Price1 < max).
                                                               Max(p => p.PriceSettingDate)
                                   &&
                                   toyType.Id == TType.Id
                                   select new

                                   {
                                    Название =   toy.NameOfToy,
                                    Цена =  p.Price1,

                                   }).ToListAsync();
                    gridView.DataSource = t;

                 
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }
            }
        }


        public async Task<bool> ToySelectedByPriceAndType(DataGridView gridView, decimal min, decimal max)
        {

            try
            {
                var t = await (from p in _context.Prices
                               join toy in _context.Toys on p.Toys_FK equals toy.Id
                               where p.PriceSettingDate == p.Toy.Prices.
                                                           Where(p => p.Toys_FK == toy.Id).
                                                           Where(p => p.Price1 > min && p.Price1 < max).
                                                           Max(p => p.PriceSettingDate)
                               select new

                               {
                                   Название = toy.NameOfToy,
                                   Цена = p.Price1,


                               }).ToListAsync();

                gridView.DataSource = t;

                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }


        public async Task<bool> SelectShaereOfCheapToys(int price, int ageMin, DataGridView dataGrid)
        {
            try
            {

                double Count = await (from Prices in _context.Prices
                                where
                                Prices.PriceSettingDate == Prices.Toy.Prices.Where(p => p.Toys_FK == Prices.Toy.Id).Max(p => p.PriceSettingDate) 
                                select new
                                {
                                    Prices.Price1
                                }).CountAsync();


                double Share = await (from Prices in _context.Prices
                                      where
                                      Prices.PriceSettingDate == Prices.Toy.Prices.Where(p => p.Toys_FK == Prices.Toy.Id).Max(p => p.PriceSettingDate) &&
                                      Prices.Toy.ToyTypes_FK == Prices.Toy.ToyType.Id &&
                                      Prices.Price1 < price &&
                                      Prices.Toy.ToyType.AgeOfTargetMin < ageMin
                                      select new
                                      {
                                          Prices.Price1
                                      }).CountAsync();


            List<string> data = new List<string>() { $"Игрушки_на_которые_установлена_цена = {Count}",
                                                     $"Игрушек_по_заданым_параметрам = {Share}", 
                                                     $"Доля_доля_игрушек_с_заданными_параметрами = {Share / Count}" };

                dataGrid.DataSource = data.Select(x => new { Value = x }).ToList();

              

              //  data.ForEach(a => lb.Items.Add(a));
                 return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }










        public async Task<bool> SelectBySopplier(int Id, DataGridView gridView)
        {

            try
            {
                gridView.DataSource = await (from Toy in _context.Toys
                                  join SoT in _context.StorrageOfToys on Toy.Id equals SoT.Toys_FK
                                  join TS in _context.ToySoppliers on SoT.Soppliers_FK equals TS.Id
                                  where TS.Id == Id
                                  select new

                                  {
                                      Toy = Toy.NameOfToy,
                                      Sopplier = TS.SopplierName


                                  }).Distinct().ToListAsync();


               
                return true;
            }
            catch (Exception ex)
            {
               
               return false;
            }


        }


        public  async Task<bool> SelectBySopplierAnotherToyAndCountry(int SopplierID, int anotherToyId, int anotherToyCounyreofOriginId, DataGridView gridView)
        {
            try
            {
                DateTime dateTime = (DateTime)_context.Prices.Where(p => p.Toys_FK == anotherToyId).Max(p => p.PriceSettingDate);

                var priceOfAnotherToy = _context.Prices.Where(p => p.PriceSettingDate == dateTime).FirstOrDefault(p => p.Toys_FK == anotherToyId);
                decimal priceOfAnotherToy1;
                decimal.TryParse(priceOfAnotherToy.ToString(), out priceOfAnotherToy1);


                gridView.DataSource = await (from Toy in _context.Toys
                                  join SoT in _context.StorrageOfToys on Toy.Id equals SoT.Toys_FK
                                  join TS in _context.ToySoppliers on SoT.Soppliers_FK equals TS.Id
                                  join Pr in _context.Prices on Toy.Id equals Pr.Toys_FK
                                  join Country in _context.CountryOfOrigins on Toy.CountryOfOrigin_FK equals Country.Id
                                  where TS.Id == SopplierID &&
                                  Pr.Price1 > priceOfAnotherToy1 &&
                                  Country.Id == anotherToyCounyreofOriginId
                                  select new

                                  {
                                      Игрушка = Toy.NameOfToy,
                                      Поставщик = TS.SopplierName,
                                      Цена = Pr.Price1

                                  }).ToListAsync();

               
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
            


        }

        public async Task<bool> SelectShareOfCheapAllAndSopplier(decimal priceLimit, DataGridView gridView, int _tsId)
        {
            try
            {

                double Count = await (from Prices in _context.Prices
                                      join Ty in _context.Toys on Prices.Toys_FK equals Ty.Id
                                      join SoT in _context.StorrageOfToys on Ty.Id equals SoT.Toys_FK
                                      join Ts in _context.ToySoppliers on SoT.Soppliers_FK equals Ts.Id
                                      where
                                      Prices.Price1 < priceLimit &&
                                      Ts.Id == _tsId &&
                                      Prices.PriceSettingDate == Prices.Toy.Prices.Where(p => p.Toys_FK == Prices.Toy.Id).Max(p => p.PriceSettingDate)
                                      select new
                                      {
                                          Prices.Price1
                                      }).CountAsync();


                double list = await (from Prices in _context.Prices
                                     join Ty in _context.Toys on Prices.Toys_FK equals Ty.Id
                                     join SoT in _context.StorrageOfToys on Ty.Id equals SoT.Toys_FK
                                     join Ts in _context.ToySoppliers on SoT.Soppliers_FK equals Ts.Id
                                     where
                                    
                                     Ts.Id == _tsId &&
                                     Prices.PriceSettingDate == Prices.Toy.Prices.Where(p => p.Toys_FK == Prices.Toy.Id).Max(p => p.PriceSettingDate)
                                     select new
                                     {
                                         Prices.Price1
                                     }).CountAsync();

                double tmp = Count / list * 100;
                                
                List<string> result = new List<string>() { $"{Count} / {list} =  доля дешевых = {tmp.ToString("0.0")}" };
                

                gridView.DataSource = result.Select(x => new { Value = x }).ToList();





                return true;
            }
            catch (Exception ex)
            { 
            return false;
            }
        }

        public async Task<bool> SelectShareOfCheapAllAndSopplier(decimal priceLimit, DataGridView gridView)
        {
            try
            {
                double Count = await (from Prices in _context.Prices
                                      join Ty in _context.Toys on Prices.Toys_FK equals Ty.Id
                                     
                                      where
                                      Prices.Price1 < priceLimit &&
                                      Prices.PriceSettingDate == Prices.Toy.Prices.Where(p => p.Toys_FK == Prices.Toy.Id).Max(p => p.PriceSettingDate)
                                      select new
                                      {
                                          Prices.Price1
                                      }).CountAsync();


                double list = await (from Prices in _context.Prices
                                           join Ty in _context.Toys on Prices.Toys_FK equals Ty.Id
                                       
                                           where
                                          
                                           Prices.PriceSettingDate == Prices.Toy.Prices.Where(p => p.Toys_FK == Prices.Toy.Id).Max(p => p.PriceSettingDate)
                                           select new
                                           {
                                               Prices.Price1
                                           }).CountAsync();

                               

                double tmp = Count / list * 100;

                List<string> result = new List<string>() { $"{Count} / {list} =  доля дешевых = {tmp.ToString("0.0")}" };

                gridView.DataSource = result.Select(x => new { Value = x }).ToList();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public async Task<bool> SelectAveragePriceToPeriod(DateTime t1, DateTime t2, DataGridView gridView)
        {

            try
            {
                var t =  await(from Sale in _context.Sales

                                  join Pr in _context.Prices on Sale.Price_FK equals Pr.Id
                                  join Ty in _context.Toys on Sale.Toys_FK equals Ty.Id
                                  where Sale.DataOfSale < t2 &&
                                  Sale.DataOfSale >= t1
                                   select Pr.Price1).AverageAsync();



                List<string> result = new List<string>() {t.ToString() };

                gridView.DataSource = result.Select(x => new { Value = x }).ToList();



                return true;
            }
            catch (Exception ex)
            {
              //  throw ex;
                return false;
            }


        }


        public async Task<bool> SelectToysPriceMoreThenManufact(int ToyManuf_ID, DataGridView gridView)
        {

            try
            {
                var aver_price = await (from Price in _context.Prices
                                        join TY in _context.Toys on Price.Toys_FK equals TY.Id
                                        join TM in _context.ToyManufacturers on TY.Manufacturer_FK equals TM.Id
                                        where TM.Id == ToyManuf_ID
                                        select Price.Price1).AverageAsync();

                gridView.DataSource = await (from Toys in _context.Toys
                                  join PRS in _context.Prices on Toys.Id equals PRS.Toys_FK
                                  where PRS.Price1 > aver_price &&
                                  PRS.PriceSettingDate == _context.Prices.Where(p => p.Toys_FK == Toys.Id).Max(p => p.PriceSettingDate)
                                  select new
                                  {
                                      Игрушка = Toys.NameOfToy,
                                      Цена = PRS.Price1
                                  }).Distinct().ToListAsync();

                
                return true;
            }
            catch (Exception ex)
            {
              
                return false;
            }

        }

        public async Task<bool> SelectMostPopularToy(DataGridView dataGrid)

        {
            try
            {
                var toy = await (from sales in _context.Sales
                                 join ty in _context.Toys on sales.Toys_FK equals ty.Id
                                 join pr in _context.Prices on ty.Id equals pr.Toys_FK
                                 where ty.Id == sales.Toys_FK &&
                                 pr.PriceSettingDate == _context.Prices.Where(p => p.Toys_FK == ty.Id).Max(p => p.PriceSettingDate)
                                 //  orderby sales.to
                                 select new
                                 {
                                     count = _context.Sales.Where(p => p.Toys_FK == ty.Id).Count(),
                                     toy = ty.NameOfToy,
                                     price = pr.Price1,
                                     sum = _context.Sales.Count()


                                 }).Distinct().OrderByDescending(p => p.count).ToListAsync();

                dataGrid.DataSource = toy;
                return true;
            }
            catch (Exception es)
            {

                return false; 
            }
        }


        public async Task<bool> SelectMostPopularToyForAge(int age, DataGridView gridView)

        {
            try
            {
                gridView.DataSource = await (from sales in _context.Sales
                                 join ty in _context.Toys on sales.Toys_FK equals ty.Id
                                 join pr in _context.Prices on ty.Id equals pr.Toys_FK
                                 join ttyp in _context.ToyTypes on ty.ToyTypes_FK equals ttyp.Id
                                 where ty.Id == sales.Toys_FK &&
                                 pr.PriceSettingDate == _context.Prices.Where(p => p.Toys_FK == ty.Id).Max(p => p.PriceSettingDate) &&
                                 ttyp.AgeOfTargetMin <= age
                                 //  orderby sales.to
                                 select new
                                 {
                                     count = _context.Sales.Where(p => p.Toys_FK == ty.Id).Count(),
                                     toy = ty.NameOfToy,
                                     price = pr.Price1,
                                     sum = _context.Sales.Count()


                                 }).Distinct().OrderByDescending(p => p.count).ToListAsync();
               

                return true;
            }
            catch (Exception es)
            {

                return false;
            }
        }
    





        public async Task<bool> SelectAveragePriceOfAllTypes(DataGridView dataGridView)
        {
            try
            {


                var avg = await (from Toy in _context.Toys
                                 select new
                                 {

                                   Средняя_цена = (from Pr in _context.Prices
                                             join Ty in _context.Toys on Pr.Toys_FK equals Ty.Id
                                             where
                                             Pr.PriceSettingDate == Pr.Toy.Prices.Where(p => Pr.Toys_FK == Ty.Id).Max(p => p.PriceSettingDate)
                                             select Pr.Price1).Average()
                                 }).Distinct().ToListAsync();

                //  Pr.Toy.Prices.Average(p => p.Price1)).Distinct().ToListAsync();

              
                dataGridView.DataSource = avg;

           return true;
            }

            catch (Exception ex)
            {
               
                return false;
            }
        }



        public async Task<bool> SelectByOderDateOfRegister(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await (from t in _context.Toys
                                                 join d in _context.StorrageOfToys on t.Id equals d.Toys_FK
                                                 orderby d.DateOfReceipt
                                                 select new
                                                 {
                                                     Name = t.NameOfToy,
                                                     DataOfreciept = d.DateOfReceipt
                                                 }).ToListAsync();



                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public async Task<bool> SelectByAlphabeticalOder(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await (from s in _context.StorrageOfToys
                                                  join t in _context.Toys on s.Toys_FK equals t.Id
                                                  join ns in _context.ToySoppliers on s.Soppliers_FK equals ns.Id
                                                  orderby ns.SopplierName
                                                  select new
                                                  {
                                                      Name = t.NameOfToy,
                                                      ToySopplier = ns.SopplierName
                                                  }).ToListAsync();



                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }




        public async Task<bool> SelectOderByWeight(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await  _context.Toys.Select(t => new { Name = t.NameOfToy, Weight = t.ToyWeight })
                                                         .OrderBy(t => t.Weight).ToListAsync();


                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }

        }

        public async Task<bool> SelectOderByPrice(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await (from t in _context.Toys
                                                 join p in _context.Prices on t.Id equals p.Toys_FK
                                                 where p.PriceSettingDate == _context.Prices.Where(p => p.Toys_FK == t.Id).Max(p => p.PriceSettingDate)
                                                 orderby p.Price1

                                                 select new

                                                 {
                                                     id = t.Id,
                                                     Name = t.NameOfToy,
                                                     Price = p.Price1,
                                                     Price_setting_date = _context.Prices.Where(p => p.Toys_FK == t.Id).Max(p => p.PriceSettingDate)
                                                 }).Distinct().ToListAsync();

                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }

        }



        public async Task<bool> SelectOderBySaleDate(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await (from t in _context.Toys
                                                 join s in _context.Sales on t.Id equals s.Toys_FK
                                                 orderby s.DataOfSale

                                                 select new

                                                 {
                                                     id = t.Id,
                                                     Name = t.NameOfToy,
                                                     Date = s.DataOfSale

                                                 }).ToListAsync(); 

                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }

        }

        public async Task<bool> SelectMostExpenciveType(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await (from P in _context.Prices
                                                  join toy in _context.Toys on P.Toys_FK equals toy.Id
                                                  join Type in _context.ToyTypes on toy.ToyTypes_FK equals Type.Id
                                                  where toy.ToyTypes_FK == Type.Id
                                                  group new
                                                  { P.Toy.ToyType, P }
                                                  by new
                                                  {
                                                      P.Toy.ToyType.Id,
                                                      P.Toy.ToyType.TypeOfToy
                                                  } into g
                                                  orderby g.Average(p => p.P.Price1) descending
                                                  select new
                                                  {
                                                      Cредняя_цена = g.Average(p => p.P.Price1),
                                                      Вид_Игрушек = g.Key.TypeOfToy
                                                  }).Take(1).ToListAsync();

                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }

        }

        public async Task<bool> SelectMostCheapType(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await (from P in _context.Prices
                                                 join toy in _context.Toys on P.Toys_FK equals toy.Id
                                                 join Type in _context.ToyTypes on toy.ToyTypes_FK equals Type.Id
                                                 where toy.ToyTypes_FK == Type.Id
                                                 group new
                                                 { P.Toy.ToyType, P }
                                                 by new
                                                 {
                                                     P.Toy.ToyType.Id,
                                                     P.Toy.ToyType.TypeOfToy
                                                 } into g
                                                 orderby g.Average(p => p.P.Price1)
                                                 select new
                                                 {
                                                     Cредняя_цена = g.Average(p => p.P.Price1),
                                                     Вид_Игрушек = g.Key.TypeOfToy
                                                 }).Take(1).ToListAsync();



                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }

        }




        public async Task<bool> SelectAveragePriceOfTypes(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = await (from P in _context.Prices
                                                 join toy in _context.Toys on P.Toys_FK equals toy.Id
                                                 join Type in _context.ToyTypes on toy.ToyTypes_FK equals Type.Id
                                                 where toy.ToyTypes_FK == Type.Id
                                                 &&
                                                 P.PriceSettingDate == _context.Prices.Where(p => p.Toys_FK == toy.Id).Max(p => p.PriceSettingDate)
                                                 group new
                                                 {
                                                     P.Toy.ToyType,
                                                     P
                                                 }
                                                 by new
                                                 {
                                                     P.Toy.ToyType.Id,
                                                     P.Toy.ToyType.TypeOfToy
                                                 }
                                                         into g
                                                 select new
                                                 {
                                                     Cредняя_цена = g.Average(p => p.P.Price1).ToString(),
                                                     Вид_Игрушек = g.Key.TypeOfToy
                                                 }).ToListAsync();



                return true;
            }

            catch (Exception ex)
            {
                throw ex;
                return false;
            }

        }






        public async Task<List<Toy>> SelectToy()
        {
            return await _context.Toys.ToListAsync();
        }


        




        /*   var a =   from Toys in _context.Toys
              select new
              {
                  Count =
                  (from Prices in _context.Prices
                   where
         Prices.Toy.ToyTypes_FK == Toys.ToyType.Id &&
         Prices.Price1 < 400 &&
         Toys.ToyType.AgeOfTargetMin < 7
                   select new
                   {
                       Prices.Price1
                   }).Count(p => p.Price1 != null),
                  Count_fo_Toys = .Count(p => p.Id != null),
                  share = (
                  (from Prices in .Prices
                   where
        Prices.Toy.ToyTypes_FK == Toys.ToyType.Id &&
        Prices.Price1 < 400 &&
        Toys0.ToyType.AgeOfTargetMin < 7
                   select new
                   {
                       Prices.Price1
                   }).Count(p => p.Price1 != null) / .Count(p => p.Id != null))*/
    }







}

