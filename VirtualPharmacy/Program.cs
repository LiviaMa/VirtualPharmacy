using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPharmacy
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();
            store.Name = "Catena";
            Console.WriteLine("Welcome at " + store.Name + "!");
            while (true)
            {
                Console.WriteLine("Pick one of the options below" + "\n1.Add new product\n2.Display all products\n3.Display products by certain type\n4.Exit");
                Console.WriteLine("Your choice is:");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    var product = new Product();

                    Console.WriteLine("Enter name:");
                    product.Name = Console.ReadLine();
                    Console.WriteLine("Enter type:");
                    product.Type = Console.ReadLine();
                    Console.WriteLine("Enter brand:");
                    product.Brand = Console.ReadLine();
                    store.AddProduct(product);
                    Console.WriteLine("Product added succesfully!");
                }
                else if (input == "2")
                {
                    int counter = 1;
                    foreach (Product product in store.GetAllProducts())
                    {
                        Console.WriteLine("#" + counter++ + " " + product.ToString());
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter the type of product:");
                    string typeOfProduct = Console.ReadLine();
                    store.GetAllProductsByType(typeOfProduct);
                    int counter = 1;
                    foreach (Product product in store.GetAllProductsByType(typeOfProduct))
                    {
                        Console.WriteLine("#" + counter++ + " " + product.ToString());
                    }
                }
                else if(input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }
            }

        }
    }
}
