using Oops.InventoryDataManagement;
using Oops.InventoryManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string inventoryFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\OopsConcept\Oops\InventoryManagement\Inventory.json";
        static string JsonDataFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\OopsConcept\Oops\InventoryDataManagement\InventoryData.Json";
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
                                  "3.AddInventoryData"+"\n" +
                                  "4.Exit" + "\n");
               
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
                            inventoryDetailsManagement.ReadJSonFile(inventoryFilePath);
                            break;
                        case 2:
                            InventoryManagement inventoryManagement = new InventoryManagement();
                            inventoryManagement.ReadJSONFile(JsonDataFilePath);
                            break;
                        case 3:
                            InventoryManagement inventoryManagement1 = new InventoryManagement();
                            inventoryManagement1.ReadJSONFile(JsonDataFilePath);
                            inventoryManagement1.AddInventoryDetails("Rice");
                            inventoryManagement1.WriteToJson(JsonDataFilePath);
                            break;
                        case 4:
                            flag = false;
                            break;

                    }

                }                
            }                         
        }
    }
}