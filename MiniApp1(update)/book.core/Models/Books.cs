
using book.core.Models.BaseModels;
using System;

namespace book.core.Models.BaseModels
{
    public class Books:BaseModel

    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void GetFullInfo()
        {
            Console.WriteLine(Name+" "+Price+" "+CreateDateTime);
        }

    }
}
