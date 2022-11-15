using Oops.InventoryDataManagement;
using Oops.InventoryManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string InventoryFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\OopsConcept\Oops\InventoryManagement\Inventory.json";
        static string jsonDataFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\OopsConcept\Oops\InventoryDataManagement\InventoryData.Json";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOPS Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Inventory Data Management");
                Console.WriteLine("Select the option");
                Console.WriteLine("1.InventoryManagement " + "\n" +
                                  "2.InventoryDataManagement" + "\n" +
                                  "3.Exit" + "\n");
               
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
                            inventoryDetailsManagement.ReadJSonFile(InventoryFilePath);
                            break;
                        case 2:
                            InventoryManager inventoryManager = new InventoryManager();
                            inventoryManager.ReadJSONFile(jsonDataFilePath);
                            break;
                        case 3:
                            flag = false;
                            break;

                    }

                }                
            }                         
        }
    }
}