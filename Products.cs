using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruidClub
{
    internal static class Products
    {
        public static int Tomato { get; set; } = 10;
        public static int Mushroom { get; set; } = 10;
        public static int Meat { get; set; } = 10;
        public static int Potato { get; set; } = 10;
        public static int Sausage { get; set; } = 10;
        public static int Cheese { get; set; } = 10;
        public static int Dough { get; set; } = 10;

        public static void AddTomato(int count)
        {
            Tomato += count;
        }
        public static void AddMushroom(int count)
        {
            Mushroom += count;
        }
        public static void AddMeat(int count)
        {
            Meat += count;
        }
        public static void AddPotato(int count)
        {
            Potato += count;
        }
        public static void AddSausage(int count)
        {
            Sausage += count;
        }
        public static void AddCheese(int count)
        {
            Cheese += count;
        }
        public static void AddDough(int count)
        {
            Dough += count;
        }
        public static void GetCountOfProducts()
        {
            Console.WriteLine("Potato" + Potato);
            Console.WriteLine("Mushroom" + Mushroom);
            Console.WriteLine("Meat" + Meat);
            Console.WriteLine("Tomato" + Tomato);
            Console.WriteLine("Sausage" + Sausage);
            Console.WriteLine("Dough" + Dough);
            Console.WriteLine("Cheese" + Cheese);
        }
        
    }
}
