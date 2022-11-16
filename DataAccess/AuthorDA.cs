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
    public static class AuthorDA
    {
        static string filePath = Application.StartupPath + @"\Authors.dat";
        static string filePath2 = Application.StartupPath + @"\AuthorTemp.dat";
        public static void SaveAuthor(Author author)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(author.AuthorID+","+author.FirstName+","+author.LastName);
            MessageBox.Show("Author info has been saved successfully.", "confirmation");
            sw.Close();
        }
         public static Author SearchID(int aid)
         { 
            Author a = new Author(); 
            
            StreamReader sr = new StreamReader(filePath);

            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (aid == Convert.ToInt32(fields[0])) 
                    {
                        //found it
                        a.AuthorID = Convert.ToInt32(fields[0]);
                        a.FirstName = fields[1];
                        a.LastName = fields[2];
                        
                        sr.Close();
                        return a;
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Author not Found!", "Error");
            }
            
            sr.Close();
            return null;
         }
        public static List<Author> SearchName(string aName)
        {
            List<Author> lista = new List<Author>();
            StreamReader sr = new StreamReader(filePath);
            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[1].ToUpper() == aName.ToUpper() || fields[2].ToUpper() == aName.ToUpper())
                    {
                       
                        Author a = new Author();
                        a.AuthorID = Convert.ToInt32(fields[0]);
                        a.FirstName = fields[1];
                        a.LastName = fields[2];
                        lista.Add(a);
                        
                    }
                    //read the next line
                    line = sr.ReadLine();
                   
                }
                sr.Close();
                if (lista.Count==0)
                {
                    MessageBox.Show("Author not found!", "Error");
                }
                
                
            }
            else
            {
                MessageBox.Show("File not Found!", "Error");
            }

            return lista;
        }
        public static List<Author> GetAllRecords()
        {
            List<Author> listAll = new List<Author>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] fields = line.Split(',');
                        Author a = new Author();
                        a.AuthorID = Convert.ToInt32(fields[0]);
                        a.FirstName = fields[1];
                        a.LastName = fields[2];
                        
                        listAll.Add(a);

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
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] );
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
