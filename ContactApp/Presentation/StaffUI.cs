using ContactApp.Controllers;
using ContactApp.Exceptions;
using ContactApp.Models;
using ContactApp.Type;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Presentation
{
    internal class StaffUI
    {
        static User user;
        static Random random = new Random();
        public static void StaffMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("~~~~~ Staff Menu ~~~~~\n" +
                    "1. Add new contact\n" +
                    "2. Edit contact\n" +
                    "3. Delete contact\n" +
                    "4. Display all contacts\n" +
                    "5. Find contact\n" +
                    "6. Logout");

                int choice = int.Parse(Console.ReadLine());
                SwitchMenu(choice);                
            }
        }

        private static void SwitchMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddContact(user);
                    break;
                case 2:
                    EditContact(user);
                    break;
                case 3:
                    DeleteContact(user);
                    break;
                case 4:
                    ShowAllContacts(user);
                    break;
                case 5:
                    SearchContact(user);
                    break;
                case 6:
                    LogOut();
                    break;
            }
        }

        private static void LogOut()
        {
            ContactAppUI.ContactApp();
        }

        private static void SearchContact(User user)
        {
            Console.WriteLine("Enter contact id:");
            int id = int.Parse(Console.ReadLine());
            try
            {
                Contact contact = StaffManager.Search(user, id);
                Console.WriteLine(contact);
                Console.WriteLine("----- Contact Details -----");
                PrintContactDetails(contact);
                
            }
            catch(NullContactException ce)
            {
                Console.WriteLine(ce.Message);
            }
        }

        private static void PrintContactDetails(Contact contact)
        {
            foreach (var detail in contact.Details)
            {
                Console.WriteLine(detail);
            }
        }

        private static void ShowAllContacts(User user)
        {
            foreach (Contact contact in user.contacts)
            {
                PrintContact(contact);   
            }
        }

        private static void PrintContact(Contact contact)
        {
            try
            {
                Contact contact1 = StaffManager.ChekActive(contact);
                Console.WriteLine(contact1);
                Console.WriteLine("----- Contact Details -----");
                PrintContactDetails(contact1);
                Console.WriteLine("---------------------------");
            }
            catch (NullContactException ce)
            {
                Console.WriteLine(ce.Message);
            }
        }

        private static void DeleteContact(User user)
        {
            Console.WriteLine("Enter contact Id:");
            int id = int.Parse(Console.ReadLine());
            try
            {
                StaffManager.RemoveContact(user, id);
            }
            catch(NullContactException ce)
            {
                Console.WriteLine(ce.Message);
            }
        }

        private static void EditContact(User user)
        {
            Console.WriteLine("Enter contact Id:");
            int id = int.Parse(Console.ReadLine());

            try
            {
                Contact contact = StaffManager.Search(user, id);

                Console.WriteLine("Enter contact first name:");
                contact.FirstName = Console.ReadLine();
                Console.WriteLine("Enter contact last name:");
                contact.LastName = Console.ReadLine();
            }
            catch(NullContactException ce)
            {
                Console.WriteLine(ce.Message);
            }

        }

        private static void AddContact(User user)
        {
            Console.WriteLine("Enter contact id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lName = Console.ReadLine();

            Contact contact = new Contact(id, fName, lName, true);
            user.AddContact(contact);

            Contact_Details details1 = new Contact_Details(random.Next(50), Contact_Type.NUMBER);
            Contact_Details details2 = new Contact_Details(random.Next(50), Contact_Type.EMAIL);
            contact.AddContactDetails(details1);
            contact.AddContactDetails(details2);
        }
    }
}
