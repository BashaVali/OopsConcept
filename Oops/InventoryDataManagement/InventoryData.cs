using Oops.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InventoryDataManagement
{
     class InventoryData 
    {
        public List<Inventory> Rice { get; set; }
        public List<Inventory> Wheat { get; set; }

        public List<Inventory> Pulses { get; set; }

    }
}