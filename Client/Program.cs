
using Client.MyServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyServiceClient client = new MyServiceClient();
            client.initUsers();
            bool login = false;
            Dictionary<string, string> contacts;
            while (login == false)
            {

                Console.WriteLine("Type your username:");
                string username = Console.ReadLine();
                Console.WriteLine("Type your password:");
                string password = Console.ReadLine();
                login = client.Login(username, password);
                if (login == true)
                {
                    Console.WriteLine("You logged in.");
                    string userinput = "";
                    while (userinput != "0" || userinput != "1" || userinput != "2" || userinput != "3")
                    {
                        Console.WriteLine("You can Add, Show or Delete contacts to/from the contactlist.");
                        Console.WriteLine("Please type 1 to add contact.");
                        Console.WriteLine("Please type 2 to show contact.");
                        Console.WriteLine("Please type 3 to delete contact.");
                        Console.WriteLine("Please type 0 to logout.");
                        userinput = Console.ReadLine();
                        if (userinput.Equals("1"))
                        {
                            Console.WriteLine("Give me your contact name: ");
                            string contactName = Console.ReadLine();
                            Console.WriteLine("Give me your contact number: ");
                            string contactNumber = Console.ReadLine();
                            Console.WriteLine(client.addContact(contactName, contactNumber));
                        }
                        else if (userinput.Equals("2"))
                        {
                            contacts = client.showContact();
                            for (int i = 0; i < contacts.Count; i++)
                            {
                                Console.WriteLine("Name: " + contacts.Keys.ElementAt(i) + " Number: " + contacts.Values.ElementAt(i));
                            }
                        }
                        else if (userinput.Equals("3"))
                        {
                            Console.WriteLine("Give me your contact name you want to delete: ");
                            string deleteContact = Console.ReadLine();
                            Console.WriteLine(client.deleteContact(deleteContact));
                        } else if (userinput.Equals("0"))
                        {
                            client.Logout(username);
                            login = false;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                }
            }

            Console.ReadKey();
        }
    }
}
