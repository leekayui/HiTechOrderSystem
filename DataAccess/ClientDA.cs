using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.Business;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace HiTechOrderSystem.DataAccess
{
    public static class ClientDA
    {
        static string filePath = Application.StartupPath + @"\Clients.dat";
        static string filePath2 = Application.StartupPath + @"\ClientTemp.dat";

        public static void SaveClient (Client c1)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(c1.ClientID + "," + c1.ClientName + "," + c1.Street + "," + c1.City + "," + c1.PostCode + "," + c1.PhoneNumber+","+c1.FaxNumber+","+c1.CreditLimit+","+c1.Type);
            MessageBox.Show("Client info has been saved successfully.", "confirmation");
            sw.Close();
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
        public static Client SearchID(int sid)
        {
            Client c1 = new Client();
            StreamReader sr = new StreamReader(filePath);

            if (File.Exists(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (sid == Convert.ToInt32(fields[0]))
                    {
                        //found it
                        c1.ClientID = Convert.ToInt32(fields[0]);
                        c1.ClientName = fields[1];
                        c1.Street = fields[2];
                        c1.City = fields[3];
                        c1.PostCode = fields[4];
                        c1.PhoneNumber = fields[5];
                        c1.FaxNumber = fields[6];
                        c1.CreditLimit = fields[7];
                        c1.Type = fields[8];
                        
                        sr.Close();
                        return c1;
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Client not Found!", "Error");
            }
           
            sr.Close();
            return null;
        }
        public static void UpdateRecord(Client client)
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
                    if (fid0 != client.ClientID)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5]+","+fields[6]+","+fields[7]+","+fields[8]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(client.ClientID + "," + client.ClientName + "," + client.Street+ "," + client.City + "," + client.PostCode + "," + client.PhoneNumber+","+client.FaxNumber+","+client.CreditLimit+","+client.Type);
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
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8]);
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
                sw.Close();
            }
            File.Delete(filePath);
            File.Move(filePath2, filePath);
        }
        public static List<Client> GetAllRecords()
        {
            List<Client> listAll = new List<Client>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] fields = line.Split(',');
                        Client c1=new Client();
                        c1.ClientID = Convert.ToInt32(fields[0]);
                        c1.ClientName = fields[1];
                        c1.Street = fields[2];
                        c1.City = fields[3];
                        c1.PostCode = fields[4];
                        c1.PhoneNumber = fields[5];
                        c1.FaxNumber = fields[6];
                        c1.CreditLimit = fields[7];
                        c1.Type = fields[8];
                        listAll.Add(c1);

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
        public static void Writetoxml()
        {
            List<Client> clst = new List<Client>();
             clst = GetAllRecords();
            string dir = @"";
            string filePath = dir + "XMLClients.xml";

            XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
            xmlWriterSetting.Indent = true;
            xmlWriterSetting.IndentChars = ("  ");

            XmlWriter xmlWriter = XmlWriter.Create(filePath, xmlWriterSetting);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Clients");
            foreach (Client cl in clst )
            {
                xmlWriter.WriteStartElement("Client");
                xmlWriter.WriteAttributeString("ClientID", cl.ClientID.ToString());
                xmlWriter.WriteElementString("ClientName", cl.ClientName);
                xmlWriter.WriteElementString("Street", cl.Street);
                xmlWriter.WriteElementString("City", cl.City);
                xmlWriter.WriteElementString("Postcode", cl.PostCode);
                xmlWriter.WriteElementString("PhoneNumber", cl.PhoneNumber);
                xmlWriter.WriteElementString("FaxNumber", cl.FaxNumber);
                xmlWriter.WriteElementString("CreditLimit", cl.CreditLimit);
                xmlWriter.WriteElementString("Type", cl.Type);

                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            MessageBox.Show("The xml file has been created successfully.", "File Created");

            xmlWriter.Close();
        }
    }
}
