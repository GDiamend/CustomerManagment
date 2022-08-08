using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagment.models
{
    internal class Bill
    {
        public string id { get; private set; }
        public BillType billType { get; private set; }
        public int number { get; private set; }
        public Customer customer { get; private set; }
        public List<Article> articles { get; private set; }
        public double finalPrice { get; private set; }
        public DateTime dateTime { get; private set; }

        public Bill(string id, BillType billType, int number, Customer customer)
        {
            this.id = id;
            this.billType = billType;
            this.number = number;
            this.customer = customer;
            this.articles = new List<Article>();
            this.finalPrice = this.calculateFinalPrice();
            this.dateTime = this.setDateTime();
        }

        public string getCustomerId()
        {
            return this.customer.id;
        }

        public void addList(List<Article> articles)
        {
            this.articles = articles;
        }

        private DateTime setDateTime()
        {
            return DateTime.Now;
        }
        

        private double calculateFinalPrice()
        {
            double finalPrice = 0;
            foreach (Article article in this.articles)
            {
                finalPrice += article.price;
            }
            return finalPrice;
        }
    }
}
