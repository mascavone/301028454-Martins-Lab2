using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301028454_Martins_Lab2
{
    public class CheckOut
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int Quantity { get; set; }

        public const double Tax = 0.13;

    public string PrintItem()
        {
            return ID + ItemName + ItemPrice + Quantity;
        }
        public double CalculateSubTotal()
        {
            return ItemPrice * Quantity;
        }

        public double CalculateTax(double subtotal)
        {
            return subtotal*Tax;
        }

        public double CalculateTotal(double subtotal)
        {
            return subtotal + (subtotal * Tax);
        }
        //public string Total { get; set; }
    }
}
