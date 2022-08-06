﻿using System;
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
        public string number { get; private set; }
        public Customer customer { get; private set; }
        public List<Article> articles { get; private set; }
        public double finalPrice { get; private set; }
        public DateTime dateTime { get; private set; }

        public Bill(string id, BillType billType, string number, Customer customer)
        {
            this.id = id;
            this.billType = billType;
            this.number = number;
            this.customer = customer;
            this.articles = new List<Article>();
            this.finalPrice = this.calculateFinalPrice();
            this.dateTime = dateTime.ToLocalTime();
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