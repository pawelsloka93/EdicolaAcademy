using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdicolaAcademy.Classes
{
    public abstract class Releases 
    {

        // PROPERTIES - INSTANCE VARIABLES

        public float Price { get; set; }

        public string? SerialNumber { get; set; }

        public int StockQuantity { get; set; }

        /* CONSTRUCTORS AND METHODS
         * 
         * 
         * METHOD THAT PRINTS PUBLICATION DETAILS */

        public abstract void printDetails();
         
        


    }
}
