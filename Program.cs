using System;

namespace DruidClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PizzaDriud pizzaDriud = new PizzaDriud();
            pizzaDriud.MakeOrder();
            pizzaDriud.MakeOrder();
            pizzaDriud.MakeOrder();
            pizzaDriud.GetOrderList();
        }
    }
}
