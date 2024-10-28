using ContactApp.Models;
using ContactApp.Presentation;

namespace ContactApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(101, "Allen", "phillips", true, true);
            ContactAppUI.users.Add(user1);

            User user2 = new User(102, "Bob", "Jadhav",false, true);
            ContactAppUI.users.Add(user2);

            User user3 = new User(103, "Rohan", "Rane", false, true);
            ContactAppUI.users.Add(user3);

            //Add contacts in 1st staff
            Contact contact1 = new Contact(1, "Mary", "Jos", true);
            user2.AddContact(contact1);

            Contact_Details detail1 = new Contact_Details(9, Type.Contact_Type.NUMBER);
            Contact_Details detail2 = new Contact_Details(8, Type.Contact_Type.EMAIL);

            contact1.AddContactDetails(detail1);
            contact1.AddContactDetails(detail2);

            Contact contact2 = new Contact(2, "Om", "Kumar", true);
            user2.AddContact(contact2);

            detail1 = new Contact_Details(7, Type.Contact_Type.NUMBER);
            detail2 = new Contact_Details(6, Type.Contact_Type.EMAIL);

            contact2.AddContactDetails(detail1);
            contact2.AddContactDetails(detail2);

            Contact contact3 = new Contact(3, "prem", "Mane", true);
            user2.AddContact(contact3);

            detail1 = new Contact_Details(5, Type.Contact_Type.NUMBER);
            detail2 = new Contact_Details(4, Type.Contact_Type.EMAIL);

            contact3.AddContactDetails(detail1);
            contact3.AddContactDetails(detail2);

            //add contacts in 2nd staff
            contact1 = new Contact(4, "Kiran", "Pawar", true);
            user3.AddContact(contact1);

            detail1 = new Contact_Details(3, Type.Contact_Type.NUMBER);
            detail2 = new Contact_Details(2, Type.Contact_Type.EMAIL);

            contact1.AddContactDetails(detail1);
            contact1.AddContactDetails(detail2);

            contact2 = new Contact(5, "Ram", "Sathe", true);
            detail1 = new Contact_Details(1, Type.Contact_Type.NUMBER);
            detail2 = new Contact_Details(90, Type.Contact_Type.EMAIL);

            user3.AddContact(contact2);
            contact2.AddContactDetails(detail1);
            contact2.AddContactDetails(detail2);

            contact3 = new Contact(6, "Siddhi", "Rane", true);
            detail1 = new Contact_Details(91, Type.Contact_Type.NUMBER);
            detail2 = new Contact_Details(92, Type.Contact_Type.EMAIL);

            user3.AddContact(contact3);
            contact3.AddContactDetails(detail1);
            contact3.AddContactDetails(detail2);

            ContactAppUI.ContactApp();
        }
    }
}
