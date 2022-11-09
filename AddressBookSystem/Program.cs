using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
{

    Contacts contact = new Contacts()
    {
        FirstName = Console.ReadLine(),
        LastName = Console.ReadLine(),
        Address = Console.ReadLine(),
        City = Console.ReadLine(),
        State = Console.ReadLine(),
        Zip = Convert.ToInt64(Console.ReadLine()),
        PhoneNumber = Console.ReadLine(),
        Email = Console.ReadLine()
    };
    Console.WriteLine("contact Details" + "\n" +"First Name  " + contact.FirstName + "\n" +"Last Name  "+ contact.LastName + "\n" + "Address  "+ contact.Address + "\n" +"City  "+ contact.
        City + "\n" +"State  "+ contact.State + "\n" +"Zip  "+ contact.Zip + "\n" +"Phn Number  "+ contact.PhoneNumber + "\n" +"Email  "+ contact.Email);
}
}
}