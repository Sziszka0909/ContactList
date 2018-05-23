using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace ThirdWcfService
{

    [ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single)]
    public class MyService : IMyService
    {

        Dictionary<string, Guid> ids = new Dictionary<string, Guid>();
        Dictionary<string, string> users = new Dictionary<string, string>();
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        public string addContact(string name, string phonenumber)
        {
            int errorCounter = Regex.Matches(phonenumber, @"[a-zA-Z]").Count;
            if (contacts.ContainsKey(name))
            {
                return "Contactlist already contains this name.";

            } else if (errorCounter == 0 && phonenumber.Length > 8)
            {
                contacts.Add(name, phonenumber);
                return "Contact added to contactlist.";
            } else
            {
                return "Invalid phonenumber.";
            }
        }

        public string deleteContact(string username)
        {
            if (contacts.ContainsKey(username))
            {
                contacts.Remove(username);
                return "Contact deleted.";
            } else
            {
                return "Contactlist doesn't contains this contact.";
            }
        }

        public void initUsers()
        {
            if(!users.ContainsKey("Jim") && !users.ContainsKey("John"))
            {
                users.Add("Jim", "Jimpass");
                users.Add("John", "Johnpass");
            }
        }

        public bool Login(string username, string password)
        {
            ids.Clear();
            if (users.ContainsKey(username))
            {
                string pass = users[username];
                if (pass.Equals(password))
                {
                    ids.Add(username, Guid.NewGuid());
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public void Logout(string username)
        {
            ids.Remove(username);
        }

        public string Message()
        {
            return "Kecske";
        }

        public Dictionary<string, string> showContact()
        {
            return contacts;
        }
    }
}
