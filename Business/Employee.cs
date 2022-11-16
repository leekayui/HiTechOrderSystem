using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.DataAccess;
using System.Windows.Forms;

namespace HiTechOrderSystem.Business
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private string jobTitle;
       

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        

        public virtual string DisplayInfo()
        {
            return (EmployeeId + "," + FirstName + "," + LastName);
        }
        public Employee SearchEmployeeID(int eid)
        {
            return EmployeeDA.SearchID(eid);
        }
        public void SaveEmployee(Employee emp)
        {
            EmployeeDA.SaveEmployee(emp);
        }
        public List<Employee> SearchEmployeeName(string sName)
        {
            return EmployeeDA.SearchByName(sName);
        }
        public List<Employee> GetEmployees()
        {
            return EmployeeDA.GetAllRecords();
        }
        public void Displaylist(ListView listViewE, List<Employee> listE)
        {
            listViewE.Items.Clear();
            foreach (Employee empitem in listE)
            {
                ListViewItem item = new ListViewItem(empitem.EmployeeId.ToString());
                item.SubItems.Add(empitem.FirstName);
                item.SubItems.Add(empitem.LastName);
                item.SubItems.Add(empitem.PhoneNumber);
                item.SubItems.Add(empitem.Email);
                item.SubItems.Add(empitem.JobTitle);
                listViewE.Items.Add(item);
            }
        }
        public void UpdateEmployee(Employee emp)
        {
            EmployeeDA.UpdateRecord(emp);
        }
        public bool checkemployeeid(int id)
        {
            return EmployeeDA.checkunique(id);
        }
        public void DeleteEmployee(int id)
        {
            EmployeeDA.DeleteRecord(id);
        }
    }
}
