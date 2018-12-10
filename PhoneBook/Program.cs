using System;

namespace PhoneBook
{
    class Program
    {
        public static PhoneBookContext pbCtx;
        static void Main(string[] args)
        {
            pbCtx = new PhoneBookContext();
            //AddDBRecords();
            //ReadAllDBRecords();
            //CreateARecord();
            //ReadAllDBRecords();
            //CreateARecord();
            //UpdateARecord();
            //DeleteARecord();
            ReportinNameOrder();

        }

        public static void ReportinNameOrder()
        {
            PhoneBookContext pbx = new PhoneBookContext();
            


                          
        }

        private static void CreateARecord()
        {
            try
            {
                Contact c1 = new Contact { ContactID=5, PhoneNumber = "+353-1-3333", Address = "ITT Computing Dept", Name = "Jim Jiminy" };
                pbCtx.Contacts.Add(c1);
                pbCtx.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void DeleteARecord()
        {
            Contact ct = pbCtx.Contacts.Find("01112223333");
            if (ct != null)
            {
                pbCtx.Contacts.Remove(ct);
                pbCtx.SaveChanges();
            }
        }

        private static void UpdateARecord()
        {
            try
            {
                var ct = pbCtx.Contacts.Find("01112223333");
                //Contact ct = pbCtx.Contacts.Find("01112223333");
                if (ct != null)
                {
                    ct.Address = "Technical University Dublin";
                    pbCtx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ReadAllDBRecords();
        }
        

        static void AddDBRecords()
        {
            Contact c1 = new Contact {ContactID=0,  PhoneNumber = "01112223333", Address = "ITT Computing Dept", Name = "Jim Jiminy" };
            Contact c2 = new Contact { ContactID = 1, PhoneNumber = "01112223334", Address = "9 Holmcroft, Crawley, West Sussex", Name = "Geezer" };
            Contact c3 = new Contact { ContactID = 2, PhoneNumber = "01112223335", Address = "10 Dublin Road, Cork", Name = "Billy McBurty" };
            try
            {
                pbCtx.Contacts.Add(c1);
                pbCtx.Contacts.Add(c2);
                pbCtx.Contacts.Add(c3);
                pbCtx.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ReadAllDBRecords()
        {
            Console.WriteLine();
            Console.WriteLine("Database records:");
            foreach (Contact ct in pbCtx.Contacts)
            {
                System.Console.WriteLine(ct.Name);
            }
        }


    }
}
