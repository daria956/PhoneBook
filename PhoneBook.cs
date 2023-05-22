using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }

        }
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(x => x.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact is not found!");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContacts()
        {
            
                DisplayContactsDetails(Contacts);
            
        }
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c=> c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
        //public void RemoveContact(String number)
        //{
        //    Contacts.Remove(number);

        //}
        public void DeleteContact(string number)

        {

            foreach (var element in Contacts)

            {

                if (element.Number == number)

                {

                    Contacts.RemoveAt(Contacts.IndexOf(element));

                    Console.WriteLine("Contact removed.");

                    return;

                }

            }

            Console.WriteLine("invalid number");

        }
      
    }
}
