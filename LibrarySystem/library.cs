using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class library
    {
        List<books> books = new List<books>();
        List<books> borrowed = new List<books>();
        public void add(books book)
        {
            books.Add(book);
                Console.WriteLine("book added successfully ");
           

        }
        public void remove(books book)
        {
            // if fixed length array
            // int i = Array.IndexOf(books, book);// return -1 if not found
            //if(i>=0 && i < index) 
            // {
            //     for(int j = i; j < index - 1; j++)
            //     {
            //         books[j] = books[j + 1];
            //     }
            //     books[index - 1] = null;
            //     index--;
            //     Console.WriteLine("book removed successfully");
            // }
            // else
            // {
            //     Console.WriteLine("book not found in the library");
            // }
            if (books.Remove(book))
            {
                Console.WriteLine("book removed successfully");
            }
            else
            {
                Console.WriteLine("book not found in the library");
            }
         

        }
        public void borrow(books book)
        {
            //if static array
            // //check if not found in the library
            // int i = Array.IndexOf(books, book);// return -1 if not found
            // if(i<0 || i>=index)
            // {
            //     Console.WriteLine("Sorry,the book is not available in the library .");
            //     return;
            // }
            // // check if is already browed so he is in the borrowed array
            //if( Array.IndexOf(borrowed, book) >= 0)
            // {
            //     Console.WriteLine("This book has already been borrowed.");
            //     return;

            // }
            // if (borrowedIndex < borrowed.Length)
            // {
            //     borrowed[borrowedIndex] = book;
            //     borrowedIndex++;
            //     remove(book);
            //     Console.WriteLine("book borrowed successfully");
            // }
            // else
            // {
            //     Console.WriteLine("sorry ,Cant borrow more books");
            // }


            // // check if is already borrowed so he is in the borrowed array
            if (borrowed.Contains(book))
            {
                Console.WriteLine("This book has already been borrowed.");
                return;


            }
            if (!books.Contains(book))
            {
                Console.WriteLine("Sorry,the book is not available in the library .");
                    return;
            }
       
            borrowed.Add(book);
            books.Remove(book);
            Console.WriteLine("Book borrowed successfully.");

        }
        public void display()
        {
            if (books.Count <= 0) {
                Console.WriteLine("There is no books here !!");

            }
            for (int i=0;i<books.Count;i++)
            {
                Console.WriteLine($"{i + 1}: {books[i].title} by {books[i].Author} ({books[i].year})");
            }
        }

    }
}
