using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_Desktop_Application.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Ignore]
        public string FullName
        { 

            get {

                return FirstName + LastName;

                }       
         }

        [MinLength(1)]
        public string Phone { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        [EmailAddress]
        public string Email { get; set; }

    }
}
