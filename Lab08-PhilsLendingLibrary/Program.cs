namespace Lab08_PhilsLendingLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my Library.");

            // Instantiate your Library here
            ILibrary library = new Library();

            while (true)
            {
                Console.WriteLine("Here are your options:");
                Console.WriteLine("View all books[1]");
                Console.WriteLine("Add a book[2]");
                Console.WriteLine("Borrow a book[3]");
                Console.WriteLine("Return a book[4]");
                Console.WriteLine("Exit[5]");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Display all books
                        break;
                    case "2":
                        // Add a book
                        break;
                    case "3":
                        // Borrow a book
                        break;
                    case "4":
                        // Return a book
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return; // exit the program
                    default:
                        Console.WriteLine("Invalid choice, please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}