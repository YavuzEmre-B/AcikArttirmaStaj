using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcikArttirmaStaj
{
    internal class ProductManager
    {
        List<Product> products;

        public ProductManager()
        {
            products = new List<Product>() 
            {
                new Product{Id = 1, ProductName = "Laptop", LastOffer = "" , LastCustomer = ""},
                new Product{Id = 2, ProductName = "Mouse", LastOffer = "", LastCustomer = ""},
                new Product{Id = 3, ProductName = "Keyboard", LastOffer = "", LastCustomer = ""},
                new Product{Id = 4, ProductName = "Monitor", LastOffer = "", LastCustomer = ""},
                new Product{Id = 5, ProductName = "Headphones", LastOffer = "", LastCustomer = ""},
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public void GiveOffer(Product product)
        {
            Product productToUpdate = products.FirstOrDefault(p => p.Id == product.Id);
            productToUpdate.LastOffer = product.LastOffer;
        }
    }
}
