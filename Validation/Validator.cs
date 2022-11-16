using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HiTechOrderSystem.Validation
{
    public class Validator
    {
        public static bool IsValidId(string input, int size)
        {
            if (!Regex.IsMatch(input, @"^\d{" + size + "}$"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidId(TextBox txtControl, int size)
        {
            if (!IsValidId(txtControl.Text.Trim(), size))
            {
                MessageBox.Show(txtControl.Tag.ToString(), "Error");
                txtControl.Text = "";
                txtControl.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidName(string input)
        {
            if (!Regex.IsMatch(input, @"^[A-Za-z/s]*$"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidName(TextBox txtControl)
        {
            string input = txtControl.Text.Trim();
            if (!IsValidName(txtControl.Text.Trim()))
            {
                MessageBox.Show(txtControl.Tag.ToString(), "Error");
                txtControl.Text = "";
                txtControl.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
