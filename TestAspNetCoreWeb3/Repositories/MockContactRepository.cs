using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspNetCoreWeb3.Models;
using TestAspNetCoreWeb3.DomainModels;

namespace TestAspNetCoreWeb3.Repositories
{
    public class MockContactRepository : IContactRepository
    {
        public Contact GetContactById(int id)
        {
            return new Contact()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Ferrara",
                BirthDate = new DateTime(1957, 9, 26),
                Phone1 = "302-345-7978",
                Phone2 = String.Empty,
                EMail = "john.ferrara@yahoo.com",
                Company = "Creative Crow Solutions"
            };
        }
    }
}
