using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspNetCoreWeb3.Models;
using TestAspNetCoreWeb3.DomainModels;

namespace TestAspNetCoreWeb3.Repositories
{
    public interface IContactRepository
    {
        public Contact GetContactById(int id);
    }
}
