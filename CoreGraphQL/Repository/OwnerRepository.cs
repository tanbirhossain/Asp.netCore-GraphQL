using CoreGraphQL.Contracts;
using CoreGraphQL.Entities;
using CoreGraphQL.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGraphQL.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }
        public IEnumerable<Owner> GetAll()
        {
            var result = _context.Owners.ToList();
            return result;
        }

    }
}
