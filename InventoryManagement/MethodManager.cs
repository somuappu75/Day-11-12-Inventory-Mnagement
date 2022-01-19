using System;
using System.Collections.Generic;
using System.Text;
using static InventoryManagement.InventorySupport;

namespace InventoryManagement
{
    internal interface  MethodManager
    {
        // Interface Class Display methods
        void DisplayInventory(List<Rice> ricelist);
        void DisplayInventory(List<Wheat> wheatList);
        void DisplayInventory(List<Pulse> pulseList);
        //Add Methods
        void AddInventory(List<Wheat> wheatList);
        void AddInventory(List<Pulse> pulseList);
        void AddInventory(List<Rice> ricelist);
        //Delete Methods
        void DeleteInventory(List<Rice> riceList);
        void DeleteInventory(List<Pulse> pulseList);
        void DeleteInventory(List<Wheat> wheatList);
    }
}
