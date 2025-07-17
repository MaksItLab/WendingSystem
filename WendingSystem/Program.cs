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
            while (true) 
            {
                Console.WriteLine("здравствуйте, выберите операцию: \n1.InsertMoney \n2.DisplayProducts \n3.BuyProduct \n4.ReturnChange \n5.завершить работу.");
                string number = Console.ReadLine();
                
                switch (number)
                {
                    case "1":
                        Console.WriteLine("введите сумму для пополнения: ");
                        vendingmachine.InsertMoney(decimal.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        vendingmachine.DisplayProducts();
                        break;
                    case "3":
                        Console.WriteLine("выберите продукт для покупки по его номеру: ");
                        vendingmachine.BuyProduct(int.Parse(Console.ReadLine()));
                        break;
                    case "4":
                        vendingmachine.ReturnChange();
                        break;
                    case "5":
                        Console.WriteLine("программа успешно завершила работу!");
                        return;
                    default:
                        Console.WriteLine("введен некорректный номер, повторите попытку!");
                        break;

                }
            }
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
        
            public void BuyProduct(int CodeOfProduct)
            {
                if (CodeOfProduct <= Spisok.Count - 1 && CodeOfProduct >= 0) 
                {
                        Console.WriteLine("выбран товар: " + Spisok[CodeOfProduct].Name + "\nцена составит: " + Spisok[CodeOfProduct].Price);
                        if (Spisok[CodeOfProduct].Quantity <= 0 || Balance < Spisok[CodeOfProduct].Price)
                        {
                            Console.WriteLine("недостаточно средств или товара нет в наличии, просьба ознакомиться с описанием товара!");
                        }
                        else
                        {
                            Console.WriteLine("вы действительно хотите приобрести этот товар!\nyes/no");
                            string choice = Console.ReadLine();
                            if (choice == "yes") 
                            {
                                Balance = Balance - Spisok[CodeOfProduct].Price;
                                Spisok[CodeOfProduct].Quantity--;
                                Console.WriteLine("товар успешно приобретен! " );
                            }
                            else
                            {
                                Console.WriteLine("операция отменена по причине отказа или ввода некорректного значения!"); 
                            }
                        }
                }
                else
                {
                    Console.WriteLine("введен некорректный номер!");
                }
            }

            public void InsertMoney(decimal balance)
            {
                if (balance > 0)
                {
                    Balance = Balance + balance;
                    Console.WriteLine("сумма успешно внесена!" + "\nваш баланс составляет: " + Balance );
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
