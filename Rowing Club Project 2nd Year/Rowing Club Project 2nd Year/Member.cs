using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
