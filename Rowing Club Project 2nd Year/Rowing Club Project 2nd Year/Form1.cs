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
        private void SaveCsv(List<String> members)
        {
            File.WriteAllLines(RowingClub.GetFilePath(),members.ToList()); // should work
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            int colmunChange = Convert.ToInt32(dataGridView1.Rows[e.ColumnIndex].Index);
        }
    }
}
