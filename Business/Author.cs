using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderSystem.DataAccess;
using System.Windows.Forms;

namespace HiTechOrderSystem.Business
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SaveAuthor(Author author)
        {
            AuthorDA.SaveAuthor(author);
        }
        public Author SearchID(int aid)
        {
            return AuthorDA.SearchID(aid);
        }
        public List<Author> SearchName(string aName)
        {
            return AuthorDA.SearchName(aName);
        }
        public List<Author> GetAuthors()
        {
            return AuthorDA.GetAllRecords();
        }
        public void Displaylist(ListView listViewa, List<Author> lista)
        {
            listViewa.Items.Clear();
            foreach (Author a1 in lista)
            {
                ListViewItem item = new ListViewItem(a1.AuthorID.ToString());
                item.SubItems.Add(a1.FirstName);
                item.SubItems.Add(a1.LastName);
                
                listViewa.Items.Add(item);
            }
        }
        public void DeleteAuthor(int id)
        {
            AuthorDA.DeleteRecord(id);
        }
    }
}
