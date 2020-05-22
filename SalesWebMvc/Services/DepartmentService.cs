﻿using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services;


namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(X => X.Name).ToList();
        }
    }
}
