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
