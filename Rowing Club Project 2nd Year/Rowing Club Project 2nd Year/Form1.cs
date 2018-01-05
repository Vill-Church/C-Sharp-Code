using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowing_Club_Project_2nd_Year
{
    public partial class Form1 : Form
    {
        private Club RowingClub = new Club();
        private int rowSelected;
        public Form1()
        {
            InitializeComponent();
        }
        private void DataToTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Join Date");
            dt.Columns.Add("End Date");
            dt.Columns.Add("Age");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Email Address");
            dt.Columns.Add("Type");
            RowingClub.SetListOfMembers();
            List<string[]> row = RowingClub.GetListOfMembers().Select(x => x.Split(',')).ToList();
            row.ForEach(x =>
            {
                dt.Rows.Add(x);
            });
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataToTable();
            MemberAdd addMember = new MemberAdd(); // for testing
            addMember.Show(); // for testing
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update list and commit changes
        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Update list where deleted and commit changes
        }
        private void SaveCsv(List<String> members)
        {

        }

    }
}
