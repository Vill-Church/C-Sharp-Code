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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            List<string[]> rows = File.ReadAllLines("test.csv").Select(x => x.Split(',')).ToList();
            rows.ForEach(x =>
            {
                dt.Rows.Add(x);
            });
            dataGridView1.DataSource = dt;
        }
    }
}
