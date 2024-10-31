using ContactApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Presentation
{
    internal class ContactAppUI
    {
        public static List<User> users = new List<User>();
        public static void ContactApp()
        {
            Console.WriteLine("Enter user Id:");
            int id = int.Parse(Console.ReadLine());

            CheckId(id);
        }

        private static void CheckAdmin(User user)
        {
            if (user.IsAdmin)
            {
                Console.WriteLine("current user is admin");
                Console.WriteLine(user);
                AdminUI.AdminMenu(user);
            }
            else
            {
                Console.WriteLine("current user is staff");
                Console.WriteLine(user);
                StaffUI.StaffMenu(user);
            }
        }

        private static void CheckActive(User user)
        {
            if (user.IsActive)
            {
                CheckAdmin(user);
            }    
            Console.WriteLine ("User is not active");
        }

        static void CheckId(int id)
        {
            foreach (User user in users)
            {
                CheckActiveId(user, id);
            }
            Console.WriteLine("Id does not exist!!");
        }

        private static void CheckActiveId(User user, int id)
        {
            if (user.UserId == id)
            {
                CheckActive(user);
            }
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }
       
    }
}
