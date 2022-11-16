using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.Business;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace HiTechOrderSystem.DataAccess
{
    
    public static class OrderDA
    {
        static string dir = @"";
        static string filePath = dir + "Orders.bin";
        static string filePath2 = dir + "OrderTemp.bin";

        public static bool CheckClientID(int cid)
        {
            
           Client cl=ClientDA.SearchID(cid);
            if (cl!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckProductID(int pid)
        {
            Product p = ProductDA.SearchID(pid);
            if (p != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckQOH(int pid , int oq)
        {
            Inventory i = InventoryDA.SearchID(pid);
            if (i.QOH >= oq)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void SaveRecord(Order o)
        {
            if (CheckClientID(o.ClientID) == true)
            {
                if (CheckProductID(o.ProductID) == true)
                {
                    if (CheckQOH(o.ProductID, o.Quantity) == true)
                    {
                        FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                        BinaryFormatter binF = new BinaryFormatter();
                        binF.Serialize(fs, o);
                        fs.Close();
                        int Inv = InventoryDA.SearchID(o.ProductID).QOH - o.Quantity;
                        Inventory i = new Inventory(o.ProductID, Inv);
                        InventoryDA.UpdateRecord(i);
                        MessageBox.Show("Order info has been saved successfully", "Successfully Saved");
                    }
                    else
                    {
                        MessageBox.Show("Quantity Not Enough!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Product Not Found!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Client Not Found!", "Error");
            }
        }
        public static Order SearchRecord(int oid)
        {

            if (File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binF = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Order o = new Order();
                    o = (Order)binF.Deserialize(fs);
                    if(o.OrderNumber==oid)
                    {
                        fs.Close();
                        return o;
                    }
                   
                }
                fs.Close();

            }

            else
            {
                MessageBox.Show("File not found!", "Missing File");
            }

            return null;
        }
        public static List<Order> GetAllRecords()
        {
            List<Order> listAll = new List<Order>();

            if (File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binF = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Order o = new Order();
                    o = (Order)binF.Deserialize(fs);
                    listAll.Add(o);

                }
                fs.Close();
                return listAll;

            }
            else
            {
                listAll = null;
                MessageBox.Show("File Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listAll;
        }
        public static void DeleteRecord(int id)
        {
            List<Order> lstorder = GetAllRecords();
            List<Order> lsttemporder = new List<Order>();

            foreach (Order or in lstorder)
            {
                if (or.OrderNumber != id)
                {
                    lsttemporder.Add(or);
                }
            }
            FileStream fr = new FileStream(filePath2, FileMode.Append, FileAccess.Write);

            BinaryFormatter binF = new BinaryFormatter();
            foreach (Order or in lsttemporder)
            {
                binF.Serialize(fr, or);
            }

            fr.Close();
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }

        public static void UpdateRecord(Order o)
        {

            List<Order> lstorder = GetAllRecords();
            List<Order> lsttemporder = new List<Order>();
            foreach (Order or in lstorder) 
            {
                if (or.OrderNumber != o.OrderNumber) 
                {
                    lsttemporder.Add(or);
                }
            }
            lsttemporder.Add(o);

            FileStream fr = new FileStream(filePath2, FileMode.Append, FileAccess.Write);

            BinaryFormatter binF = new BinaryFormatter();
            foreach (Order or in lsttemporder)
            {
                binF.Serialize(fr, or);
            }
            fr.Close();
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }
    }
}
