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
    public static class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"\Employees.dat";
        static string filePath2 = Application.StartupPath + @"\EmployeeTemp.dat";
        public static Employee SearchID(int eid)
        {
            Employee emp = new Employee();
            StreamReader sr = new StreamReader(filePath);

            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (eid == Convert.ToInt32(fields[0])) 
                    {
                        //found it
                        
                        emp.EmployeeId = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];
                        emp.PhoneNumber = fields[3];
                        emp.Email = fields[4];
                        emp.JobTitle = fields[5];
                        sr.Close();
                        return emp;
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Employee not Found!", "Error");
            }
            emp = null;
            sr.Close();
            return null;
        }
        public static void SaveEmployee(Employee emp)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName + "," + emp.PhoneNumber+","+emp.Email+","+emp.JobTitle);
            MessageBox.Show("Employee info has been saved successfully.", "confirmation");
            sw.Close();
        }
        public static List<Employee> SearchByName(string sName)
        {
            List<Employee> listE = new List<Employee>();
            StreamReader sr = new StreamReader(filePath);
            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[1].ToUpper() == sName.ToUpper() || fields[2].ToUpper() == sName.ToUpper())
                    {
                        //found it
                        Employee emp = new Employee();
                        emp.EmployeeId = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];
                        emp.PhoneNumber = fields[3];
                        emp.Email = fields[4];
                        emp.JobTitle = fields[5];
                        listE.Add(emp);
                       
                    }
                    //read the next line
                    line = sr.ReadLine();
                }
                sr.Close();
                if (listE.Count == 0)
                {
                    MessageBox.Show("Employee not found!", "Error");
                }
                
                
            }
            else
            {
                MessageBox.Show("File not Found!", "Error");
            }

            return listE;
        }

        public static List<Employee> GetAllRecords()
        {
            List<Employee> listAll = new List<Employee>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] fields = line.Split(',');
                        Employee emp = new Employee();
                        emp.EmployeeId = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];
                        emp.PhoneNumber = fields[3];
                        emp.Email = fields[4];
                        emp.JobTitle = fields[5];
                        listAll.Add(emp);

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
        public static void UpdateRecord(Employee emp)
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
                    if (fid0 != emp.EmployeeId)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]+","+fields[4]+","+fields[5]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName + "," + emp.PhoneNumber+","+emp.Email+","+emp.JobTitle);
                sr.Close();
                sw.Close();
            }
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }
        public static bool checkunique(int id)
        {
            bool c = false; 
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if(Convert.ToInt32(fields[0])==id)
                    {
                        sr.Close();
                        return c;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                c = true;
                return c;
            }
            return c;


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
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]+"," + fields[4] + "," + fields[5]);
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
