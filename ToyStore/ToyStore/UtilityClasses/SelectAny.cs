using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Model;
using ToyStore.UtilityClasses;


namespace ToyStore.UtilityClasses
{
    public class SelectAny
    {

        public async Task<bool> SelectWeightManuf(DbService db, ComboBox cb, DataGridView gridView, int min, int max)
        {
            ToyStoreContext _context = db.RetContext();


            if (cb.SelectedItem == null)
            {
                gridView.DataSource=  await (from toy in _context.Toys

                 where toy.ToyWeight < max &&
                       toy.ToyWeight > min


                 select new
                 {
                     Название_игрушки = toy.NameOfToy,
                     Вес = toy.ToyWeight

                 }).ToListAsync();
               
                return true;
            }
            else
            {
                gridView.DataSource= await (from toy in _context.Toys

                 where toy.ToyWeight < max &&
                       toy.ToyWeight > min &&
                       toy.Manufacturer_FK == ((ToyManufacturer)cb.SelectedItem).Id
                 select new
                 {
                     Название_игрушки = toy.NameOfToy,
                     Вес = toy.ToyWeight


                 }).ToListAsync();
              
                return true;
            }

        }

        public  async Task <bool> ToySelectedByPrice(DbService db, DataGridView gridView, int min, int max)
        {
            ToyStoreContext _context = db.RetContext();

            try
            {
                gridView.DataSource = await (from p in _context.Prices
                               join toy in _context.Toys on p.Toys_FK equals toy.Id
                               where p.PriceSettingDate == _context.Prices.
                                                           Where(p => p.Toys_FK == toy.Id).
                                                           Where(p => p.Price1 > min && p.Price1 < max).
                                                           Max(p => p.PriceSettingDate)
                               select new

                               {
                                   toy.NameOfToy,
                                   p.Price1,

                               }).ToListAsync();

               
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }


        public async Task<bool> SelectToyByManufacture(DbService db, ComboBox cb, DataGridView gridView, int min, int max)
        {
            ToyStoreContext _context = db.RetContext();

            if (cb.SelectedItem == null)
            {

                return false;
            }
            else
            {
                try
                {

                    gridView.DataSource = await (from p in _context.Prices

                                   join toy in _context.Toys on p.Toys_FK equals toy.Id
                                   join man in _context.ToyManufacturers on toy.Manufacturer_FK equals man.Id
                                   where p.PriceSettingDate == _context.Prices.
                                                                Where(p => p.Toys_FK == toy.Id).
                                                                // Where(p => p.Price1 > minP && p.Price1 < maxP).
                                                                Where(p => toy.Manufacturer_FK == ((ToyManufacturer)cb.SelectedItem).Id).
                                                                Max(p => p.PriceSettingDate)
                                   select new

                                   {
                                       toy.NameOfToy,
                                       man.ManufactureName

                                   }).ToListAsync();

                  

                    return true;

                }
                catch (Exception)
                {
                    return false;

                }
            }
        }


        public async Task SelectByDateToStorrage(DbService db,DataGridView gridView, DateTimePicker min, DateTimePicker max)
        {
            ToyStoreContext _context = db.RetContext();
            try
            {
                gridView.DataSource = await (from ST in _context.StorrageOfToys
                               where
                                ST.DateOfReceipt < max.Value &&
                                ST.DateOfReceipt > min.Value
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
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        
        }




}


}
