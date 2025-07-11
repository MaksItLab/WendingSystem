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

            public void DisplayProducts()
            {
                var rand = new Random();
                var randcena = new Random();
                Console.WriteLine("список ассортимента продуктов выглядит: ");
                List<string> spisok = new List<string>(10) {"(яблоко) индекс товара: №12774 ", "(ананас) индекс товара: №65345 ", "(апельсин) индекс товара: №68442 ", "(авокадо) индекс товара: №31754 ", "(банан) индекс товара: №18732 ", "(виноград) индекс товара: №98431 ", "(персик) индекс товара: №87575 ", "(груша) индекс товара: №71490 ", "(картошка) индекс товара: №00642 ", "(лимон) индекс товара: №50492 ", };
                int elementnumber = 0;
               
                for (int i = 0; i < spisok.Count; i++)
                {
                    elementnumber++;
                    Console.WriteLine(elementnumber + " " + spisok[i] + " цена: " + randcena.Next(75, 250) + "руб/100гр. " + " в наличии имеется: " + rand.Next(10, 1010));
                }
                int element = int.Parse(Console.ReadLine());
                if (element == 12774)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (яблоко)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 65345)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (ананас)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 68442)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (апельсин)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 31754)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (авокадо)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 18732)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (банан)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 98431)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (виноград)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 87575)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (персик)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 71490)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (груша)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 00642)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (картошка)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
                }
                if (element == 50492)
                {
                    Console.WriteLine("вы хотите купить именно этот товар (лимон)" + "\n yes/no ");
                    string element1 = Console.ReadLine();
                    if (element1 == "yes")
                    {
                        Console.WriteLine("товар успешно добавлен в корзину!");
                    }
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
