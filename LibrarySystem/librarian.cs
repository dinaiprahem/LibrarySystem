using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    // library and user(librarian , librarian user) --> assocoation
    internal class librarian : user
    {
        public int employeeNumber { set; get; }
        public librarian(string n)
        {
            name = n;
        }
       
        public void add (books book,library l)
        {
            l.add(book);

        }
        // association and aggregation
        public void remove(books book,library l)
        {
            l.remove(book);
        }
        public override void InteractionWithLibrary(library library)
        {
            while (true)
            {
                Console.WriteLine("Choose an action: Add Book (A) / Remove Book (R) / Display All Books (D) / Exit (E)");
                char c = Console.ReadLine().ToLower()[0];
                switch (c)
                {
                    case 'a':
                        Console.WriteLine("Enter book details:");
                        Console.Write("Title:");
                        string t = Console.ReadLine();
                        Console.Write("Author:");
                        string a = Console.ReadLine();
                        Console.Write("Year:");
                        int y = int.Parse(Console.ReadLine());
                        books b = new books()
                        {
                            title = t,
                            Author = a,
                            year = y
                        };
                        add(b, library);
                        break;
                    case 'r':
                        Console.WriteLine("enter book details to Remove:");
                        Console.Write("Title:");
                        t = Console.ReadLine();
                        Console.Write("Author:");
                        a = Console.ReadLine();
                        Console.Write("Year:");
                        y = int.Parse(Console.ReadLine());
                        b = new books()
                        {
                            title = t,
                            Author = a,
                            year = y
                        };
                       remove(b, library);
                        break;
                    case 'd':
                        Console.WriteLine("Books In The Library :");
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
