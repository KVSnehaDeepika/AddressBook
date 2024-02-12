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
