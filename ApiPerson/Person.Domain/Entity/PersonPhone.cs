using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Domain.Entity
{
    public class PersonPhone
    {
        public int BusinessEntityID { get; set; }

        public string PhoneNumber { get; set; }

        public int PhoneNumberTypeID { get; set; }


        public PhoneNumberType PhoneNumberType { get; set; }
    }
}
