using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruidClub
{
    internal class CafeDruid:DruidClub
    {
        public override void MakePizza()
        {
            Products.Tomato--;
            Products.Sausage--;
            Products.Dough--;
            Products.Mushroom--;
            Pizza++;
        }
        public override void MakeBurger()
        {
            Products.Meat--;
            Products.Cheese--;
            Products.Dough--;
            Burger++;
        }
        public override void MakeSoup()
        {
            Products.Meat++;
            Products.Potato++;
            Products.Mushroom--;
            Soup++;
        }
        
    }
}
