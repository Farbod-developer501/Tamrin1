using BaseBackend.Models;
using System.Security.Cryptography.X509Certificates;

namespace Tamrin1
{
    public partial class empeloy : Form
    {
        List<UserInfo> employ;
        public empeloy()
        {
            InitializeComponent();
            employ = new List<UserInfo>
            {
                new UserInfo() {Name = "Farbod", LastName = "Mirzaee", Gender = true, Nationalcode = "97298745",PhoneNumber = "09102242764" },
                new UserInfo() {Name = "Ali", LastName = "naseri", Gender = true, Nationalcode = "972474745",PhoneNumber = "0910226764" },
                new UserInfo() {Name = "Mohammad", LastName = "akbri", Gender = true, Nationalcode = "94548745",PhoneNumber = "09452242764" }
            };
            EmployDataGridView.DataSource = employ;

        }
        string gender;
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new()
            {
                Name = NameTextBox.Text,
                LastName = LNameTextBox.Text,
                PhoneNumber = PhonenumTextBox.Text,
                Nationalcode = NationalCdTextBox.Text,
                Gender = StatusGroupBox.Created,
                Gendermessage = GenderLable.Text
            };


            if (!string.IsNullOrEmpty(userInfo.PhoneNumber) && !userInfo.PhoneNumber.StartsWith("0"))
            {

                MessageBox.Show("you dont have 0 at first your number ");
                PhonenumTextBox.Text = "0" + userInfo.PhoneNumber;
                userInfo.PhoneNumber = "0" + userInfo.PhoneNumber;
                PhonenumTextBox.SelectionStart = PhonenumTextBox.Text.Length;
            }
            if (userInfo.PhoneNumber.StartsWith("+"))
            {
                userInfo.PhoneNumber = "0" + userInfo.PhoneNumber.Substring(1);
            }
            else
            {
                userInfo.PhoneNumber = userInfo.PhoneNumber.Replace("+", "");
                PhonenumTextBox.Text = userInfo.PhoneNumber.Replace("+", "");
            }
            MessageBox.Show($"The name is {userInfo.Name} and the lasname is {userInfo.LastName} and phonenumber is {userInfo.PhoneNumber}" +
                $" and the National code is {userInfo.Nationalcode} and the gender status {userInfo.Gendermessage}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!string.IsNullOrEmpty(userInfo.Nationalcode) && userInfo.Nationalcode.All(char.IsDigit))
            {
                MessageBox.Show("national code is correct", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("the format of national code is wrong", "ٍError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UserInfo data = new UserInfo()
            {
                Name = NameTextBox.Text,
                LastName = LNameTextBox.Text,
                PhoneNumber = PhonenumTextBox.Text,
                Gendermessage = GenderLable.Text,
                Nationalcode = NationalCdTextBox.Text,
            };
            employ.Add(data);
            EmployDataGridView.DataSource = null;
            EmployDataGridView.DataSource = employ;
            EmployDataGridView.Refresh();
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

        private void BossLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm = new AdminForm();
            adminForm.Show();
        }


    }
}