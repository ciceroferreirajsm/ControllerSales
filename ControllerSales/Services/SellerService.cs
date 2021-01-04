using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControllerSales.Data;
using ControllerSales.Models;

namespace ControllerSales.Services
{
    public class SellerService
    {
        private readonly ControllerSalesContext _context;

        public SellerService(ControllerSalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
