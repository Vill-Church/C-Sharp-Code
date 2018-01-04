using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rowing_Club_Project_2nd_Year
{
    class PremiumMember : Member
    {
        private Double pricePerYear;
        public PremiumMember(int memberId, String firstName, String lastName, DateTime joinDate, DateTime endDate, Byte age, String phoneNumber, String emailAddress, String type)
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
        public Double GetPricePerYear()
        {
            return pricePerYear;
        }
        public void SetPricePerYear(Double price)
        {
            this.pricePerYear = price;
        }
    }
}
