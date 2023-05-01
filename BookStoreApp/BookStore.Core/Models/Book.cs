using BookStore.Core.Enums;
using BookStore.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models
{
    public class Book : BaseModel
    {
        private static int _id;
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public BookCategory Category { get; set; }
        public bool InStock { get; set; }                               
        public BookWriter Writer { get; set; }
        public Book(string name, double price, double discountprice, BookCategory category, BookWriter writer, bool inStock)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            DiscountPrice = discountprice;
            Category = category;
            Writer = writer;
            CreatedDate = DateTime.UtcNow.AddHours(4);
            InStock=inStock;



        }

        public override string ToString()
        {
            if (DiscountPrice < Price)
            {
                return $"There is: {Price - DiscountPrice} discount, Name:{Name},Price:{DiscountPrice},Category:{Category}, Stock: {InStock}, Author:{Writer},DateTime:{CreatedDate},UpDate:{UpdatedDate}";
            }

            return $"Name:{Name},Price:{Price},Category:{Category}, Stock: {InStock}, Author:{Writer},DateTime:{CreatedDate},UpDate{UpdatedDate}";
        }
    }
}
