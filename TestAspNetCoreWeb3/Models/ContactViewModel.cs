using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TestAspNetCoreWeb3.DomainModels;

namespace TestAspNetCoreWeb3.Models
{
    public class ContactViewModel
    {
        private int Id { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(30, ErrorMessage = "First Name must not be more than 30 characters")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid First Name")]
                
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(30, ErrorMessage = "Last Name must not be more than 30 characters")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(30, ErrorMessage = "Company Name must not be more than 30 characters")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid Company Name")]
        public string Company { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone1 { get; set; }

        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string Phone2 { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<>()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a valid Email")]
        public string EMail { get; set; }

        [Display(Name = "Contact Type")]
        public ContactType ContactType { get; set; }
    }
}
