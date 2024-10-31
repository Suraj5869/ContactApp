using ContactApp.Exceptions;
using ContactApp.Models;
using ContactApp.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Controllers
{
    internal class AdminManager
    {
        public static User SearchUser(int id)
        {
            var user = ContactAppUI.users.Where(user => user.UserId == id).FirstOrDefault();
            if (user != null && user.IsActive == true)
            {
                return user;
            }
            throw new NullUserException("No such user exist!!!");
        }

        public static User CheckActive(User user)
        {
            if (user.IsActive)
            {
                return user;
            }
            throw new NullUserException("No such user exist!!!");
        }

        internal static void RemoveUser(int id)
        {
            var user = ContactAppUI.users.Where(user => user.UserId == id).FirstOrDefault();
            if (user == null)
            {
                throw new NullUserException("No such user exist!!!");
            }
            user.IsActive = false;
        }
    }
}
