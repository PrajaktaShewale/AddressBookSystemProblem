using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        Contacts contact = new Contacts();
        public void CreateContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            contact.PhoneNumber = Console.ReadLine();
            contact.Email = Console.ReadLine();
            print();
        }
        public void print()
        {
            Console.WriteLine("contact Details" + "\n" + "First Name  " + contact.FirstName + "\n" + "Last Name  " + contact.LastName + "\n" + "Address  " + contact.Address + "\n" + "City  " + contact.
        City + "\n" + "State  " + contact.State + "\n" + "Zip  " + contact.Zip + "\n" + "Phn Number  " + contact.PhoneNumber + "\n" + "Email  " + contact.Email);
        }
    }
}