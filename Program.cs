// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


public class Program
{
    //Handles errors when a user choses invalid menu option and logs them
    public static void ErrorLogging(string error) 
    {

        using (StreamWriter W = File.AppendText(@"./Error.txt"))
        {
            W.WriteLine(error);
        }
        Console.WriteLine("Try again ");
       
    }

    public static void Main(string[] args)
    {
        //Creating a new error file to log and closing it
        using (File.Create(@"./Error.txt")) { }

            string FilePath = @"./WineDescription.json";
        string ReadText = File.ReadAllText(FilePath);

        List<WineClass> inventory = System.Text.Json.JsonSerializer.Deserialize<List<WineClass>>(ReadText);
        string menuchoice;
        do
        {
            Console.WriteLine("\nPlease choose from menu options:");
            Console.WriteLine(" 1. Inventory current status");
            Console.WriteLine(" 2. Select wine from inventory file");
            Console.WriteLine(" 3. Add a wine to inventory file");
            Console.WriteLine(" 4. Exit \n");
            menuchoice = Console.ReadLine();

            

            Console.WriteLine("\nYou have chosen menu option #" + menuchoice);
                    

            if (menuchoice == "1")
            {
                ReadText = File.ReadAllText(FilePath);
                Console.WriteLine(ReadText);

            }
            else if (menuchoice == "2")
            {
                Console.WriteLine("\nPlease choose a wine name from the current inventory list and type below: ");
               
                foreach (WineClass item in inventory)
                {
                    Console.WriteLine(item.WineName);
                }

                    string UserWineChoice = Console.ReadLine();

                foreach (WineClass item in inventory)
                {
                    if (item.WineName == UserWineChoice)
                    {
                        Console.WriteLine("Wine Name: " + item.WineName);
                        Console.WriteLine("Description: " + item.Description);
                        Console.WriteLine("Quantity: " + item.Quantity);
                        Console.WriteLine("Supplier Name: " + item.SupplierName);
                        Console.WriteLine ("Price: " + item.Price);
                    }
                }
            }
            else if (menuchoice == "3")
            {
                WineClass item = new WineClass();

                Console.WriteLine("Please enter Wine Name");
                item.WineName = Console.ReadLine();

                Console.WriteLine("Please enter Wine Description");
                item.Description = Console.ReadLine();

                Console.WriteLine("Please enter Quantity");
                item.Quantity = Console.ReadLine();

                Console.WriteLine("Please enter Supplier Name");
                item.SupplierName = Console.ReadLine();

                Console.WriteLine("Please enter Price");
                item.Price = Console.ReadLine();

                Console.WriteLine("\nYou can choose the menu option #1 to check the wine is added to current inventory");

                //Adds a new wine to json file and shows in inventory list on next inventory status
                inventory.Add(item);
                System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions();
                options.WriteIndented = true;
                var json = System.Text.Json.JsonSerializer.Serialize<List<WineClass>>(inventory, options);
                File.WriteAllText(FilePath, json);
            }
            else if(menuchoice !="4")
            {
                Console.WriteLine("Please enter a valid menu choice: 1,2,3 or 4");
               ErrorLogging(menuchoice);
            }
         } while (menuchoice != "4");


      
       
       





    }

}
