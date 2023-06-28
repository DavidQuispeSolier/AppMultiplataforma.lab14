using System;
using System.Collections.Generic;
using System.Text;

namespace lab14.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
