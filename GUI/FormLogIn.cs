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
using HiTechOrderSystem.Validation;

namespace HiTechOrderSystem.GUI
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you want to exit the application?", "Confirmation",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string tid = textBoxID.Text.Trim();
            string tpwd = textBoxPassword.Text.Trim();
            Boolean va = Validator.IsValidId(tid,4);
            if (va==false)
            {
                MessageBox.Show("Please Enter Correct ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Clear();
                textBoxID.Focus();

                return;
            }
            if (string.IsNullOrEmpty(tpwd))
            {
                MessageBox.Show("Please Enter Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }
            User user1 = new User();
            int tid1 = Convert.ToInt32(tid);
            string jt1 = user1.LogIn(tid1, tpwd);
            int flag = 6;
            if (!string.IsNullOrEmpty(jt1))
            {
                if(jt1=="MIS_Manager")
                {
                    flag = 1;
                }
                if(jt1=="Sales_Manager")
                {
                    flag = 2;
                }
                if(jt1=="Inventory_Controller")
                {
                    flag = 3;
                }
                if(jt1=="Order_Clerks")
                {
                    flag = 4;
                }
                switch(flag)
                {
                    case 1: 
                        //MIS Manager
                    this.Hide();
                    FormEmployeeUser frmEmpUser = new FormEmployeeUser(tid1);
                    frmEmpUser.ShowDialog();
                        break;
                     
                    case 2:
                        //Sales Manager
                        this.Hide();
                        FormClient fct = new FormClient();
                        fct.ShowDialog();
                        break;
                    case 3:
                        //Inventory Controller
                        this.Hide();
                        FormProduct fpt = new FormProduct();
                        fpt.ShowDialog();
                        break;
                    case 4:
                        //Order Clerks
                        this.Hide();
                        FormOrders fod = new FormOrders();
                        fod.ShowDialog();
                        break;
                    case 6:
                        // Others
                        MessageBox.Show("You do not have permission", "Warning");
                        break;
                    default:
                        MessageBox.Show("The password is wrong", "Error");
                        break;
                }
                return;
            }
            else
            {
                //invalid login
                //MessageBox.Show("User does not exist. Please try again!", "Error");


            }
            textBoxID.Clear();
            textBoxID.Focus();
            textBoxPassword.Clear();
        }



        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }
    }
}
