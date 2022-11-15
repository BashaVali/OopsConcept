using Newtonsoft.Json;
using Oops.InventoryDataManagement;
using Oops.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InventoryDataManagement
{
     class InventoryManagement
    {
        public void ReadJSONFile(string file)
        {
            var json = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(json);
            List<Inventory> RiceList = inventories.Rice;
           
            Display(RiceList);
            List<Inventory> WheatList = inventories.Wheat;
           
            Display(WheatList);
            List<Inventory> PulsesList = inventories.Pulses;
           
            Display(PulsesList);
        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " \n " + data.Weight + " \n " + data.Price);
            }
        }
    }
}
