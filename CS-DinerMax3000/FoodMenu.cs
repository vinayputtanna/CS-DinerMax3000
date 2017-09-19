using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DinerMax3000
{
    class FoodMenu:Menu
    {
        private string hospitalDirections;

        public string HospitalDirections
        {
            get
            {
                return hospitalDirections;
            }
            set
            {
                hospitalDirections = value;
            }
        }
    }
}
