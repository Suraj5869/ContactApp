using ContactApp.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Models
{
    internal class Contact_Details
    {
        public int Contact_Detail_Id { get; set; }
        public Contact_Type Type { get; set; }

        public Contact_Details(int id, Contact_Type type)
        {
            Contact_Detail_Id = id;
            Type = type;
        }

        public override string ToString()
        {
            return $"Contact detail id: {Contact_Detail_Id}\n" +
                $"Contact type: {Type}\n";
        }
    }
}
