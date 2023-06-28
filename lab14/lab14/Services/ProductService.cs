using lab14.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using lab14.Models;

namespace lab14.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService() => _context = App.GetContext();


        public bool Create(Product item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Vestimenta.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Product> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Vestimenta.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Product> Get()
        {
            return _context.Vestimenta.ToList();
        }


        public List<Product> GetByText(string text)
        {
            return _context.Vestimenta.Where(x => x.Name.Contains(text)).ToList();
        }



    }
}
