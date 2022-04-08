using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruidClub
{
    internal class DruidClub
    {
        public int Pizza { get; set; }
        public int Burger { get; set; }
        public int Soup { get; set; }
        public int Steak { get; set; }
        public int HotDog { get; set; }
        public Dictionary<string,int> Order = new Dictionary<string,int>();

        public virtual void MakePizza(int count)
        {
            Pizza += count;
        }

        public virtual void MakeBurger(int count)
        {
            Burger+=count;
        }
        public virtual void MakeSoup(int count)
        {
            Soup+=count;
        }
        public virtual void MakeSteak(int count)
        {
            Steak+= count;
        }
        public virtual void MakeHotDog(int count)
        {
            HotDog+=count;
        }
        public void MakeOrder()
        {
            Console.WriteLine("What do you want?");
            string food = Console.ReadLine();
            Console.WriteLine("How Many");
            int count = int.Parse(Console.ReadLine());
            switch (food)
            {
                case "Pizza":
                    MakePizza(count);
                    Order.Add("Pizza",Pizza);
                    break;
                case "Burger":
                    MakeBurger(count);
                    Order.Add("Burger", Burger);
                    break;
                case "Soup":
                    MakeSoup(count);
                    Order.Add("Soup",Soup);
                    break;
                case "Steak":
                    MakeSteak(count);
                    Order.Add("Steak",Steak);
                    break;
                case "HotDog":
                    MakeHotDog(count);
                    Order.Add("HotDog",HotDog);
                    break;
            }
        }
        public void GetNumberOfFoods()
        {
            Console.WriteLine(Pizza);
            Console.WriteLine(Soup);
            Console.WriteLine(HotDog);
            Console.WriteLine(Steak);
            Console.WriteLine(Burger);
        }
        public void GetOrderList()
        {
            foreach (var item in Order)
                Console.WriteLine(item);
        }
    }
}

