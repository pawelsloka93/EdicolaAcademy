using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EdicolaAcademy.Classes
{
    internal class Bookstall
    {



        // PROPERTIES - INSTANCE VARIABLES
        public string? Name { get; set; }
        public string Address { get; set; }
        public static List<Releases> Store { get; set; } = new List<Releases>();



        //CONSTRUCTORS AND METHODS
        public Bookstall(string? name, string address)
        {
            Name = name;
            Address = address;
        }

        // METHOD THAT ADDS RELEASE TO THE STORE

        public static void addReleases(Releases rel)
        {
            Store.Add(rel);
        }


        // METHOD THAT PRINTS THE COMPLETE LIST OF RELEASES
        public static void printList()
        {
            foreach (Releases rel in Store)
            {
                rel.printDetails();
            }

        }

        // METHOD THAT REMOVES A SPECIFIC RELEASE FROM THE STORE

        public static void removeReleases(string serialNum)
        {
            // Searches for the item with the specified serial number
            Releases releaseToRemove = Store.Find(Releases => Releases.SerialNumber == serialNum);

            //If the item was found, remove it from the list
            if (releaseToRemove != null)
            {
                Store.Remove(releaseToRemove);
                Console.WriteLine("Release removed successfully");
            }
            else
            {
                Console.WriteLine("Release not found in system");
            }
        }

        //METHOD THAT ALLOWS YOU TO UPDATE THE STOCK QUANTITY OF A SPECIFIC ELEMENT

        public static void UpdateStockQuantity(string serialNum, int newQuantity) 

        {
            Releases releaseToUpdate = Store.Find(release => release.SerialNumber == serialNum);
            if (releaseToUpdate != null)
            {
                releaseToUpdate.StockQuantity = newQuantity;
                Console.WriteLine($"Quantity stock for {releaseToUpdate.SerialNumber} update to {newQuantity}");
            }
            else
            {
                Console.WriteLine("Release not found in system");
            }

        }
    }
}
