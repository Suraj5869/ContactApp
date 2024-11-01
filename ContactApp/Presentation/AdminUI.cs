using ContactApp.Controllers;
using ContactApp.Exceptions;
using ContactApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Presentation
{
    class AdminUI
    {
        public static void AdminMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("~~~~~ Admin Menu ~~~~~\n" +
                    "1. Add user\n" +
                    "2. Edit user\n" +
                    "3. Delete user\n" +
                    "4. Display all users\n" +
                    "5. Find user\n" +
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
                    AddUser();
                    break;
                case 2:
                    EditUser();
                    break;
                case 3:
                    DeleteUser();
                    break;
                case 4:
                    ShowAllUsers();
                    break;
                case 5:
                    FindUser();
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

        private static void FindUser()
        {
            Console.WriteLine("Enter user Id:");
            int id = int.Parse(Console.ReadLine());
            try
            {
                User user = AdminManager.SearchUser(id);
                Console.WriteLine(user);
            }
            catch(NullUserException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }

        private static void ShowAllUsers()
        {
            foreach(User user in ContactAppUI.users)
            {
                PrintUser(user);
            }
        }

        private static void PrintUser(User user)
        {
            try
            {
                User user1 = AdminManager.CheckActive(user);
                Console.WriteLine(user1);
            }
            catch (NullUserException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }

        private static void DeleteUser()
        {
            Console.WriteLine("Enter user Id:");
            int id = int.Parse(Console.ReadLine());
            try
            {
                AdminManager.RemoveUser(id);
            }
            catch(NullUserException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }

        private static void EditUser()
        {
            Console.WriteLine("Enter user id:");
            int id = int.Parse(Console.ReadLine());
            try
            {
                User user = AdminManager.SearchUser(id);

                Console.WriteLine("Enter new first name:");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Enter new last name:");
                user.LastName = Console.ReadLine();
                Console.WriteLine("User is admin: true or false");
                string input = Console.ReadLine();
                bool isAdmin = (input == "true") ? true : false;
                user.IsAdmin = isAdmin;
            }
            catch (NullUserException ne)
            {
                Console.WriteLine(ne.Message);
            }
        }

        private static void AddUser()
        {
            Console.WriteLine("Enter user id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lName = Console.ReadLine();
            Console.WriteLine("User is admin: true or false");
            string input = Console.ReadLine();
            bool isAdmin = (input =="true")? true: false;

            User user = new User(id, fName, lName, isAdmin, true);
            ContactAppUI.AddUser(user);
        }
    }
}
