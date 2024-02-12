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
