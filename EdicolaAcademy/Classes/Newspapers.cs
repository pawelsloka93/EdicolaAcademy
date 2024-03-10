using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdicolaAcademy.Classes
{
    internal class Newspapers : Releases
    {
        
        // PROPERTIES - INSTANCE VARIABLES
        public string? Editorial { get; set; }
        public bool HasInsert { get; set; }

        // CONSTRUCTORS AND METHODS

        public Newspapers(string? editorial, bool hasInsert, float price, string? serialNumber, int stockQuantity)
        {
            Editorial = editorial;
            HasInsert = hasInsert;
            Price = price;
            SerialNumber = serialNumber;
            StockQuantity = stockQuantity;
        }

        public Newspapers(string? editor)
        {
        }



        //METHOD THAT PRINTS NEWSPAPER DETAILS
        public override void printDetails()
        {
            Console.WriteLine( $" [NEWSPAPER] Editorial:{Editorial} | Insert:{HasInsert} | Price:{Price} | Serial number:{SerialNumber} | Stock: {StockQuantity}");
        }
    }
}
