using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStore.Model;

namespace ToyStore.UtilityClasses
{
    public class AddElements
    {

        private ToyStoreContext _context;

        private AddElements()
        {
            _context = new ToyStoreContext();
        }

        public static AddElements Instance { get => AddElementsCreate.instance; }

        private class AddElementsCreate
        {
            static AddElementsCreate() { }
            internal static readonly AddElements instance = new AddElements();

        }



        public async Task<CountryOfOrigin> AddCountry(TextBox tb)
        {

            if ((await(_context.CountryOfOrigins.FirstOrDefaultAsync(m => m.CountryName == tb.Text))) == null)
            {
                CountryOfOrigin countryOfOrigin = new CountryOfOrigin()
                {
                    CountryName = tb.Text,
                };

                _context.CountryOfOrigins.Add(countryOfOrigin);
                int res = await _context.SaveChangesAsync();
                if (res == 0)
                {
                    throw new Exception();
                }
                return countryOfOrigin;
            }
            else
            {

                return null;
            }
        }

        public async Task<ToySopplier> AddSopplier(TextBox tb)
        {
            if ((await(_context.ToySoppliers.FirstOrDefaultAsync(m => m.SopplierName == tb.Text))) == null)
            {
                ToySopplier toySopplier = new ToySopplier
                {
                    SopplierName = tb.Text,
                };

                _context.ToySoppliers.Add(toySopplier);
                int res = await _context.SaveChangesAsync();
                if (res == 0)
                {
                    throw new Exception();
                }
                return toySopplier;
            }
            else
            {

                return null;
            }

        }

        public async Task<ToyManufacturer> AddManufacturer(TextBox tb)
        {
            if ((await (_context.ToyManufacturers.FirstOrDefaultAsync(m => m.ManufactureName == tb.Text))) == null)
            {
                ToyManufacturer toyManufacturer = new ToyManufacturer
                {
                    ManufactureName = tb.Text,
                };
                _context.ToyManufacturers.Add(toyManufacturer);

                int res = await _context.SaveChangesAsync();
                if (res == 0)
                {
                    throw new Exception();

                }
                return toyManufacturer;
            }
            else
            {

                return null;
            }
        }


        public async Task<bool> AddNewToy(string toyName, int manufId, decimal weight, int toyTypeId, int countryofOrId)
        {
            if ((await (_context.Toys.FirstOrDefaultAsync(t => t.NameOfToy == toyName))) == null)
            {
                Toy toy = new Toy()
                {
                    NameOfToy = toyName,
                    Manufacturer_FK = manufId,
                    ToyWeight = weight,
                    ToyTypes_FK = toyTypeId,
                    CountryOfOrigin_FK = countryofOrId

                };

                _context.Toys.Add(toy);
                int res = await _context.SaveChangesAsync();
                if (res == 0)
                {
                  
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }


        }



        public async Task<bool> AddBatchToStore(Toy toy, ToySopplier toySopplier, int amount, DateTime dateTime)
        {

            StorrageOfToy storrageOfToys = new StorrageOfToy()
            {
                Toys_FK = toy.Id,
                Amount = amount,
                Soppliers_FK = toySopplier.Id,
                DateOfReceipt = dateTime,
            };         
            

            _context.StorrageOfToys.Add(storrageOfToys);

                _context.Toys.Add(toy);
                int res = await _context.SaveChangesAsync();
                if (res == 0)
                {
                   
                    return false;
                }
                else
                {
                    return true;
                }

            }

        public List<StorrageOfToy> AddToyToBatch(Toy toy, ToySopplier toySopplier, int amount, DateTime dateTime, List<StorrageOfToy> currentBatch)
        {
         
            try
            {
                StorrageOfToy toyPartOfBatch = new StorrageOfToy()
                {
                    Toys_FK = toy.Id,
                    Amount = amount,
                    Soppliers_FK = toySopplier.Id,
                    DateOfReceipt = dateTime,
                };
                currentBatch.Add(toyPartOfBatch);
                return currentBatch;
            }
            catch (Exception)
            {
                return null;
            }
         }

        public async Task<bool> AddToyToBatchToStorrage (List<StorrageOfToy> currentBatc)
        {
            StorrageOfToy tmp;
            try
            {
                foreach (StorrageOfToy StOfT in currentBatc)
                {
                   
                    tmp = await _context.StorrageOfToys.FirstOrDefaultAsync(t => t.Toys_FK == StOfT.Toys_FK);
                    if (tmp != null && tmp.Soppliers_FK == StOfT.Soppliers_FK)
                    {
                        (await _context.StorrageOfToys.FirstOrDefaultAsync(t => t.Toys_FK == StOfT.Toys_FK)).Amount += StOfT.Amount;
                        (await _context.StorrageOfToys.FirstOrDefaultAsync(t => t.Toys_FK == StOfT.Toys_FK)).DateOfReceipt= StOfT.DateOfReceipt;

                    }
                    else
                    {
                        _context.StorrageOfToys.Add(StOfT);

                    }
                }

                int res = await _context.SaveChangesAsync();
                if (res == 0)
                {
                   
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }

          
        }

        public async Task<bool> SelectStorrageOfToy(DataGridView gridView)
        {
            try
            {
                gridView.DataSource= await (from StorrageOfToy in _context.StorrageOfToys
                                           join toy in _context.Toys on StorrageOfToy.Toys_FK equals toy.Id
                                           join toySop in _context.ToySoppliers on StorrageOfToy.Soppliers_FK equals toySop.Id
                                           where toy.Id==StorrageOfToy.Toys_FK
                                           select new

                                            {
                                                Игрушка = toy.NameOfToy,
                                                Количество = StorrageOfToy.Amount,
                                                Дата_последнего_поступления=StorrageOfToy.DateOfReceipt,
                                                Поставщик = toySop.SopplierName


                                           }).ToListAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SelectStorrageOfToy(BindingSource gridView)
        {
            try
            {
                gridView.DataSource = await (from StorrageOfToy in _context.StorrageOfToys
                                             join toy in _context.Toys on StorrageOfToy.Toys_FK equals toy.Id
                                             join toySop in _context.ToySoppliers on StorrageOfToy.Soppliers_FK equals toySop.Id
                                             where toy.Id == StorrageOfToy.Toys_FK
                                             select new

                                             {
                                                 ИД = StorrageOfToy.Id,
                                                 Игрушка = toy.NameOfToy,
                                                 Количество = StorrageOfToy.Amount,
                                                 Дата_последнего_поступления = StorrageOfToy.DateOfReceipt,
                                                 Поставщик = toySop.SopplierName


                                             }).ToListAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }





    }




}

