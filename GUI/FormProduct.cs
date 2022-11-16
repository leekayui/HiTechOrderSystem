using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechOrderSystem.Business;
using HiTechOrderSystem.DataAccess;

namespace HiTechOrderSystem.GUI
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();


        }
        private void ClearAll()
        {
            textBoxAuthorID.Clear();
            textBoxAuthorFirstName.Clear();
            textBoxAuthorLastName.Clear();
            textBoxAuthorInput.Clear();
            
        }
        private void buttonAuthorSave_Click(object sender, EventArgs e)
        {
            Author author = new Author();
           
            try
            {
                author.AuthorID = Convert.ToInt32(textBoxAuthorID.Text.Trim());
                author.FirstName = textBoxAuthorFirstName.Text.Trim();
                author.LastName = textBoxAuthorLastName.Text.Trim();
                author.SaveAuthor(author);
                ClearAll();
            }
            catch
            {
                MessageBox.Show("Please enter correct information", "Error");
                ClearAll();
                textBoxAuthorID.Focus();
            }
        }

        private void buttonAuthorSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Author a = new Author();
                int sIndex = comboBoxAuthorSearch.SelectedIndex;

                switch (sIndex)
                {
                    case 0:
                        //ID
                        int searchId = Convert.ToInt32(textBoxAuthorInput.Text.Trim());
                        a = a.SearchID(searchId);
                        if (a != null)
                        {
                            textBoxAuthorID.Text = a.AuthorID.ToString();
                            textBoxAuthorFirstName.Text = a.FirstName;
                            textBoxAuthorLastName.Text = a.LastName;
                            buttonAuthorDelete.Enabled = true;
                            buttonAuthorSave.Enabled = false;
                            textBoxAuthorID.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Author ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxAuthorInput.Clear();
                            textBoxAuthorInput.Focus();
                        }

                        break;
                    case 1:

                        string searchName = textBoxAuthorInput.Text.Trim();
                        Author a1 = new Author();
                        List<Author> lista = a1.SearchName(textBoxAuthorInput.Text.Trim());

                        if (lista != null)
                        {
                            listViewAuthor.Items.Clear();
                            foreach (Author a2 in lista)
                            {
                                ListViewItem item = new ListViewItem(a2.AuthorID.ToString());
                                item.SubItems.Add(a2.FirstName);
                                item.SubItems.Add(a2.LastName);

                                listViewAuthor.Items.Add(item);

                            }
                        }


                        break;


                    default:
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Please try again", "Error");
            }
    }

        private void buttonListAuthor_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            List<Author> lista = a.GetAuthors();
            a.Displaylist(listViewAuthor,lista);
            
        }

        private void buttonAuthorDelete_Click(object sender, EventArgs e)
        {
            
            Author a = new Author();
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this Author?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                a.DeleteAuthor(Convert.ToInt32(textBoxAuthorID.Text));
                
                MessageBox.Show("Author record has been deleted successfully.", "Confirmation");
                buttonAuthorDelete.Enabled = false;
                buttonAuthorSave.Enabled = true;
                textBoxAuthorID.Enabled = true;
                ClearAll();
            }
        }

        private void buttonProductListAll_Click(object sender, EventArgs e)
        {
            
            Product p = new Product();
            List<Product> listp = p.GetAllRecords();
            p.Displaylist(listViewProduct, listp);
            textBoxAuthorID.Enabled = true;

        }
        private void ClearP()
        {
            textBoxProductID.Clear();
            comboBoxProductType.SelectedIndex = 0;
            textBoxProductAuthorID.Clear();
            comboBoxProductSupplier.SelectedIndex = 0;
            textBoxISBN.Clear();
            textBoxProductTitle.Clear();
            textBoxProductPrice.Clear();
            textBoxProductYear.Clear();
            textBoxQON.Clear();
            textBoxProductInput.Clear();
        }

        private void buttonProductSave_Click(object sender, EventArgs e)
        {
            
            Product p = new Product();
            Inventory i = new Inventory();

            try
            {
                p.ProductID = Convert.ToInt32(textBoxProductID.Text.Trim());
                p.Type = comboBoxProductType.SelectedItem.ToString();
                p.AuthorID = Convert.ToInt32(textBoxProductAuthorID.Text.Trim());
                p.Supplier = comboBoxProductSupplier.SelectedItem.ToString();
                p.ISBN = textBoxISBN.Text.Trim();
                p.Title = textBoxProductTitle.Text.Trim();
                p.UnitPrice = Convert.ToDouble(textBoxProductPrice.Text.Trim());
                p.Year = Convert.ToInt32(textBoxProductYear.Text.Trim());
                i.ProductID = Convert.ToInt32(textBoxProductID.Text.Trim());
                i.QOH = Convert.ToInt32(textBoxQON.Text.Trim());
                p.saveProduct(p);
                i.SaveInventory(i);

                ClearP();
            }
            catch
            {
                MessageBox.Show("Please enter correct information", "Error");
                ClearP();
                textBoxProductID.Focus();
            }
        }

        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
           

            Product p = new Product();
            Inventory i = new Inventory();
            p.ProductID = Convert.ToInt32(textBoxProductID.Text.Trim());
            p.Type = comboBoxProductType.SelectedItem.ToString();
            p.AuthorID = Convert.ToInt32(textBoxProductAuthorID.Text.Trim());
            p.Supplier = comboBoxProductSupplier.SelectedItem.ToString();
            p.ISBN = textBoxISBN.Text.Trim();
            p.Title = textBoxProductTitle.Text.Trim();
            p.UnitPrice = Convert.ToDouble(textBoxProductPrice.Text.Trim());
            p.Year = Convert.ToInt32(textBoxProductYear.Text.Trim());
            i.ProductID = Convert.ToInt32(textBoxProductID.Text.Trim());
            i.QOH = Convert.ToInt32(textBoxQON.Text.Trim());

            DialogResult ans = MessageBox.Show("Are you sure you want to update this product?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                p.UpdateRecord(p);
                i.UpdateRecord(i);
                
                MessageBox.Show("Product record has been updated successfully.", "Confirmation");
                buttonProductDelete.Enabled = false;
                buttonProductUpdate.Enabled = false;
                textBoxAuthorID.Enabled = true;
                ClearP();
            }
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Product p1 = new Product();
                Inventory i = new Inventory();
                int id = Convert.ToInt32(textBoxProductInput.Text.Trim());
                p1=p1.SearchID(id);
                i=i.SearchID(id);
            

                if (p1 != null && i !=null)
                {
                    textBoxProductID.Text = p1.ProductID.ToString();
                    
                    comboBoxProductType.Text =p1.Type ;
                    textBoxProductAuthorID.Text=p1.AuthorID.ToString();
                    comboBoxProductSupplier.Text=p1.Supplier;
                    textBoxISBN.Text=p1.ISBN;
                    textBoxProductTitle.Text=p1.Title;
                    textBoxProductPrice.Text=p1.UnitPrice.ToString();
                    textBoxProductYear.Text=p1.Year.ToString();
                    textBoxQON.Text=i.QOH.ToString();

                
                    textBoxProductID.Enabled = false;
                    buttonProductDelete.Enabled = true;
                    buttonProductUpdate.Enabled = true;
                    buttonAuthorSave.Enabled = false;
                    textBoxProductInput.Clear();
                   
                }
                else
                {
                    MessageBox.Show("Invalid Product ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxProductInput.Clear();
                    textBoxProductInput.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Please enter Product ID, then try again", "Error");
            }
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            Inventory i = new Inventory();
            
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this product?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                p.DeleteRecord(Convert.ToInt32(textBoxProductID.Text));
                i.DeleteRecord(Convert.ToInt32(textBoxProductID.Text));
                MessageBox.Show("Product record has been deleted successfully.", "Confirmation");
                
                buttonProductDelete.Enabled = false;
                buttonProductUpdate.Enabled = false;
                ClearP();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
