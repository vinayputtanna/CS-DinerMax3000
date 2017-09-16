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
            Menu summerMenu = new Menu();
            summerMenu.SetName("Summer Menu");
            summerMenu.AddMenuItem("Chicken kabab", "Chicken marinated in chilli paste and grilled in oven", 25.35);
            summerMenu.AddMenuItem("Chicken Lollipop", "Chicken drumsticks dipped in chilli paste and fried in oil", 18.99);
        }
    }
}
