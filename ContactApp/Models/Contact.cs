using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Models
{
    internal class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsActive { get; set; }
        public List<Contact_Details> Details {  get; set; }

        public Contact(int id, string fname, string lName, bool isActive)
        {
            ContactId = id;
            FirstName = fname;
            LastName = lName;
            IsActive = isActive;
            Details = new List<Contact_Details>();
        }

        public void AddContactDetails(Contact_Details details)
        {
            Details.Add(details);
        }

        public override string ToString()
        {
            return $"Contact id: {ContactId}\n" +
                $"Contact name: {FirstName} {LastName}\n";
        }
    }
}
