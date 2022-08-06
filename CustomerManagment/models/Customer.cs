using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.models
{
    internal class Customer
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string dni { get; private set; }
        public string phone { get; private set; }
        public string creditCard { get; private set; }

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
