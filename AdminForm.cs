using BaseBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin1
{
    public partial class AdminForm : Form
    {
    List<AdminUser> Admin;
         public AdminForm()
        {
         InitializeComponent();
            Admin = new List<AdminUser>()
            {
                new AdminUser {AdminName = "Parham",AdminLastname = "Darvishi",Nationalcode = "61458418", PhoneNumber = "09263548564",Gender = true, ManagmentCode = 5984848, },
                new AdminUser { AdminName = "samane", AdminLastname = "brojehri", Nationalcode = "61458518", PhoneNumber = "09263523564", Gender = false, ManagmentCode = 5984423, }
            };
            AdminDataGridveiw.DataSource = Admin;

        }
        string gender;
        private void ADSubmitButton_Click(object sender, EventArgs e)
        {
            var adminUser = new AdminUser()
            {
                AdminName = AdNmTXtBox.Text,
                AdminLastname = LNTxtBox.Text,
                Nationalcode = AdNcTxtBox.Text,
                PhoneNumber = PHTxtBox.Text,
                ManagmentCode = int.Parse(ManagmentCodeTextBox.Text),
                Gender = StatusGroupBox.Created,
                Gendermessage = GenderLable.Text
            };
            if (!string.IsNullOrEmpty(adminUser.PhoneNumber) && !adminUser.PhoneNumber.StartsWith("0"))
            {

                MessageBox.Show("you dont have 0 at first your number ");
                PHTxtBox.Text = "0" + adminUser.PhoneNumber;
                adminUser.PhoneNumber = "0" + adminUser.PhoneNumber;
                PHTxtBox.SelectionStart = PHTxtBox.Text.Length;
            }
            if (adminUser.PhoneNumber.StartsWith("+"))
            {
                adminUser.PhoneNumber = "0" + adminUser.PhoneNumber.Substring(1);
            }
            else
            {
                adminUser.PhoneNumber = adminUser.PhoneNumber.Replace("+", "");
                PHTxtBox.Text = adminUser.PhoneNumber.Replace("+", "");
            }

            MessageBox.Show($"The admin name is {adminUser.AdminName} and lastname is {adminUser.AdminLastname} and number is {adminUser.PhoneNumber} and nationalcode is {adminUser.Nationalcode} and " +
                $"and gender is {adminUser.Gendermessage}");

            AdminUser data2 = new AdminUser() {
                AdminName = AdNmTXtBox.Text,
                AdminLastname = LNTxtBox.Text,
                Nationalcode = AdNcTxtBox.Text,
                PhoneNumber = PHTxtBox.Text,
                ManagmentCode = int.Parse(ManagmentCodeTextBox.Text),
                Gender = StatusGroupBox.Created,
            };
            Admin.Add(data2);
            AdminDataGridveiw.DataSource = null;
            AdminDataGridveiw.DataSource = Admin;
            AdminDataGridveiw.Refresh();
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
            GenderLable.Text = gender;

        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
            GenderLable.Text = gender;
        }
    }
}
