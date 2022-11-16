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
    public partial class FormEmployeeUser : Form
    {
        Employee em1 = new Employee();
        public FormEmployeeUser(int idcurrent)
        {
            InitializeComponent();
            textBoxCurrentUser.Text = idcurrent.ToString();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageEmployee_Click(object sender, EventArgs e)
        {

        }
  

        private void buttonEmployeeSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
           
            
                try
                {

                if (emp.checkemployeeid(Convert.ToInt32(textBoxEmployeeID.Text.Trim())) == true)
                {
                    emp.EmployeeId = Convert.ToInt32(textBoxEmployeeID.Text.Trim());
                    emp.FirstName = textBoxEmployeeFirstName.Text.Trim();
                    emp.LastName = textBoxEmployeeLastName.Text.Trim();
                    emp.PhoneNumber = maskedTextBoxEmployeePhoneNumber.Text.Trim();
                    emp.JobTitle = comboBoxJobtitle.Text;
                    emp.Email = textBoxEmployeeEmailAddress.Text.Trim();
                    emp.SaveEmployee(emp);


                    DialogResult dialogResult = MessageBox.Show("Do you want to add a user for this employee?", "Add User", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        textBoxUserEmployeeID.Text = emp.EmployeeId.ToString();
                        labeljobtitle.Text = emp.JobTitle;
                        tabControl1.SelectedTab = tabPageUser;
                        ButtonSaveUser.Enabled = true;

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                    ClearAll();
                }
                else
                {
                    textBoxEmployeeID.Clear();
                    MessageBox.Show("ID already exist", "Warning");
                }
                }
                catch
                {
                    MessageBox.Show("Please enter correct information", "Error");
                    ClearAll();
                    textBoxEmployeeID.Focus();
                }
           
        }
  

        private void ClearAll()
        {
            textBoxEmployeeID.Clear();
            textBoxEmployeeFirstName.Clear();
            textBoxEmployeeLastName.Clear();
            maskedTextBoxEmployeePhoneNumber.Clear();
            comboBoxJobtitle.SelectedIndex=0;
            textBoxEmployeeEmailAddress.Clear();
            textBoxEmployeeSearch.Clear();
        }

        private void tabPageUser_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSaveUser_Click(object sender, EventArgs e)
        {
            User auser = new User();
            //try 
            //{
                if(auser.checkemployeeexist(Convert.ToInt32(textBoxUserEmployeeID.Text.Trim())) == true)
                {
                    auser.UserId = Convert.ToInt32(textBoxUserID.Text.Trim());
                    auser.PassWord = textBoxUserPassword.Text.Trim();
                    auser.EmployeeId = Convert.ToInt32(textBoxUserEmployeeID.Text);
                    auser.JobTitle = auser.findejobtitle(Convert.ToInt32(textBoxUserEmployeeID.Text.Trim()));
                    auser.AddUser(auser);
                    ClearUser();
                    
                }
                else
                {
                    MessageBox.Show("Employee does not exist", "Error");
                    ClearUser();
                }
            //}
            //catch
            //{

            //}
            
          
        }
        private void ClearUser()
        {
            textBoxUserEmployeeID.Clear();
            labeljobtitle.Text=" ";
            textBoxUserID.Clear();
            textBoxUserPassword.Clear();
            textBoxUserSearch.Clear();
            comboBoxSearchUser.SelectedIndex = 0;

        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.EmployeeId = Convert.ToInt32(textBoxUserEmployeeID.Text);
            user.UserId = Convert.ToInt32(textBoxUserID.Text.Trim());
            user.PassWord = textBoxUserPassword.Text.Trim();
            user.JobTitle = labeljobtitle.Text;
           

            DialogResult ans = MessageBox.Show("Are you sure you want to update this User?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                user.UpdateUser(user);
                MessageBox.Show("User record has been updated successfully.", "Confirmation");
                buttonUserUpdate.Enabled = false;
                buttonUserDelete.Enabled = false;
                textBoxUserEmployeeID.Enabled = true;
                ClearUser();
            }
        }

        private void FormEmployeeUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonEmployeeUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId= Convert.ToInt32(textBoxEmployeeID.Text);
            emp.FirstName = textBoxEmployeeFirstName.Text;
            emp.LastName = textBoxEmployeeLastName.Text;
            emp.Email = textBoxEmployeeEmailAddress.Text;
            emp.PhoneNumber = maskedTextBoxEmployeePhoneNumber.Text;
            emp.JobTitle = comboBoxJobtitle.SelectedItem.ToString();
           

            DialogResult ans = MessageBox.Show("Are you sure you want to update this employee?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                emp.UpdateEmployee(emp);
                MessageBox.Show("Employee record has been updated successfully.", "Confirmation");
                buttonEmployeeUpdate.Enabled = false;
                buttonEmployeeDelete.Enabled = false;
                textBoxEmployeeID.Enabled = true;
                ClearAll();
            }
        }

        private void buttonEmployeeSearch_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

                int sIndex = comboBoxSearchEmployee.SelectedIndex;

                switch(sIndex)
                {
                    case 0:
                        //ID
                        int searchId = Convert.ToInt32(textBoxEmployeeSearch.Text.Trim());
                        emp = emp.SearchEmployeeID(searchId);
                        if(emp!=null)
                        {
                            textBoxEmployeeID.Text = emp.EmployeeId.ToString();
                            textBoxEmployeeFirstName.Text = emp.FirstName;
                            textBoxEmployeeLastName.Text = emp.LastName;
                            textBoxEmployeeEmailAddress.Text = emp.Email;
                            maskedTextBoxEmployeePhoneNumber.Text = emp.PhoneNumber;
                            comboBoxJobtitle.SelectedItem = emp.JobTitle;
                            buttonEmployeeDelete.Enabled = true;
                            buttonEmployeeUpdate.Enabled = true;
                            textBoxEmployeeID.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Employee ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxEmployeeSearch.Clear();
                            textBoxEmployeeSearch.Focus();
                        }
                        break;
                    case 1:
                        //First Name
                        string searchName = textBoxEmployeeSearch.Text.Trim();
                    Employee empf = new Employee();
                    List<Employee> listEmp = empf.SearchEmployeeName(textBoxEmployeeSearch.Text.Trim());
                    if (listEmp != null)
                    {
                        listViewEmployee.Items.Clear();
                        foreach (Employee empTemp in listEmp)
                        {
                            ListViewItem item = new ListViewItem(empTemp.EmployeeId.ToString());
                            item.SubItems.Add(empTemp.FirstName);
                            item.SubItems.Add(empTemp.LastName);
                            item.SubItems.Add(empTemp.PhoneNumber);
                            item.SubItems.Add(empTemp.Email);
                            item.SubItems.Add(empTemp.JobTitle);
                            listViewEmployee.Items.Add(item);

                        }
                    }
                    

                    break;
                    case 2:
                    //Last Name
                    Employee empl = new Employee();
                    List<Employee> listEmp1 = empl.SearchEmployeeName(textBoxEmployeeSearch.Text.Trim());
                    if (listEmp1 != null)
                    {
                        listViewEmployee.Items.Clear();
                        foreach (Employee empTemp in listEmp1)
                        {
                            ListViewItem item = new ListViewItem(empTemp.EmployeeId.ToString());
                            item.SubItems.Add(empTemp.FirstName);
                            item.SubItems.Add(empTemp.LastName);
                            item.SubItems.Add(empTemp.PhoneNumber);
                            item.SubItems.Add(empTemp.Email);
                            item.SubItems.Add(empTemp.JobTitle);
                            listViewEmployee.Items.Add(item);

                        }
                    }
                    break;

                    default:
                        break;
                }
            }


        //private void buttonUserSearch2_Click(object sender, EventArgs e)
        //{
        //    User suser = new User();
        //    int sn = comboBoxSearchUser.SelectedIndex;
        //    switch (sn)
        //    {
        //        case 0:
        //            //Search by Employee ID
        //            int seId = Convert.ToInt32(textBoxUserSearch.Text.Trim());
        //            suser = suser.SearchEID(seId);
        //            if (suser != null)
        //            {
        //                textBoxUserEmployeeID.Text = suser.EmployeeId.ToString();
        //                textBoxUserID.Text = suser.UserId.ToString();
        //                textBoxUserPassword.Text = suser.PassWord;
        //                labeljobtitle.Text = suser.JobTitle;
        //                buttonUserDelete.Enabled = true;
        //                buttonUserUpdate.Enabled = true;
        //                textBoxUserEmployeeID.Enabled = false;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid Employee ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                textBoxUserSearch.Clear();
        //                textBoxUserSearch.Focus();
        //            }
        //            break;
                    
        //        case 1:
        //            //Search by User ID
        //            int suId= Convert.ToInt32(textBoxUserSearch.Text.Trim());
        //            suser = suser.SearchUID(suId);
        //            if (suser != null)
        //            {
        //                textBoxUserEmployeeID.Text = suser.EmployeeId.ToString();
        //                textBoxUserID.Text = suser.UserId.ToString();
        //                textBoxUserPassword.Text = suser.PassWord;
        //                labeljobtitle.Text = suser.JobTitle;
        //                buttonUserDelete.Enabled = true;
        //                buttonUserUpdate.Enabled = true;
        //                textBoxUserEmployeeID.Enabled = false;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid User ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                textBoxUserSearch.Clear();
        //                textBoxUserSearch.Focus();
        //            }
        //            break;
                    
        //        default:
        //            break;

        //    }
        //}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxEmployeePhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

      

        private void buttonEmployeeListAll_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listE = emp.GetEmployees();
            emp.Displaylist(listViewEmployee, listE);
        }

        private void textBoxEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEmployeeDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                emp.DeleteEmployee(Convert.ToInt32(textBoxEmployeeID.Text));
                MessageBox.Show("Employee record has been deleted successfully.", "Confirmation");
                buttonEmployeeUpdate.Enabled = false;
                buttonEmployeeDelete.Enabled = false;
                textBoxEmployeeID.Enabled = true;
                ClearAll();
            }
        }

        private void textBoxUserEmployeeID_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            User suser = new User();
            int sn = comboBoxSearchUser.SelectedIndex;
            switch (sn)
            {
                case 0:
                    //Search by Employee ID
                    int seId = Convert.ToInt32(textBoxUserSearch.Text.Trim());
                    suser = suser.SearchEID(seId);
                    if (suser != null)
                    {
                        textBoxUserEmployeeID.Text = suser.EmployeeId.ToString();
                        textBoxUserID.Text = suser.UserId.ToString();
                        textBoxUserPassword.Text = suser.PassWord;
                        labeljobtitle.Text = suser.JobTitle;
                        buttonUserDelete.Enabled = true;
                        buttonUserUpdate.Enabled = true;
                        textBoxUserEmployeeID.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        textBoxUserSearch.Focus();
                    }
                    break;

                case 1:
                    //Search by User ID
                    int suId = Convert.ToInt32(textBoxUserSearch.Text.Trim());
                    suser = suser.SearchUID(suId);
                    if (suser != null)
                    {
                        textBoxUserEmployeeID.Text = suser.EmployeeId.ToString();
                        textBoxUserID.Text = suser.UserId.ToString();
                        textBoxUserPassword.Text = suser.PassWord;
                        labeljobtitle.Text = suser.JobTitle;
                        buttonUserDelete.Enabled = true;
                        buttonUserUpdate.Enabled = true;
                        textBoxUserEmployeeID.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        textBoxUserSearch.Focus();
                    }
                    break;

                default:
                    break;

            }
        }

        private void buttonUserListAll_Click(object sender, EventArgs e)
        {
            User user = new User();
            List<User> listU = user.GetUsers();
            user.Displaylist(listViewUser, listU);
            textBoxUserEmployeeID.Enabled = true;
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            DialogResult ans = MessageBox.Show("Are you sure you want to delete this User?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                user.DeleteUser(Convert.ToInt32(textBoxUserEmployeeID.Text));
                MessageBox.Show("User has been moved successfully.", "Confirmation");
                buttonUserUpdate.Enabled = false;
                buttonUserDelete.Enabled = false;
                textBoxUserEmployeeID.Enabled = true;
                ClearUser();
            }
        }
    }
}
