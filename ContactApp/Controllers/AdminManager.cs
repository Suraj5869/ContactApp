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
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public static User CheckActive(User user)
        {
            if (user.IsActive)
            {
                return user;
            }
            return null;
        }

        internal static void RemoveUser(int id)
        {
            var user = ContactAppUI.users.Where(user => user.UserId == id).FirstOrDefault();
            if (user == null)
            {
                throw new Exception();
            }
            user.IsActive = false;
        }
    }
}
