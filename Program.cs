// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
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

        } while (menuchoice != "4");

        int length = 6;
        //Wineinventory[]
        //WineInventory inventory = new WineInventory();
        string json = "{Wine Name: Chardonnay 2016, " +
            "Description: A creamy and flavourful medium-bodied wine, it’s full and well-rounded with plenty of intense, fruity notes, " +
            "Quantity:10, " +
            "Supplier Name: Grgich Hills Estate, " +
            "Price: $40}";


        Wineinventory[] array = new Wineinventory[1];
        array[0] = new Wineinventory();
        array[0].WineName = "Chardonnay 2016";

        Console.WriteLine(array[0].WineName);

        string FilePath = @"./WineDescription.json";
        //using (FileStream sourceStream = File.OpenRead(FilePath)) { 
        string ReadText = File.ReadAllText(FilePath);
        //Console.WriteLine(ReadText);

        // Console.WriteLine(System.Text.Json.JsonSerializer.Deserialize<WineInventory>(sourceStream));

        // Console.WriteLine(inventory[1].WineName);
        
            



    }

}
