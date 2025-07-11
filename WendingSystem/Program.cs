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
            //Product product = new Product();
            VendingMachine vendingmachine = new VendingMachine(10000 );
            List<string> Spisok1 = new List<string>() ;
            Spisok1.AddRange(vendingmachine.Spisok);




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
        public class VendingMachine
        {
            public decimal Ballance { get; set; }
            public List<string> Spisok = new List<string>() {"яблоко ", "апельсин ", "авокадо ", "груша ", "ананас " };
            //"яблоко ", "апельсин ", "авокадо ", "груша ", "ананас "
            public VendingMachine(decimal ballance)
            {
                Ballance = ballance;
                
            }

            public void DisplayProducts() 
            {
                for (int i = 0; i < Spisok.Count; i++)
                {
                    Console.WriteLine(Spisok[i]);
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
