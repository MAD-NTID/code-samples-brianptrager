using System;
using System.Text;

namespace Snowing_Cats_and_Dogs
{
    public class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Owner(string firstName, string lastName, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
        }

        public Owner()
        {
            this.FirstName = "N/A";
            this.LastName = "N/A";
            this.Phone = "Unknown";
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"Name: {FirstName} {LastName}"));
            sb.Append(String.Format($"Phone Number: {Phone}"));

            return sb.ToString();
        }
    }
}