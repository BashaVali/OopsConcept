using Oops.InventoryManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string InventoryFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\OopsConcept\Oops\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJSonFile(InventoryFilePath);
        }
    }
}