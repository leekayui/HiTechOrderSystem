using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.DataAccess;
using System.Windows.Forms;

namespace HiTechOrderSystem.Business
{
    [Serializable]
    public class Order
    {
        public int OrderNumber { get; set; }
        public int ClientID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string OrderBy { get; set; }
        public string Payment { get; set; }
        public DateTime RequireDate { get; set; }
        public DateTime ShippingDate { get; set; }
        //public Dictionary<int, int> orderline { get; set;}
        public void SaveOrder(Order o)
        { 
                OrderDA.SaveRecord(o);
           
        }
        public Order SearchOrder(int id)
        {
            return OrderDA.SearchRecord(id);
        }
        public void DeleteRecord(int id)
        {
            OrderDA.DeleteRecord(id);
        }

        public void UpdateRecord(Order id)
        {
            OrderDA.UpdateRecord(id);
        }
        public List<Order> GetAllRecords()
        {
            return OrderDA.GetAllRecords();
        }
        public void Displaylist(ListView listViewo, List<Order> listo)
        {
            listViewo.Items.Clear();

            foreach (Order o1 in listo)
            {
                

                ListViewItem item = new ListViewItem(o1.OrderNumber.ToString());
                item.SubItems.Add(o1.ClientID.ToString());
                item.SubItems.Add(o1.ProductID.ToString());
                item.SubItems.Add(o1.Quantity.ToString());
                item.SubItems.Add(o1.OrderBy);
                item.SubItems.Add(o1.Payment);
                item.SubItems.Add(o1.RequireDate.ToString("MM/dd/yyyy"));
                item.SubItems.Add(o1.ShippingDate.ToString("MM/dd/yyyy"));
                
                listViewo.Items.Add(item);

            }
        }

    }
}
