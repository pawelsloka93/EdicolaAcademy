using EdicolaAcademy.Classes;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EdicolaAcademy
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool insAbi = true;
            while (insAbi)
            {
                //USER MENU PRINTS
                Console.WriteLine("|WELCOME TO YOUR BOOKSTALL MANAGEMENT MENU \n Press \n 1 to insert Newspaper \n 2 to insert Magazine " +
               "\n 3 to delete a release \n 4 to view store list \n 5 to update stock quantity \n 9 to QUIT ");

                //user choice variables
                string? userChoice = Console.ReadLine();
                int choice = Convert.ToInt32(userChoice);
                //-------------------------------------------------------------------------------------------------------------------------
                switch (choice)
                {
                    case 1: //insert newspaper
                        bool Insert = true;

                        Console.WriteLine("Insert editorial name:");

                        string? editor = Console.ReadLine();

                        Console.WriteLine(" Your newspaper have an insert?  true or false");

                        string? hasInsert = Console.ReadLine();


                        if (hasInsert == "true")
                        {
                            Insert = true;

                        }
                        else if (hasInsert == "false")
                        {
                            Insert = false;
                           
                        }
                       
                       
                        Console.WriteLine("Insert price");

                        string? pricef = Console.ReadLine();

                        float number;

                        if (float.TryParse(pricef, out number))
                        {
                            Console.WriteLine("price added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Enter a decimal number.");
                        }
                        Console.WriteLine("Insert serial number");

                        string? numSer = Console.ReadLine();

                        Console.WriteLine("insert quantity stock");

                        string? quant = Console.ReadLine();

                        int stockQuantity = Convert.ToInt32(quant);

                        Newspapers uno = new Newspapers(editor, Insert, number, numSer, stockQuantity);
                        
                        
                        Bookstall.addReleases(uno);

                        Bookstall.printList();

                        break;
             //-----------------------------------------------------------------------------------------------------------------------------
                    case 2: //Insert magazine
                        Console.WriteLine("Insert title:");

                        string?title = Console.ReadLine();

                        Console.WriteLine("insert category");

                        string?category = Console.ReadLine();

                        Console.WriteLine("Insert price");

                        string? pricefm = Console.ReadLine();

                        float number1;

                        if (float.TryParse(pricefm, out number1))
                        {
                            Console.WriteLine("price added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Enter a decimal number.");
                        }
                        Console.WriteLine("Insert serial number");

                        string? numSerL = Console.ReadLine();

                        Console.WriteLine("insert quantity stock");

                        string? quant1 = Console.ReadLine();

                        int stockQuantity1 = Convert.ToInt32(quant1);

                        Magazines mag = new Magazines(title, category, number1, numSerL, stockQuantity1);

                        Bookstall.addReleases(mag);

                        Bookstall.printList();

                        break;
            //--------------------------------------------------------------------------------------------------------------------------------
                    case 3:// release remove
                        
                           Console.WriteLine("insert serial number to remove");
                           string? remove = Console.ReadLine();
                           Bookstall.removeReleases(remove);
                           Bookstall.printList();
                        break;
            //-----------------------------------------------------------------------------------------------------------------------------------------
                    case 4://store list
                        
                        Bookstall.printList();
                        break;

            //-------------------------------------------------------------------------------------------------------------------
                    case 5://stock update

                        Console.WriteLine("Enter the serial code of the release to update:");

                        string? serialToUpdate = Console.ReadLine();

                        Console.WriteLine("Insert new stock quantity:");

                        string? newStockQuantityInput = Console.ReadLine();

                        int newStockQuantity;

                        if (int.TryParse(newStockQuantityInput, out newStockQuantity))
                        {
                            Bookstall.UpdateStockQuantity(serialToUpdate, newStockQuantity);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Enter an integer for the new stock quantity.");
                        }
                        Bookstall.printList();
                        break;
            //---------------------------------------------------------------------------------------------------------------------------------
                    case 9: //quit program

                        insAbi = false;
                        break;
                        
                        
                        

                        
                }

            }




        }
    }
}

