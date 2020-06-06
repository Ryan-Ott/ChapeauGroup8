using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Logic;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill_Service bill_Service = new Bill_Service();
            try
            {
                bill_Service.AddNewBill(new Bill(0));
                Bill lastBill = bill_Service.GetLastBill();
                Console.WriteLine(lastBill);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
            Console.ReadKey();
        }
    }
}
