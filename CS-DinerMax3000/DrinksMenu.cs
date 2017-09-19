using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DinerMax3000
{
    class DrinksMenu:Menu
    {
        private string disclaimer;

        public string Disclaimer
        {
            get
            {
                return disclaimer;
            }
            set
            {
                disclaimer = value;
            }
        }
    }
}
