using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 76, usdToRub = 75, euroToRub = 80, rubToEuro = 81;
            float rub;
            float usd;
            float euro;
            string userInput;
            string stopWord = "exit";
            bool canExamination = true;
            float currencyCount;

            Console.WriteLine(" Обменик валют ");

            Console.Write(" Введите баланс рублей ");
            rub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите баланс долларов ");
            usd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите баланс евро ");
            euro= Convert.ToInt32(Console.ReadLine());

            while (canExamination)  
            {
                Console.WriteLine(" 1 - обмен рублей на доллары");
                Console.WriteLine(" 2 - обмен долларов на рубли ");
                Console.WriteLine(" 3 - обмен рублей на евро ");
                Console.WriteLine("4 - обмен евро на рубли");
                Console.WriteLine(" Обмен рублей на доллары ");
                    Console.WriteLine(" Сколько вы хотите обменять ");
                    userInput= Console.ReadLine();
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rub >=currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine(" Недостаточное кол-во рублей ");                     
                    }
                    Console.WriteLine(" Обмен долларов на рубли ");
                    Console.WriteLine(" Сколько вы хотите обменять ");
                    userInput= Console.ReadLine();
                    currencyCount= Convert.ToSingle(Console.ReadLine());
                    if(usd>=currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount / rubToUsd;
                    }
                    else
                {
                    Console.WriteLine(" Недостаточное кол-во долларов ");
                }
                    Console.WriteLine(" Обмен рублей на евро ");
                    Console.WriteLine(" Сколько вы хотите обменять ");
                    userInput= Console.ReadLine();
                    currencyCount= Convert.ToSingle(Console.ReadLine());
                    if(rub>=currencyCount)
                    {
                        rub -= currencyCount;
                        euro += currencyCount / rubToEuro;
                    }
                    else
                {
                    Console.WriteLine(" Недостаточное кол-во рублей");
                }
                    Console.WriteLine(" Обмен евро на рубли ");
                    Console.WriteLine(" Сколько вы хотите обменять ");
                    userInput= Console.ReadLine();
                    currencyCount= Convert.ToSingle(Console.ReadLine());
                    if(euro>=currencyCount)
                    {
                        euro -= currencyCount;
                        rub += currencyCount / rubToEuro;
                }
                    else
                {
                    Console.WriteLine(" Недостаточное кол-во евро ");
                }
                    if (userInput == stopWord)
                {
                    canExamination = false;
                }
            }
            Console.WriteLine(" Ваш баланс рублей " + rub + " баланс долларов и " + usd + " баланс евро " + euro);
        }
    }
}
