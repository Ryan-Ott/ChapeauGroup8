﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bill
    {
        public Bill(int billID, string paymentMethod, double tax6, double tax21, double tip, double total)
        {
            BillID = billID;
            PaymentMethod = paymentMethod;
            Tax6 = tax6;
            Tax21 = tax21;
            Tip = tip;
            Total = total;
        }

        public int BillID { get; set; }
        public string PaymentMethod { get; set; } //cash, pin, AMEX or VISA
        public double Tax6 { get; set; } //amount of tax for items with 6% VAT
        public double Tax21 { get; set; } //amount of tax for items with 21% VAT
        public double Tip { get; set; } //value of optional tip left by customer
        public double Total { get; set; } //total sum to be paid by customer
    }
}