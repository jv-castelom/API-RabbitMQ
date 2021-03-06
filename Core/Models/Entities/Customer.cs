using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Entities
{
    public class Customer : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
    }
}
