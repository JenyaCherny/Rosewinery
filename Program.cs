// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


public class Program
{
    public static void ErrorLogging(string error) //Handles any errors when a user choses invalid menu option and logs them 
    {

        using (StreamWriter W = File.AppendText(@"./Error.txt"))
        {
            W.WriteLine(error);
        }
        Console.WriteLine("An error is logged");
       
    }

    public static void Main(string[] args)
    {
            using (File.Create(@"./Error.txt")) { }//Creating a new error file to log and closing it

            string FilePath = @"./WineDescription.json";
        string ReadText = File.ReadAllText(FilePath);

        List<Class1> inventory = System.Text.Json.JsonSerializer.Deserialize<List<Class1>>(ReadText);
        string menuchoice;
        do
        {
            Console.WriteLine("Please choose from menu options:");
            Console.WriteLine("1. Add wine to inventory file");
            Console.WriteLine("2. Select wine from inventory file");
            Console.WriteLine("3. Inventory current status");
            Console.WriteLine("4. Exit \n");
            menuchoice = Console.ReadLine();

            

            Console.WriteLine("\n You have chosen menu option #" + menuchoice);
                    

            if (menuchoice == "3")
            {
                ReadText = File.ReadAllText(FilePath);
                Console.WriteLine(ReadText);

            }
            else if (menuchoice == "2")
            {
                Console.WriteLine("Please choose Wine Name");
                string UserWineChoice = Console.ReadLine();

                foreach (Class1 item in inventory)
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
            else if (menuchoice == "1")
            {
                Class1 item = new Class1();

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

                inventory.Add(item);//Adds a new wine to json file and shows in inventory list on next inventory status
                System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions();
                options.WriteIndented = true;
                var json = System.Text.Json.JsonSerializer.Serialize<List<Class1>>(inventory, options);
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
