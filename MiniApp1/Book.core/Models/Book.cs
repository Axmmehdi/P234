
using System;

namespace book.core.Models
{
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        
       public void GetFullInfo ()
        {
            Console.WriteLine(Name+" "+Price);
        }
    }

}
