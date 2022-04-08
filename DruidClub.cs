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
        public virtual void MakePizza()
        {
            Pizza++;
        }

        public virtual void MakeBurger()
        {
            Burger++;
        }
        public virtual void MakeSoup()
        {
            Soup++;
        }
        public virtual void MakeSteak()
        {
            Steak++;
        }
        public virtual void MakeHotDog()
        {
           HotDog++;
        }

        public void GetNumberOfFoods()
        {
            Console.WriteLine(Pizza);
            Console.WriteLine(Soup);
            Console.WriteLine(HotDog);
            Console.WriteLine(Steak);
            Console.WriteLine(Burger);
        }
    }
}

