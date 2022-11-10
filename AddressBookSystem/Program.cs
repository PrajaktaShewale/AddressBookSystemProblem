using System;
namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain add = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Create  2. Edit  3.Delete  4.Display  5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.CreateContact();
                        break;
                    case 2:
                        Console.Write("Enter FirstName and LastName to edit ");
                        string edit = Console.ReadLine();
                        add.EditContact(edit);
                        break;
                    case 3:
                        Console.Write("Enter FirstName and LastName to Delete ");
                        string delete = Console.ReadLine();
                        add.Delete(delete);
                        break;
                    case 4:
                        add.DisplayList();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}