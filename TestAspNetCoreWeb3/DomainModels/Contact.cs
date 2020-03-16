using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAspNetCoreWeb3.DomainModels
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string EMail { get; set; }
        public ContactType ContactType { get; set; }
}
}
