using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControllerSales.Data;
using ControllerSales.Models;

namespace ControllerSales.Services
{
    public class DepartmentService
    {
        private readonly ControllerSalesContext _context;

        public DepartmentService(ControllerSalesContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
