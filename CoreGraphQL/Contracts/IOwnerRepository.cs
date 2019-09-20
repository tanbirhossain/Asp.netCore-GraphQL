using CoreGraphQL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGraphQL.Contracts
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
    }
}
