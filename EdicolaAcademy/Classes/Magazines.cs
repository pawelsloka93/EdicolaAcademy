using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdicolaAcademy.Classes
{
    internal class Magazines : Releases
    {
       

        // PROPERTIES - INSTANCE VARIABLES
        public string? Title { get; set; }
        public string? Category { get; set; }


        //CONSTRUCTORS AND METHODS
        public Magazines(string? title, string? category, float price, string? serialNumber, int stockQuantity)
        {
            Title = title;
            Category = category;
            Price = price;
            SerialNumber = serialNumber;
            StockQuantity = stockQuantity;
        }


        //METHOD THAT PRINTS MAGAZINE DETAILS
        public override void printDetails()
        {
            Console.WriteLine($"[MAGAZINE] Title:{Title} | Category:{Category} | Price:{Price} | Serial Number:{SerialNumber} | Stock: {StockQuantity}");
        }
    }
}
