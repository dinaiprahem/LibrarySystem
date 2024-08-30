using System.ComponentModel.Design;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to library system ");
            library library = new library();
            AddTestBooks(library);
            Console.WriteLine("Are you librarian(L) or Regular User (U)?");
            char ans = Console.ReadLine().ToLower()[0];
            if(ans=='l')
            {
                Console.WriteLine("Hello Librarian , enter your name ");
                string nam = Console.ReadLine();
                librarian l = new librarian(nam);
                Console.WriteLine($"welcome {nam}");
                l.InteractionWithLibrary(library);
               

            }
            else if(ans=='u')
               {
                Console.WriteLine("Hello User , enter your name ");
                string n = Console.ReadLine();
                librarianUser u = new librarianUser(n);
                Console.WriteLine($"welcome {n}");
               
                u.InteractionWithLibrary(library);

            }
            else
            {
                Console.WriteLine("please enter correct value ! (l/u)");
            }

        }
        // to test user
        private static void AddTestBooks(library library)
        {
            library.add(new books { title = "Book One", Author = "Author One", year = 2020 });
            library.add(new books { title = "Book Two", Author = "Author Two", year = 2021 });
            library.add(new books { title = "Book Three", Author = "Author Three", year = 2022 });
        }
    }
}
