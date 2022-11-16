using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.DataAccess;
using System.Windows.Forms;

namespace HiTechOrderSystem.Business
{
    public class Inventory
    {
        public int ProductID { get; set; }
        public int QOH { get; set; }
        public Inventory()
        {
           
        }
        public Inventory(int pid, int num) 
        {
            this.ProductID = pid;
            this.QOH = num;
        }

        public Inventory SearchID(int pid) 
        {
           return InventoryDA.SearchID(pid);
        }
        public void SaveInventory(Inventory i) 
        {
            InventoryDA.SaveInventory(i);
        }
        public void DeleteRecord(int id)
        {
            InventoryDA.DeleteRecord(id);
        }


        public void UpdateRecord(Inventory i) 
        {
            InventoryDA.UpdateRecord(i);
        }
    }
}
