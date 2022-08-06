using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.models
{
    internal class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string dni { get; set; }
        public string phone { get; set; }
        public string creditCard { get; set; }

        private string fullName()
        {
            return surname + " " + name;
        }

        public override string ToString()
        {
            return fullName();
        }

        public Customer(string id, string name, string surname, string dni, string phone, string creditCard)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.dni = dni;
            this.phone = phone;
            this.creditCard = creditCard;
        }
    }
}
