using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Models
{
    internal class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public List<Contact> contacts { get; set; }

        public User(int id, string fName, string lName, bool isAdmin, bool isActive)
        {
            UserId = id;
            FirstName = fName;
            LastName = lName;
            IsAdmin = isAdmin;
            IsActive = isActive;
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public List<Contact> GetContact()
        {
            return contacts;
        }
        public override string ToString()
        {
            return $"User Id: {UserId}\n" +
                $"User Name: {FirstName} {LastName}\n" +
                $"Admin: {IsAdmin}\n" ;
        }
    }
}
