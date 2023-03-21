using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Linq
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }

        public Product(int id, string name, string categoryName)
        {
            
            ID = id;
            Name = name;
            CategoryName = categoryName;
        }
    }
}
