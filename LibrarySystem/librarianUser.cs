using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class librarianUser : user
    {
        //aggregation
        libraryCard card = new libraryCard();
        public librarianUser(string nam)
        {
            name = nam;
        }
        public void borrow(books book,library l)
        {
            l.borrow(book);
        }

        public override void InteractionWithLibrary(library library)
        {
            while (true)
            {
                Console.WriteLine("Choose an action: Borrow Book (B) / Display All Books (D) / Exit (E)");
                char c = Console.ReadLine().ToLower()[0];
                switch (c)
                {

                    case 'b':
                        Console.WriteLine("Enter book details to borrow:");
                        Console.Write("Title: ");
                        string t = Console.ReadLine();
                        Console.Write("Author: ");
                        string a = Console.ReadLine();
                        Console.Write("Year: ");
                        int y = int.Parse(Console.ReadLine());
                        books b = new books()
                        {
                            title = t,
                            Author = a,
                            year = y
                        };
                        borrow(b, library);
                        break;
                    case 'd':
                        Console.WriteLine("Books available in the library:");
                        display(library);
                        break;
                    case 'e':
                        Console.WriteLine("Existing System");
                        return;

                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;
                }
            }
        }
    }
}
