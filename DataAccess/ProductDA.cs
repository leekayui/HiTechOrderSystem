using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using HiTechOrderSystem.Business;

namespace HiTechOrderSystem.DataAccess
{
    public static class ProductDA
    {
        static string filePath = Application.StartupPath + @"\Products.dat";
        static string filePath2 = Application.StartupPath + @"\ProductTemp.dat";
        public static void SaveProduct(Product p)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(p.ProductID+ "," + p.Type + "," + p.AuthorID + ","+p.Supplier + ","+p.ISBN + "," +p.Title + "," +p.UnitPrice + "," +p.Year );
            MessageBox.Show("Product info has been saved successfully.", "confirmation");
            sw.Close();
        }
        public static Product SearchID(int pid)
        {
            Product p = new Product();

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
                        p.ProductID = Convert.ToInt32(fields[0]);
                        p.Type = fields[1];
                        p.AuthorID =Convert.ToInt32( fields[2]);
                        p.Supplier = fields[3];
                        p.ISBN = fields[4];
                        p.Title = fields[5];
                        p.UnitPrice = Convert.ToDouble(fields[6]);
                        p.Year = Convert.ToInt32(fields[7]);
                        sr.Close();
                        
                        return p;
                        
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Product not Found!", "Error");
            }
            
            sr.Close();
            return null;
        }
        public static List<Product> GetAllRecords()
        {
            List<Product> listAll = new List<Product>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] fields = line.Split(',');
                        Product p = new Product();
                        p.ProductID = Convert.ToInt32(fields[0]);
                        p.Type = fields[1];
                        p.AuthorID = Convert.ToInt32(fields[2]);
                        p.Supplier = fields[3];
                        p.ISBN = fields[4];
                        p.Title = fields[5];
                        p.UnitPrice = Convert.ToDouble(fields[6]);
                        p.Year = Convert.ToInt32(fields[7]);
                        listAll.Add(p);

                        //read the next line
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }

            }
            else
            {
                listAll = null;
                MessageBox.Show("No record has been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listAll;
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
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7]);
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
                sw.Close();
            }
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }

        public static void UpdateRecord(Product p)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath); // for reading
                StreamWriter sw = new StreamWriter(filePath2, true);
                //read the first line
                string line = sr.ReadLine();

                while (line != null)
                {
                    string[] fields = line.Split(',');
                    int fid0 = Convert.ToInt32(fields[0]);
                    if (fid0 != p.ProductID)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(p.ProductID + "," + p.Type + "," + p.AuthorID + "," + p.Supplier + "," + p.ISBN + "," + p.Title + "," + p.UnitPrice + "," + p.Year);
                sr.Close();
                sw.Close();
            }
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }

    }
}
