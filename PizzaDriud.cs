using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruidClub
{
    internal class PizzaDriud:DruidClub
    {
        public override void MakePizza(int count)
        {
            Products.Tomato--;
            Products.Sausage--;
            Products.Dough--;
            Products.Mushroom--;
            Pizza+=count;
        }
        public override void MakeBurger(int count)
        {
            Products.Meat--;
            Products.Cheese--;
            Products.Dough--;
            Burger+=count;
        }
        public override void MakeHotDog(int count)
        {
            Products.Cheese--;
            Products.Dough--;
            Products.Sausage--;
            HotDog+=count;
        }
    }
}
