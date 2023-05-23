using System.Linq;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook!");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("5 Remove contact");
            Console.WriteLine("Press 'x' to end.");

            var userInput = Console.ReadLine();
            
            var phoneBook= new PhoneBook();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Add number");
                        var number = Console.ReadLine();
                        if (number.Length == 9)
                        {

                            int numericValue;
                            bool IsNumber = int.TryParse(number, out numericValue);
                            if (IsNumber)
                            {
                                Console.WriteLine("The number is correct. The contact added to your list.");
                            }
                            else
                            {
                                Console.WriteLine("The number is not correct! Select operation again.");
                            }
                        }
                        else if (number.Length < 9)
                        {
                            
                            Console.WriteLine("The number is too short, try again.");
                        }
                        else Console.WriteLine("The number is too long, try again.");

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numberToSearch);
                        break;

                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "5":
                        Console.WriteLine("Remove contact");
                        Console.WriteLine("Insert a number");
                        var searchContact = Console.ReadLine();
                        phoneBook.DeleteContact(searchContact);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;

                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}