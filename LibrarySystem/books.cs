using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class books
    {
        public string title { set; get; }
        public string Author { set; get; }
        public int year { set; get; }
        // to compare objects 
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            books other = (books)obj;
            return title == other.title && Author == other.Author && year == other.year;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(title, Author, year);
        }

    }
}
