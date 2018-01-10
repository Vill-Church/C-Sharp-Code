using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowing_Club_Project_2nd_Year
{
    class Club
    {
        private String ClubName;
        private static List<String> ListOfMembers = new List<String>();
        private String date1 = null;
        private String filePath;
        public String GetClubName()
        {
            return ClubName;
        }
        public void SetClubName(String ClubName)
        {
            this.ClubName = ClubName;
        }
        public List<String> GetListOfMembers()
        {
            // add stuff here
            return ListOfMembers;
        }
        public void SetFilePath(String path)
        {
            this.filePath = path;
        }
        public String GetFilePath()
        {
            return this.filePath;
        }
        public void SetListOfMembers()
        {
            Stream membersFile = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select Members CSV file";
            openFile.Filter = "CSV Files|*.csv";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((membersFile = openFile.OpenFile()) != null)
                    {
                        ListOfMembers = File.ReadAllLines(openFile.FileName).ToList();
                        this.SetFilePath(openFile.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read selected file. Error message: "+ ex.Message.ToString());
                }
            }
            
        }
    }
}
