using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.Business;
using System.IO;
using System.Windows.Forms;


namespace HiTechOrderSystem.DataAccess
{
   public static class InventoryDA
    {
        static string filePath = Application.StartupPath + @"\Inventory.dat";
        static string filePath2 = Application.StartupPath + @"\InventoryTemp.dat";
        public static Inventory SearchID(int pid)
        {
            Inventory a = new Inventory();

            StreamReader sr = new StreamReader(filePath);

            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (pid == Convert.ToInt32(fields[0]))
                    {
                        //found it
                        a.ProductID = Convert.ToInt32(fields[0]);
                        a.QOH = Convert.ToInt32(fields[1]);

                        sr.Close();
                        return a;
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Qoh not Found!", "Error");
            }

            sr.Close();
            return null;
        }
        public static void SaveInventory(Inventory i)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(i.ProductID + "," + i.QOH);
            //MessageBox.Show("Record info has been saved successfully.", "confirmation");
            sw.Close();
        }
        public static void UpdateRecord(Inventory i)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath); // for reading
                StreamWriter sw = new StreamWriter(filePath2, true);// for writing
                //read the first line
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    int fid0 = Convert.ToInt32(fields[0]);
                    if (fid0 != i.ProductID)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(i.ProductID+ "," + i.QOH);
                sr.Close();
                sw.Close();
            }
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }
        public static void DeleteRecord(int id)
        {

            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                StreamWriter sw = new StreamWriter(filePath2, true);

                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) != id)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] );
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
                sw.Close();
            }
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }
    }
}
