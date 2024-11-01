using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Model
{
    internal class PendingProducts
    {
        public int Id = 0;
        public Client? Client;
        public Product? Product;
        public int Amount;
        public decimal TotalPay;
        public DateOnly EntryDate;
        public Prescription? Prescription;
    }
}
