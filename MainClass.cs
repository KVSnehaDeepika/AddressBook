using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace A
{
    class AddressBook
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address {  get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public string country { get; set; }
        public long phonenumber { get; set; }
        public string email { get; set; }
        public AddressBook(string firstname,string lastname,string address,string city,string state,int zipcode,string country,long phonenumber,string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.country = country;
            this.phonenumber = phonenumber;
            this.email = email;
        }
    }
    class MainClass

    {
        static List<AddressBook> ab = new List<AddressBook>();
        public static void Main()
        {
            int i = 1;
            while (i==1)
            {
                Console.WriteLine("1.Add contact");
                Console.WriteLine("2.Edit contact");
                Console.WriteLine("3.Display details");
                Console.WriteLine("4.Delete contact");
                Console.WriteLine("5.End");
                Console.WriteLine("Enter your choice ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1: Adddata();
                        break;
                    case 2:EditData();
                        break;
                    case 3:DisplayData();
                        break;
                    case 4:DeleteContact();
                        break;
                    case 5:Console.WriteLine("End");
                        break;
                    default:Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("To continue the process enter 1");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Adddata()
        {
            Console.WriteLine("Adding data");
            Console.WriteLine("Enter firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter zipcode");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter country");
            string country = Console.ReadLine();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            AddressBook a = new AddressBook(firstname, lastname, address, city, state, zipcode, country,phonenumber, email);
            ab.Add(a);
            Console.WriteLine("Data added");
        }
        public static void EditData()
        {
            Console.WriteLine("Enter the first name");
            string name =Console.ReadLine();
            for(int i = 0; i < ab.Count; i++)
            {
                if (ab[i].firstname == name)
                {
                    Console.WriteLine("Enter firstname");
                    ab[i].firstname = Console.ReadLine();
                    Console.WriteLine("Enter lastname");
                    ab[i].lastname = Console.ReadLine();
                    Console.WriteLine("Enter phone number");
                    ab[i].phonenumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter state");
                    ab[i].state = Console.ReadLine();
                    Console.WriteLine("Enter zipcode");
                    ab[i].zipcode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter address");
                    ab[i].address = Console.ReadLine();
                    Console.WriteLine("Enter city");
                    ab[i].city = Console.ReadLine();
                    Console.WriteLine("Enter country");
                    ab[i].country = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    ab[i].email = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Else");
                }
            }
        }
        public static void DisplayData()
        {
            foreach(AddressBook ab1 in ab)
            {
                Console.WriteLine($"First name:  {ab1.firstname}");
                Console.WriteLine("Last name:"+ ab1.lastname);
                Console.WriteLine("Email:" + ab1.email);
                Console.WriteLine("Phone number:" + ab1.phonenumber);
                Console.WriteLine("Address:" + ab1.address);
                Console.WriteLine("City:" + ab1.city);
                Console.WriteLine("State:" + ab1.state);
                Console.WriteLine("Country:" + ab1.country);
                Console.WriteLine("Zipcode:" + ab1.zipcode);
            }
        }
        public static void DeleteContact()
        {
            Console.WriteLine("Enter first name to delete data");
            string name = Console.ReadLine();
            for (int i=0;i<ab.Count;i++)
            {
                if (ab[i].firstname == name)
                {
                    ab.RemoveAt(i);
                    Console.WriteLine("Deleted contact");
                }
            }
        }
    }

}
