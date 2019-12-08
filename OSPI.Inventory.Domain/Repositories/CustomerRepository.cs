﻿using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class CustomerRepository : Repository<CustomerEntity>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
