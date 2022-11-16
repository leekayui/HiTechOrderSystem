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
    public static class  UserDA
    {
        static string filePathUser = Application.StartupPath + @"\Users.dat";
        static string filePathUser2 = Application.StartupPath + @"\UserTemp.dat";
        static string filePath = Application.StartupPath + @"\Employees.dat";

        public static string VerifyLogIn(int id,string pwd)
        {
            User us = new User();
            string jt = null;
            StreamReader sr = new StreamReader(filePathUser);
            if (File.Exists(filePathUser))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');


                    if (id == Convert.ToInt32(fields[0]))
                    {
                        //found it
                        if(pwd==fields[1])
                        {
                                jt = fields[3];
                            sr.Close();
                            return jt;
                        }
                        MessageBox.Show("Password is invalid", "Error");
                        sr.Close();
                        return jt;
                    }
                    line = sr.ReadLine();
           
                }

                MessageBox.Show("User does not exist", "Error");
                sr.Close();
            }
            else
            {
                MessageBox.Show("Something wrong", "Error");
               
            }
            sr.Close();
            return jt;
        }
        public static void AddUser(User user)
        {
            StreamWriter sw = new StreamWriter(filePathUser, true);
            sw.WriteLine(user.EmployeeId+","+user.UserId+","+user.PassWord+","+user.JobTitle);
            MessageBox.Show("User info has been saved successfully.", "confirmation");
            sw.Close();

        }

        public static bool checkexist(int id)
        {
            bool c = false;
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        sr.Close();
                        c = true;
                        return c;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                return c;
            }
           
            return c;


        }
        public static string findjobtitle(int id)
        {
            string fjt = null;
            if (File.Exists(filePath))
            {
                
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        fjt = fields[5];
                        sr.Close();
                        return fjt;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
               
                return fjt;
            }
            return null;
        }
        public static User SearchEID(int eid)
        {
            User user = new User();
            StreamReader sr = new StreamReader(filePathUser);

            if (File.Exists(filePathUser))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (eid == Convert.ToInt32(fields[0]))
                    {
                        //found it

                        user.EmployeeId = Convert.ToInt32(fields[0]);
                        user.UserId = Convert.ToInt32(fields[1]);
                        user.PassWord = fields[2];
                        user.JobTitle = fields[3];
                        
                        sr.Close();
                        return user;
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("User not Found!", "Error");
            }
            user = null;
            sr.Close();
            return null;
        }
        public static User SearchUID(int uid)
        {
            User user = new User();
            StreamReader sr = new StreamReader(filePathUser);

            if (File.Exists(filePathUser))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (uid == Convert.ToInt32(fields[1]))
                    {
                        //found it

                        user.EmployeeId = Convert.ToInt32(fields[0]);
                        user.UserId = Convert.ToInt32(fields[1]);
                        user.PassWord = fields[2];
                        user.JobTitle = fields[3];

                        sr.Close();
                        return user;
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("User not Found!", "Error");
            }
            user = null;
            sr.Close();
            return null;
        }
        public static List<User> GetAllRecords()
        {
            List<User> listAll = new List<User>();

            if (File.Exists(filePathUser))
            {
                using (StreamReader sr = new StreamReader(filePathUser))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] fields = line.Split(',');
                        User user = new User();
                        user.EmployeeId= Convert.ToInt32(fields[0]);
                        user.UserId= Convert.ToInt32(fields[1]);
                        user.PassWord= fields[2];
                        user.JobTitle= fields[3];
                        
                        listAll.Add(user);

                        //read the next line
                        line = sr.ReadLine();
                    }
                }

            }
            else
            {
                listAll = null;
                MessageBox.Show("No record has been found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listAll;
        }
        public static void UpdateRecord(User user)
        {
            if (File.Exists(filePathUser))
            {
                StreamReader sr = new StreamReader(filePathUser); // for reading
                StreamWriter sw = new StreamWriter(filePathUser2, true);// for writing
                //read the first line
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    int fid0 = Convert.ToInt32(fields[0]);
                    if (fid0 != user.EmployeeId)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] );
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(user.EmployeeId + "," + user.UserId + "," + user.PassWord + "," + user.JobTitle );
                sr.Close();
                sw.Close();
            }
            File.Delete(filePathUser);
            File.Move(filePathUser2, filePathUser);
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
                    if (Convert.ToInt32(fields[0]) == id)
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

            if (File.Exists(filePathUser))
            {
                StreamReader sr = new StreamReader(filePathUser);
                StreamWriter sw = new StreamWriter(filePathUser2, true);

                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) != id)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] );
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
                sw.Close();
            }
            File.Delete(filePathUser);
            File.Move(filePathUser2, filePathUser);
        }

    }
}
