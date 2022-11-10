using System;


namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        List<Contacts> addressbook = new List<Contacts>();
        public void DisplayList()
        {
            int count = 0;
            foreach (var contacts in addressbook)
            {
                Console.WriteLine("Contact Derails : " + count + "\n" + "First Name : " + contacts.FirstName + "\n" + "Last Name : " + contacts.LastName
                    + "\n" + "Address is : " + contacts.Address + "\n" + "City is : " + contacts.City + "\n" + "State is : " + contacts.State
                    + "\n" + "Zip is : " + contacts.Zip + "\n" + "Phone Number is :" + contacts.PhoneNumber + "\n" + "Email is : " + contacts.Email);
                count++;
            }
        }
        public void CreateContact()
        {
            Contacts contact = new Contacts();
            Console.Write("Enter  FirstName: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter  LastName: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter  Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter  City: ");
            contact.City = Console.ReadLine();
            Console.Write("Enter  State: ");
            contact.State = Console.ReadLine();
            Console.Write("Enter  Zip: ");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter  PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter  Email: ");
            contact.Email = Console.ReadLine();
            addressbook.Add(contact);
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressbook)
            {
                if ((contact.FirstName.Equals(name)) || (contact.LastName.Equals(name)))
                {
                    Console.WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNumber 8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 7:
                            break;
                        case 8:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 9:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    break;
                }
            }
        }

        public void Delete(string name)
        {
            try
            {
                foreach (var contact in addressbook.ToList())
                {
                    if ((contact.FirstName.Equals(name)) || (contact.LastName.Equals(name)))
                    {
                        addressbook.Remove(contact);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}