using ContactApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Controllers
{
    internal class StaffManager
    {
        static User user;

        internal static Contact ChekActive(Contact contact)
        {
            if (contact.IsActive)
            {
                return contact;
            }
            return null; 
        }

        internal static void RemoveContact(User user, int id)
        {
            Contact contact = user.contacts.Where(contact => contact.ContactId == id).FirstOrDefault();
            if (contact != null)
            {
                contact.IsActive = false;            
            }
        }

        internal static Contact Search(User user, int id)
        {
            List < Contact > contacts = user.GetContact();
            Contact contact = contacts.Where(contact => contact.ContactId == id).FirstOrDefault(); 
            if (contact == null)
            {
                return null;
            }
            return contact;
        }


    }
}
