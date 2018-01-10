using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowing_Club_Project_2nd_Year
{
    class Member
    {
        private int memberId;
        private String firstName, lastName, phoneNumber, emailAddress, type;
        private DateTime joinDate, endDate;
        private Byte age;

        public int GetMemberId() {
            return memberId;
        }
        public void SetMemberId(int memberId)
        {
            this.memberId = memberId;
        }
        public String GetFristName()
        {
            return firstName;
        }
        public void SetFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String GetLastName()
        {
            return lastName;
        }
        public void SetLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public String GetPhoneNumber()
        {
            return phoneNumber;
        }
        public void SetPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public String GetEmailAddress()
        {
            return emailAddress;
        }
        public void SetEmailAddress(String emailAddress)
        {
            this.emailAddress = emailAddress;
        }
        public DateTime GetJoinDate()
        {
            return joinDate;
        }
        public void SetJoinDate(DateTime joinDate)
        {
            this.joinDate = joinDate;
        }
        public DateTime GetEndDate()
        {
            return endDate;
        }
        public void SetEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public Byte GetAge()
        {
            return age;
        }
        public void SetAge(Byte age)
        {
            this.age = age;
        }
        public String Gettype()
        {
            return type;
        }
        public void SetType(String type)
        {
            this.type = type;
        }
        public Boolean CheckPhoneNumber(String phoneNumber)
        {
            phoneNumber = phoneNumber.Replace("+44", "0"); // replaces +44 for mobile will 0
            if(phoneNumber.Length>11 && !(phoneNumber.Length == 11))
            {
                // length should be 11 digits
                return false;
            } else
            {
                return true;
            }
        }
        public Boolean CheckEmail(String email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Boolean CheckForNumbers(String toTest)
        {
            Regex numbers = new Regex(".*\\d+.*");
            if (numbers.IsMatch(toTest))
            {
                return false;
            } else
            {
                return true;
            }
        }
        public Boolean CheckAge(String ageTest)
        {
            try
            {
                if (this.CheckForNumbers(ageTest) == true)
                {
                    int age = Convert.ToInt32(ageTest);
                    if(age<=127 && age >= 0)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                } else
                {
                    return false;// age should contain a number
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
    }
}
