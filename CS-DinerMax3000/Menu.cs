using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DinerMax3000
{
    public class Menu
    {
        private string name;
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return menuItems;
            }
            set
            {
                menuItems = value;
            }
        }

        public void AddMenuItem(string title, string description, double price)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.SetTitle(title);
            menuItem.SetDescription(description);
            menuItem.SetPrice(price);
            menuItems.Add(menuItem);
        }
    }
}
