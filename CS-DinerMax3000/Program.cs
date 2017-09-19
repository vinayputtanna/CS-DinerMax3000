using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DinerMax3000
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name="Summer Menu";
            summerMenu.AddMenuItem("Chicken kabab", "Chicken marinated in chilli paste and grilled in oven", 25.35);
            summerMenu.AddMenuItem("Chicken Lollipop", "Chicken drumsticks dipped in chilli paste and fried in oil", 18.99);
            summerMenu.HospitalDirections="Call 911 and wait for help.";

            DrinksMenu summerDrinks = new DrinksMenu();
            summerDrinks.Name="Summer Drinks";
            summerDrinks.AddMenuItem("Coconut water", "Tender coconut water", 25);
            summerDrinks.Disclaimer="Do not drink and drive";

            Order todaysOrder = new Order();
            foreach(MenuItem item in summerMenu.MenuItems)
            {
                todaysOrder.GetOrderItems().Add(item);
            }
        }
    }
}
