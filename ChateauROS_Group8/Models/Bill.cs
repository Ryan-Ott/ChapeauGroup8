using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bill
    {
        public int BillID { get; set; }
        public string PaymentMethod { get; set; } //cash, pin, AMEX or VISA
        public double Tax6 { get; set; } //amount of tax for items with 6% VAT
        public double Tax21 { get; set; } //amount of tax for items with 21% VAT
        public double Tip { get; set; } //value of optional tip left by customer
        public double Total { get; set; } //total sum to be paid by customer
    }
}
