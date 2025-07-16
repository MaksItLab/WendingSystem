using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WendingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VendingMachine vendingmachine = new VendingMachine();
            // Product product = new Product();
            
            vendingmachine.InsertMoney(254);
            vendingmachine.DisplayProducts();
            vendingmachine.BuyProduct();
            vendingmachine.ReturnChange();
            vendingmachine.InsertMoney(500);












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
                Console.WriteLine("введите номер товара!");
                int element1 = int.Parse(Console.ReadLine());
                decimal element3 = Balance;
                if (element1 <= 3 && element1 >= 0) 
                {
                    for (int i = element1; i < Spisok.Count; )
                    {
                        Console.WriteLine("выбран товар: " + Spisok[i].Name + "\nцена составит: " + Spisok[i].Price + "\nв наличии имеется: " + Spisok[i].Quantity);
                        if (Spisok[i].Quantity <= 0 || Balance < Spisok[i].Price)
                        {
                            Console.WriteLine("недостаточно средств или товара нет в наличии, просьба ознакомиться с описанием товара!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("вы действительно хотите приобрести этот товар! " + "\nyes/no");
                            string element4 = Console.ReadLine();
                            if (element4 == "yes") 
                            {
                                Balance = element3 - Spisok[i].Price;
                                Spisok[i].Quantity--;
                                Console.WriteLine("товар успешно приобретен! " );
                                return;
                            }
                            else
                            {
                                Console.WriteLine("операция отменена по причине отказа или ввода некорректного значения!");
                                return ;
                            }
                        }

                    }
                    
                }
                else
                {
                    Console.WriteLine("введен некорректный номер!");
                    return;
                }
            }
            public void InsertMoney(decimal balance)
            {
                
              
               
                if (balance > 0)
                {
                    decimal h = Balance;                    
                    Console.WriteLine("сумма успешно внесена!" + "\nваш баланс составляет: " + (Balance = h + balance));

                }
                else 
                {
                    Console.WriteLine("введена некорректная сумма!");
                    
                }
            }
            public void ReturnChange()
            {

                Console.WriteLine("по итогу на ваш счет возваращено: " + Balance + "руб.");
                Balance = 0;



            }
        }
    }
}
