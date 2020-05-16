using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPharmacy
{
    class Store
    {
        public string Name { get; set; }
        public List<Product> allProducts = new List<Product>();
        public void AddProduct(Product product)
        {
            allProducts.Add(product);
        }
        public List<Product> GetAllProducts()
        {
            return allProducts;
        }
        public List<Product> GetAllProductsByType(string type)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in allProducts)
            {
                if (product.Type == type)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
    }

}
