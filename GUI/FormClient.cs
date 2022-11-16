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
using System.Xml;
using HiTechOrderSystem.DataAccess;

namespace HiTechOrderSystem.GUI
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }
        public void Clearall()
        {
            textBoxClientCity.Clear();
            textBoxClientID.Clear();
            textBoxClientName.Clear();
            textBoxClientCreditLimit.Clear();
            textBoxClientStreet.Clear();
            maskedTextBoxClientPostCode.Clear();
            maskedTextBoxClientPhoneNumber.Clear();
            textBoxClientFaxNumber.Clear();
            comboBoxClienttype.SelectedItem = false;
        }
        private void buttonClientSave_Click(object sender, EventArgs e)
        {
            Client c1 = new Client();
            try
            {

                if (c1.checkclientid(Convert.ToInt32(textBoxClientID.Text.Trim())) == true)
                {
                    c1.ClientID = Convert.ToInt32(textBoxClientID.Text.Trim());
                    c1.ClientName = textBoxClientName.Text.Trim();
                    c1.Street = textBoxClientStreet.Text.Trim();
                    c1.City = textBoxClientCity.Text.Trim();
                    c1.PostCode = maskedTextBoxClientPostCode.Text.Trim();
                    c1.PhoneNumber = maskedTextBoxClientPhoneNumber.Text.Trim();
                    c1.FaxNumber = textBoxClientFaxNumber.Text.Trim();
                    c1.CreditLimit = textBoxClientCreditLimit.Text.Trim();
                    c1.Type = comboBoxClienttype.Text;
                    c1.SaveClient(c1);
                    
                    Clearall();
                }
                else
                {
                    textBoxClientID.Clear();
                    MessageBox.Show("ID already exist", "Warning");
                }
            }
            catch
            {
                MessageBox.Show("Please enter correct information", "Error");
                Clearall();
                textBoxClientID.Focus();
            }
        }

        private void buttonClientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Client c1 = new Client();
                int sid = Convert.ToInt32(textBoxClientSearch.Text.Trim());
                c1 = c1.SearchClient(sid);
                if (c1 != null)
                {
                    textBoxClientID.Text = c1.ClientID.ToString();
                    textBoxClientName.Text = c1.ClientName;
                    textBoxClientStreet.Text = c1.Street;
                    textBoxClientCity.Text = c1.City;
                    maskedTextBoxClientPostCode.Text = c1.PostCode;
                    maskedTextBoxClientPhoneNumber.Text = c1.PhoneNumber;
                    textBoxClientFaxNumber.Text = c1.FaxNumber;
                    textBoxClientCreditLimit.Text = c1.CreditLimit;
                    comboBoxClienttype.Text = c1.Type;
                    textBoxClientID.Enabled = false;
                    buttonClientDelete.Enabled = true;
                    buttonClientUpdate.Enabled = true;
                    buttonClientSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid Client ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxClientSearch.Clear();
                    textBoxClientSearch.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Please enter Client ID, then try again", "Error");
            }
        }

        private void buttonClientUpdate_Click(object sender, EventArgs e)
        {
            
            Client client = new Client();
            client.ClientID = Convert.ToInt32(textBoxClientID.Text);
            client.ClientName = textBoxClientName.Text.Trim();
            client.Street = textBoxClientStreet.Text.Trim();
            client.City = textBoxClientCity.Text.Trim();
            client.PostCode = maskedTextBoxClientPostCode.Text.Trim();
            client.PhoneNumber = maskedTextBoxClientPhoneNumber.Text.Trim();
            client.FaxNumber = textBoxClientFaxNumber.Text.Trim();
            client.CreditLimit = textBoxClientCreditLimit.Text.Trim();
            client.Type = comboBoxClienttype.Text;



            DialogResult ans = MessageBox.Show("Are you sure you want to update this client?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                client.UpdateClient(client);
                
                MessageBox.Show("Employee record has been updated successfully.", "Confirmation");
                buttonClientDelete.Enabled = false;
                buttonClientUpdate.Enabled = false;
                buttonClientSave.Enabled = true;
                textBoxClientID.Enabled = true;

                Clearall();
            }
        }

        private void buttonClientDelete_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this client?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
               client.DeleteClient(Convert.ToInt32(textBoxClientID.Text));
                MessageBox.Show("Client record has been deleted successfully.", "Confirmation");
                buttonClientDelete.Enabled = false;
                buttonClientUpdate.Enabled = false;
                buttonClientSave.Enabled = true;
                textBoxClientID.Enabled = true;
                Clearall();
            }

        }

        private void buttonClientListAll_Click(object sender, EventArgs e)
        {
            
            Client client = new Client();
            List<Client> listC = client.GetClients();
            client.Displaylist(listViewClient, listC);
            
        }

        private void buttonWritetoXML_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.WriteToXML();

        }
    }
}
