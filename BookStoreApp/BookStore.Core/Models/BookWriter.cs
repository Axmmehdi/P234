
using BookStore.Core.Models.Base;
using System;
using System.Collections.Generic;

namespace BookStore.Core.Models
{
    public class BookWriter : BaseModel
    {
        private static int _id;
        public string SurName { get; set; }
        public int Age { get; set; }

        public List<Book> Books;

        public BookWriter(string surname, string name, int age)
        {
            _id++;
            Id = _id;
            Name = name;
            SurName = surname;
            Age = age;
            Books = new List<Book>();
            CreatedDate = DateTime.UtcNow.AddHours(4);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {SurName}, Age: {Age}, CreateDate: {CreatedDate}, UpdateDate: {UpdatedDate}";
        }
    }
}