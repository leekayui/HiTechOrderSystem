using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.DataAccess;
using System.Windows.Forms;

namespace HiTechOrderSystem.Business
{
    public class User:Employee
    {
        private int userId;
        private string passWord;
       


        public int UserId { get => userId; set => userId = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        
        public override string DisplayInfo()
        {
            return (base.DisplayInfo()+","+passWord);
        }
        public string LogIn(int id,string pwd)
        {
            return UserDA.VerifyLogIn(id,pwd);
        }
        public void AddUser(User user)
        {
            UserDA.AddUser(user);
        }
        public bool checkemployeeexist(int id)
        {
            return UserDA.checkexist(id);
        }
        public string findejobtitle(int id)
        {
            return UserDA.findjobtitle(id);
        }
        public User SearchEID(int eid)
        {
            return UserDA.SearchEID(eid);
        }
        public User SearchUID(int uid)
        {
            return UserDA.SearchUID(uid);
        }
        public List<User> GetUsers()
        {
            return UserDA.GetAllRecords();
        }
        public void Displaylist(ListView listViewUser, List<User> listU)
        {
            listViewUser.Items.Clear();
            foreach (User useritem in listU)
            {
                ListViewItem item = new ListViewItem(useritem.EmployeeId.ToString());
                item.SubItems.Add(useritem.UserId.ToString());
                item.SubItems.Add(useritem.PassWord);
                item.SubItems.Add(useritem.JobTitle);
                listViewUser.Items.Add(item);
            }
        }
        public void UpdateUser(User user)
        {
            UserDA.UpdateRecord(user);
        }
        public void DeleteUser(int id)
        {
           UserDA.DeleteRecord(id);
        }
    }
}
