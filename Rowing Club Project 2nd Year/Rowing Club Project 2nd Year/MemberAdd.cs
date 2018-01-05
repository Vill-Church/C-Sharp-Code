using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowing_Club_Project_2nd_Year
{
    public partial class MemberAdd : Form
    {
        public MemberAdd()
        {
            InitializeComponent();
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            if (CheckForBlanks() == true)
            {
                MessageBox.Show("Must fill out all fields.");
            }
            else
            {
                // do something with information
                StringBuilder newMember = new StringBuilder();
                newMember.Append(FirstNameTB.Text);
                newMember.Append(",");
                newMember.Append(LastNameTB.Text);
                newMember.Append(",");
                newMember.Append(JoinDate.Value.ToString());
                newMember.Append(",");
                newMember.Append(DOB.Value.ToString());
                newMember.Append(",");
                newMember.Append(PhoneNumberTB.Text);
                newMember.Append(",");
                newMember.Append(EmailTB.Text);
                newMember.Append(",");
                newMember.Append(TypeCB.SelectedItem.ToString());
                newMember.Append(",");
                // String Builder wants moving to club class and member classes implemented here instead.
            }
        }
        private Boolean CheckForBlanks()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTB.Text)) return true;
            if (string.IsNullOrWhiteSpace(LastNameTB.Text)) return true;
            if (string.IsNullOrWhiteSpace(PhoneNumberTB.Text)) return true;
            if (string.IsNullOrWhiteSpace(EmailTB.Text)) return true;
            return false;
        }
    }
}
