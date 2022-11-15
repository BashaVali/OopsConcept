using Oops.InventoryDataManagement;
using Oops.InventoryManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string inventoryFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\OopsConcept\Oops\InventoryManagement\Inventory.json";
        static string inventoryDataFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\OopsConcept\Oops\InventoryDataManagement\InventoryData.Json";
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
                                  "4.DeleteInventoryData"+"\n"+
                                  "5.Exit" + "\n");
               
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
                            inventoryManagement.ReadJSONFile(inventoryDataFilePath);
                            break;
                        case 3:
                            InventoryManagement inventoryManagement1 = new InventoryManagement();
                            inventoryManagement1.ReadJSONFile(inventoryDataFilePath);
                            inventoryManagement1.AddInventoryDetails("Rice");
                            inventoryManagement1.WriteToJson(inventoryDataFilePath);
                            break;
                        case 4:
                            InventoryManagement inventoryManagement2 = new InventoryManagement();
                            inventoryManagement2.EditInventoryData();
                            break;
                        case 5:
                            flag = false;
                            break;

                    }

                }                
            }                         
        }
    }
}