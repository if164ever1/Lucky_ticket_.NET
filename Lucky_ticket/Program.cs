using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_ticket
{
    class Program
    {
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This program determines whether you have entered a lucky number");
            Console.WriteLine("\t\t1. Enter the number. Must be between 4 and 8 digits.\n" +
                "\t\t2. To exit the program, press q.\n");
            Console.ResetColor();
        }

        static void HappyTicket(ref List<int> list, int digits, string str)
        {
            int sumLeft = 0, sumRight = 0;
            if (digits % 2 == 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    list.Add((int)Char.GetNumericValue(str[i]));
                    if (i < str.Length / 2)
                        sumLeft += int.Parse(list[i].ToString());
                    else
                        sumRight += int.Parse(list[i].ToString());
                }
            }

            else
            {
                list.Add(0);
                for (int i = 0; i < str.Length; i++)
                {   
                    list.Add((int)Char.GetNumericValue(str[i]));
                    if (i < str.Length / 2)
                    {
                        sumLeft += int.Parse(list[i+1].ToString());
                    }
                    else
                        sumRight += int.Parse(list[i+1].ToString());
                }
            }
            Console.WriteLine((sumLeft == sumRight) ? " Ticket is Happy " : " Ticket NOT Happy");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                string s;
                s = Console.ReadLine();
                List<int> b = new List<int>();
                int digits = (int)Math.Floor(Math.Log10(Convert.ToInt32(s)) + 1);
                Console.WriteLine(digits);
                HappyTicket(ref b, digits, s);   
            }
        }
    }
}
