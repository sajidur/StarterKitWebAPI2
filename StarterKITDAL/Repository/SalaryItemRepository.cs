﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public class SalaryItemRepository : ISalaryItemRepository
    {
        ApplicationDbContext _context;
        public SalaryItemRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public ICollection<SalaryItem> GetAll(int countryId)
        {
            return _context.SalaryItems.Where(a => a.Country.Id == countryId).ToList();
        }

        public int Save(SalaryItem salaryItem)
        {
            salaryItem.Country = null;
            _context.SalaryItems.Add(salaryItem);
           return _context.SaveChanges();
        }
    }
}
