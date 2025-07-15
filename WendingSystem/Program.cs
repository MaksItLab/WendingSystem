using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WendingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VendingMachine vendingmachine = new VendingMachine();
            // Product product = new Product();
            vendingmachine.DisplayProducts();














        }

        public class Product 
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
        public class VendingMachine
        {
            public decimal Balance { get; set; } = 0;
            public List<Product> Spisok;
            //"яблоко ", "апельсин ", "авокадо ", "груша ", "ананас "
            public VendingMachine()
            {
                
                Spisok = new List<Product>()
                {
                    new Product("apple", 154, 55),
                    new Product("lime", 111, 35),
                    new Product("avocado", 254, 11),
                    new Product("bred", 54, 132)
                };
            }
            
            public void DisplayProducts() 
            {
                
                for (int i = 0; i < Spisok.Count; i++)
                {
                    
                    Console.WriteLine("товар номер:" + i + ". " + Spisok[i].Name + ". " +  "цена: " + Spisok[i].Price + "руб. " + "кол-во в наличии: " + Spisok[i].Quantity);
                }
            }
        

            public void BuyProduct()
            {
                Console.WriteLine("ваш список продуктов выглядит так: " + "\n " + "\n напишите yes, если хотите переидти к оплате или no если хотите править список!");
                string opiration = Console.ReadLine();

                Console.WriteLine("к оплате: " + " " + "руб" + "\nваш баланс составляет: " + " " + "руб" + "\nсовершить операцию? yes/no");
                string opiration1 = Console.ReadLine();

                Console.WriteLine("покупка совершена успешно! " + "\nхотите совершить следующую покупку? " + "\n yes/no ");
                string opiration2 = Console.ReadLine();
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
