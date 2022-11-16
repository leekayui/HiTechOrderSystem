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

namespace HiTechOrderSystem.GUI
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 0x20) e.KeyChar = (char)0; 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   
                }
            }
        }
        private void ClearAll()
        {
            textBoxOrderClientID.Clear();
            textBoxOrderNumber.Clear();
            textBoxOrderProductID.Clear();
            textBoxOrderQuantity.Clear();
            maskedTextBoxRequireDate.Clear();
            maskedTextBoxShippingDate.Clear();
            comboBoxOrderBy.SelectedIndex = 0;
            textBoxSearch.Clear();
        } 
        private void buttonOrderSave_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                order.OrderNumber = Convert.ToInt32(textBoxOrderNumber.Text.Trim());
                order.ProductID = Convert.ToInt32(textBoxOrderProductID.Text.Trim());
                order.ClientID = Convert.ToInt32(textBoxOrderClientID.Text.Trim());
                order.Quantity = Convert.ToInt32(textBoxOrderQuantity.Text.Trim());
                order.OrderBy = comboBoxOrderBy.Text;
                order.Payment = labelPayment.Text;
                order.RequireDate = Convert.ToDateTime(maskedTextBoxRequireDate.Text);
                order.ShippingDate = order.RequireDate.AddDays(-1);
                if (order.SearchOrder(order.OrderNumber) == null)
                {
                    order.SaveOrder(order);

                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Order Number Is Already Exist", "Error");
                    ClearAll();
                }
            }
            catch
            {

            }

        }

        private void maskedTextBoxRequireDate_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void buttonOrderList_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            List<Order> listo = o.GetAllRecords();
            o.Displaylist(listViewOrder, listo);
            

        }

        private void buttonOrderSearch_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textBoxSearch.Text.Trim());
            Order o = new Order();
            o = o.SearchOrder(searchId);
            

            if (o != null)
            {
                textBoxOrderNumber.Text = o.OrderNumber.ToString();
                textBoxOrderProductID.Text = o.ProductID.ToString();
                textBoxOrderClientID.Text = o.ClientID.ToString();
                textBoxOrderQuantity.Text = o.Quantity.ToString();
                maskedTextBoxRequireDate.Text = o.RequireDate.ToString("MM/dd/yyyy");
                maskedTextBoxShippingDate.Text = o.ShippingDate.ToString("MM/dd/yyyy");
                comboBoxOrderBy.Text = o.OrderBy;
                buttonOrderUpdate.Enabled = true;
                buttonOrderDelete.Enabled = true;
                textBoxOrderNumber.Enabled = false;
            }
            else
            {
                MessageBox.Show("Order not found!", "Invalid Order Id");
            }
        }

        private void buttonOrderUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                order.OrderNumber = Convert.ToInt32(textBoxOrderNumber.Text.Trim());
                order.ProductID = Convert.ToInt32(textBoxOrderProductID.Text.Trim());
                order.ClientID = Convert.ToInt32(textBoxOrderClientID.Text.Trim());
                order.Quantity = Convert.ToInt32(textBoxOrderQuantity.Text.Trim());
                order.OrderBy = comboBoxOrderBy.Text;
                order.Payment = labelPayment.Text;
                order.RequireDate = Convert.ToDateTime(maskedTextBoxRequireDate.Text);
                order.ShippingDate = order.RequireDate.AddDays(-1);


                DialogResult ans = MessageBox.Show("Are you sure you want to update this order?", "Confirm",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    order.UpdateRecord(order);


                    MessageBox.Show("Order record has been updated successfully.", "Confirmation");
                    buttonOrderDelete.Enabled = false;
                    buttonOrderUpdate.Enabled = false;
                    buttonOrderSave.Enabled = true;
                    textBoxOrderNumber.Enabled = true;


                    ClearAll();
                }
            }
            catch
            {
                MessageBox.Show("Try Again");
            }
        }

        private void buttonOrderDelete_Click(object sender, EventArgs e)
        {

            Order order = new Order();
            order.OrderNumber = Convert.ToInt32(textBoxOrderNumber.Text.Trim());
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this order?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                order.DeleteRecord(order.OrderNumber);


                MessageBox.Show("Order record has been removed successfully.", "Confirmation");
                buttonOrderDelete.Enabled = false;
                buttonOrderUpdate.Enabled = false;
                buttonOrderSave.Enabled = true;
                textBoxOrderNumber.Enabled = true;


                ClearAll();
            }
        }
    }
}
