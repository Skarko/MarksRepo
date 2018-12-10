using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBookContext : DbContext
    {
/*        public PhoneBookContext() : base("PhoneBook1")
        {

        }*/
        public DbSet<Contact> Contacts { get; set; }
    }
}
