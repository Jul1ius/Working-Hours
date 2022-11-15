using System;

namespace Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (hour >= 10 && hour <= 18)
            {
                switch (day)
                {
                    case "Monday": break;
                    case "Tuesday": break;
                    case "Wednesday": break;
                    case "Thursday": break;
                    case "Friday": break;
                    case "Saturday": break;
                }
            Console.WriteLine("open");
                }
            else
            {
                Console.WriteLine("closed");
            }
            
            
                
                



            }
        }
    }

