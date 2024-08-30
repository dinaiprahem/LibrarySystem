using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal abstract class user
    {
        public string name
        {
            set; get;
        }
        public void display(library l )
        {
            
            l.display();

        }
        public abstract void InteractionWithLibrary(library library);
        
    }
}
