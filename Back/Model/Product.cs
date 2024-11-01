using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Model
{
    internal class Product
    {
        public long Id = 0;
        public string Name = string.Empty;
        public string TypeProduct = string.Empty;
        public decimal Price = 0;
        public bool NeedPrescription = false;
    }
}
