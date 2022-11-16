using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.DataAccess;
using System.Windows.Forms;

namespace HiTechOrderSystem.Business
{
    public class Client
    {
        private string institutionType;
        private int clientID;
        private string clientName;
        private string phoneNumber;
        private string faxNumber;
        private string creditLimit;
        private string street;
        private string city;
        private string postCode;
        private string type;

        public string InstitutionType { get => institutionType; set => institutionType = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string CreditLimit { get => creditLimit; set => creditLimit = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public string Type { get => type; set => type = value; }

        public void SaveClient(Client client)
        {
            ClientDA.SaveClient(client);
        }
        public bool checkclientid(int id)
        {
            return ClientDA.checkunique(id);
        }
        public Client SearchClient(int sid)
        {
            return ClientDA.SearchID(sid);
        }
        public void UpdateClient(Client client)
        {
            ClientDA.UpdateRecord(client);
        }
        public void DeleteClient(int id)
        {
            ClientDA.DeleteRecord(id);
        }
        public List<Client> GetClients()
        {
            return ClientDA.GetAllRecords();
        }
        public void Displaylist(ListView listViewC, List<Client> listC)
        {
            listViewC.Items.Clear();
            foreach (Client clientitem in listC)
            {
                ListViewItem item = new ListViewItem(clientitem.clientID.ToString());
                item.SubItems.Add(clientitem.clientName);
                item.SubItems.Add(clientitem.street);
                item.SubItems.Add(clientitem.city);
                item.SubItems.Add(clientitem.postCode);
                item.SubItems.Add(clientitem.phoneNumber);
                item.SubItems.Add(clientitem.faxNumber);
                item.SubItems.Add(clientitem.creditLimit);
                item.SubItems.Add(clientitem.type);
                listViewC.Items.Add(item);
                
            }
        }
        public void WriteToXML()
        {
            ClientDA.Writetoxml();
        }
    }
}
