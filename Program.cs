// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {

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

            // if (menuchoice > 4 || menuchoice <= 0)
            //{
            //    Console.WriteLine("Please choose from option 1 to 4")
            //}

            Console.WriteLine("\n You have chosen menu option #" + menuchoice);
            //Add code to call menu option #1 here
            //Add code to call menu option #2 here

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
                        Console.WriteLine(item.Description);
                        Console.WriteLine(item.Quantity);
                        Console.WriteLine(item.SupplierName);
                        Console.WriteLine(item.Price);
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

                inventory.Add(item);
                var json = System.Text.Json.JsonSerializer.Serialize<List<Class1>>(inventory);
                File.WriteAllText(FilePath, json);
            }

            } while (menuchoice != "4");


      
       
       





    }

}
