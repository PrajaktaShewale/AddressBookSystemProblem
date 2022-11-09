using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool option = true;
            while (option)
            {
                AddressBookMain create = new AddressBookMain();
                Console.WriteLine("1.Create  2.Edit  3.Exit");
                        int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine("First Name " + "\n" + "Last Name " + "\n" + "Address " + "\n" +
                                        "City " + "\n" + "State " + "\n" + "Zip " + "\n" +
                                        "Phone Num " + "\n" + "Email ");
                        create.CreateContact();
                        break;
                    case 2:
                        Console.WriteLine("First Name " + "\n" + "Last Name " + "\n" + "Address " + "\n" +
                                        "City " + "\n" + "State " + "\n" + "Zip " + "\n" +
                                        "Phone Num " + "\n" + "Email ");
                        create.EditContact("Prajakta");
                        break;
                    default:
                        option = false;
                        break;

                }
            }
        }
    }
}