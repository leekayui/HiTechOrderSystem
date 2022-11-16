using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.DataAccess;
using System.Windows.Forms;

namespace HiTechOrderSystem.Business
{
    public class Product
    {
        public string Type { get; set; }
        public int ProductID { get; set; }
        public int AuthorID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public double UnitPrice { get; set; }
        public int Year { get; set; }
        public string Supplier { get; set; }

        public void saveProduct(Product p)
        {
            ProductDA.SaveProduct(p);
        }
        public Product SearchID(int pid)
        {
            
            return ProductDA.SearchID(pid);
        }
        public void DeleteRecord(int id) 
        {
            ProductDA.DeleteRecord(id);
        }

        public void UpdateRecord(Product id) 
        {
            ProductDA.UpdateRecord(id);
        }
        public List<Product> GetAllRecords() 
        {
           return ProductDA.GetAllRecords();
        }
        public void Displaylist(ListView listViewa, List<Product> listp)
        {
            listViewa.Items.Clear();

            foreach (Product a1 in listp)
            {
                        Inventory i = InventoryDA.SearchID(a1.ProductID);
                        
                        ListViewItem item = new ListViewItem(a1.ProductID.ToString());
                        item.SubItems.Add(a1.Type);
                        item.SubItems.Add(a1.AuthorID.ToString());
                        item.SubItems.Add(a1.Supplier);
                        item.SubItems.Add(a1.ISBN);
                        item.SubItems.Add(a1.Title);
                        item.SubItems.Add(a1.UnitPrice.ToString());
                        item.SubItems.Add(a1.Year.ToString());
                        item.SubItems.Add(i.QOH.ToString());
                        listViewa.Items.Add(item);
                
            }
        }


    }
}
