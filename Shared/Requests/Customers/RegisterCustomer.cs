using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Requests.Customers
{
    public class RegisterCustomer
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
