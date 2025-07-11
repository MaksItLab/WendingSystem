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
        class VendingMachine
        {
            public decimal Ballance { get; set; }

            public VendingMachine(decimal ballance)
            {
                Ballance = ballance;
            }

            public void DisplayProducts(string name, decimal price, int quantity)
            {
                
            }
        

            public void BuyProduct()
            {
                Console.WriteLine("ваш список продуктов выглядит так: " + "\n " + "\n напишите yes, если хотите переидти к оплате или no если хотите править список!");
                string opiration = Console.ReadLine();

                Console.WriteLine("к оплате: " + " " + "руб" + "\nваш баланс составляет: " + " " + "руб" + "\nсовершить операцию? yes/no");

                Console.WriteLine("покупка совершена успешно! " + "\nхотите совершить следующую покупку? " + "\n yes/no ");
                string opiration1 = Console.ReadLine();
            }
            public void InsertMoney()
            {

            }
            public void ReturnChange()
            {

            }
        }
    }
}
