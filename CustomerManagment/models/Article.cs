using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.models
{
    internal class Article
    {
        public string name { get; private set; }
        public double price { get; private set; }

        public Article(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
