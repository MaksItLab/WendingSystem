using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WendingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
           
        }
        class VendingMachine : Product
        {
            public VendingMachine(string name, decimal price, int quantity) : base(name, price, quantity)
            {
            }

            public void BuyProduct(string name, decimal price, int quantity)
            {
                Console.WriteLine("выберите из списка интересующие вас товары: ");
                string name1 = Console.ReadLine();

                Console.WriteLine("выберите кол-во: ");
                int quantity1 = int.Parse(Console.ReadLine());
            }
        }
    }
}
