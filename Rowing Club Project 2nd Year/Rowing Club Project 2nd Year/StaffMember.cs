using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rowing_Club_Project_2nd_Year
{
    class StaffMember : Member
    {
        private Double price;
        public StaffMember(int memberId, String firstName, String lastName, DateTime joinDate, DateTime endDate, Byte age, String phoneNumber, String emailAddress, String type)
        {
            this.SetMemberId(memberId);
            this.SetFirstName(firstName);
            this.SetLastName(lastName);
            this.SetJoinDate(joinDate);
            this.SetEndDate(endDate);
            this.SetAge(age);
            this.SetPhoneNumber(phoneNumber);
            this.SetEmailAddress(emailAddress);
            this.SetType(type);
        }
        public Double GetPrice()
        {
            return price;
        }
        public void SetPrice(Double price)
        {
            this.price = price;
        }
    }
}
