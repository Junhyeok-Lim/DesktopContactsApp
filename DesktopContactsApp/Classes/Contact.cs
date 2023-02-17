using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DesktopContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // primary key
        public string Name { get; set; } //prop tab twice

        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
