using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruidClub
{
    internal class RestDruid : DruidClub
    {
        public override void MakePizza(int count)
        {
            Products.Tomato--;
            Products.Sausage--;
            Products.Dough--;
            Products.Mushroom--;
            Pizza += count;
        }
        public override void MakeBurger(int count)
        {
            Products.Meat--;
            Products.Cheese--;
            Products.Dough--;
            Burger += count;
        }
        public override void MakeSoup(int count)
        {
            Products.Meat++;
            Products.Potato++;
            Products.Mushroom--;
            Soup += count;
        }
        public override void MakeSteak(int count)
        {
            Products.Meat--;
            Products.Mushroom--;
            Steak += count;
        }
        public override void MakeHotDog(int count)
        {
            Products.Cheese--;
            Products.Dough--;
            Products.Sausage--;
            HotDog += count;
        }
    }
}
