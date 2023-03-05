using System.Collections.Generic;
using System.Resources;
using System.Threading.Tasks;
using ToyStore.Model;

using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ToyStore.UtilityClasses
{
    public class DbService
    {
        private ToyStoreContext _context;

        private DbService() 
        { 
            _context = new ToyStoreContext();
        }

        public static DbService Instance { get => DbServiceCreate.instance; }

        private class DbServiceCreate
        {
            static DbServiceCreate() { }
            internal static readonly DbService instance = new DbService();

        }

      

        public  ToyStoreContext RetContext()
        {
            return  _context;
        }



        public async Task<List<ToyManufacturer>> SelectManufacturer()
        {
            try
            {
                return await _context.ToyManufacturers.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
           
        }

        public async Task<List<ToyType>> SelectTypeOfToy()
        {
            try
            {
                return await _context.ToyTypes.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }





        public async Task<List<CountryOfOrigin>> SelectCountry()
        {
            try
            {
                return await _context.CountryOfOrigins.ToListAsync();
            }
            catch (Exception )
            {
                return null;
            }
        }

        public async Task<List<ToySopplier>> SelectToySopplier()
        {

            try
            {
                return await _context.ToySoppliers.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Toy>> SelectToy()
        {
            try
            {
                return await _context.Toys.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool>  Edit_Click (int id, int _amount)
        {
           (await _context.StorrageOfToys.FirstOrDefaultAsync(s => s.Id == id)).Amount = _amount;

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









    }
}
