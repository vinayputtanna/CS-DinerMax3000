using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DinerMax3000
{
    class Menu
    {
        private string name;
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }

        public void SetMenuItems(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
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
