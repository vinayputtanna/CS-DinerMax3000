using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DinerMax3000
{
    public class MenuItem
    {
        private string title;
        private string description;
        private double price;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
