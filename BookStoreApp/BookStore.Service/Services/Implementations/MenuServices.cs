using BookStore.Core.Enums;
using BookStore.Core.Models;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Service.Services.Implementations
{
    public class MenuServices
    {
        public bool IsAdmin = false;

        private AdminUser[] adminusers = { new AdminUser { Username = "Axmed", Password = "Mehdi" }, new AdminUser { Username = "admin", Password = "admin" } };
        



        
        private BookWriterService bookWriterService = new BookWriterService();
        private BookService bookService = new BookService();
        public async Task<bool> Login()
        {
            Console.WriteLine("Add Username");
            string username=Console.ReadLine();
            Console.WriteLine("Add Password");
            string password=Console.ReadLine();
            if (adminusers.Any(x => x.Username == username && x.Password == password))
                IsAdmin = true;
            else Console.WriteLine("Username or Password incorrect");
            return IsAdmin;
        }
        public async Task ShowMenuByAdmin()
        {
            string title = @" 


                                  
 ▄█     █▄     ▄████████  ▄█        ▄████████  ▄██████▄    ▄▄▄▄███▄▄▄▄      ▄████████ 
███     ███   ███    ███ ███       ███    ███ ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███ 
███     ███   ███    █▀  ███       ███    █▀  ███    ███ ███   ███   ███   ███    █▀  
███     ███  ▄███▄▄▄     ███       ███        ███    ███ ███   ███   ███  ▄███▄▄▄     
███     ███ ▀▀███▀▀▀     ███       ███        ███    ███ ███   ███   ███ ▀▀███▀▀▀     
███     ███   ███    █▄  ███       ███    █▄  ███    ███ ███   ███   ███   ███    █▄  
███ ▄█▄ ███   ███    ███ ███▌    ▄ ███    ███ ███    ███ ███   ███   ███   ███    ███ 
 ▀███▀███▀    ██████████ █████▄▄██ ████████▀   ▀██████▀   ▀█   ███   █▀    ██████████ 
                         ▀                                                            
";
                      

            foreach (var item in title)
            {
                Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item);
            }



         Console.ForegroundColor = ConsoleColor.White;
         Console.WriteLine("0.Close");
         Console.WriteLine("1.Create BookWriter");
         Console.WriteLine("2.Show BookWriter");
         Console.WriteLine("3.Show BookWriter by id");
         Console.WriteLine("4.Show BookWriter's books");
         Console.WriteLine("5.Update BookWriter");
         Console.WriteLine("6.Remove BookWriter");
         Console.WriteLine("7.Create Book");
         Console.WriteLine("8.Update Book");
         Console.WriteLine("9.Get Book  by BookWriter");
         Console.WriteLine("10.Remove Book ");
         Console.WriteLine("11.Buy Book");

            string Request = Console.ReadLine();
            while (Request != "0")
            {
                switch (Request)
                {
                    case "1":
                        Console.Clear();
                        await CreateBookWriter();
                        break;
                    case "2":
                        Console.Clear();
                        await ShowBookWriter();
                        break;
                    case "3":
                        Console.Clear();
                        await ShowBookWriterById();
                        break;
                    case "4":
                        Console.Clear();
                        await ShowBookWriterBooks();
                        break;
                    case "5":
                        Console.Clear();
                        await UpdateBookWriter();
                        break;
                    case "6":
                        Console.Clear();
                        await RemoveBookWriter();
                        break;
                    case "7":
                        Console.Clear();
                        await CreateBook();
                        break;
                    case "8":
                        Console.Clear();
                        await UptadeBook();
                        break;
                    case "9":
                        Console.Clear();
                        await GetBookByBW();
                        break;
                    case "10":
                        Console.Clear();
                        await RemoveBook();
                        break;
                    case "11":
                        Console.Clear();
                        await BuyBook();
                        break;
                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Choose valid Option");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("0.Close");
                Console.WriteLine("1.Create BookWriter");
                Console.WriteLine("2.Show BookWriter");
                Console.WriteLine("3.Show BookWriter by id");
                Console.WriteLine("4.Show BookWriter's books");
                Console.WriteLine("5.Update BookWriter");
                Console.WriteLine("6.Remove BookWriter");
                Console.WriteLine("7.Create Book");
                Console.WriteLine("8.Update Book");
                Console.WriteLine("9.Get Book  by BookWriter");
                Console.WriteLine("10.Remove Book ");
                Console.WriteLine("11.Buy Book");
                Request = Console.ReadLine();
            }

        }
        public async Task ShowmenuByUser()
        {
            string title = @" 


██╗   ██╗███████╗███████╗██████╗ 
██║   ██║██╔════╝██╔════╝██╔══██╗
██║   ██║███████╗█████╗  ██████╔╝
██║   ██║╚════██║██╔══╝  ██╔══██╗
╚██████╔╝███████║███████╗██║  ██║
 ╚═════╝ ╚══════╝╚══════╝╚═╝  ╚═╝            
";

            foreach (var item in title)
            {
                Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0.Close");
            Console.WriteLine("1.Show BookWriter");
            Console.WriteLine("2.Show BookWriter by id");
            Console.WriteLine("3.Show BookWriter's books");
            Console.WriteLine("4.Get Book  by BookWriter");
            Console.WriteLine("5.Buy Book");

            string Request = Console.ReadLine();
            while (Request != "0")
            {
                switch (Request)
                {
                    case "1":
                        Console.Clear();
                        await ShowBookWriter();
                        break;
                    case "2":
                        Console.Clear();
                        await ShowBookWriterById();
                        break;
                    case "3":
                        Console.Clear();
                        await ShowBookWriterBooks();
                        break;
                    case "4":
                        Console.Clear();
                        await GetBookByBW();
                        break;
                    case "5":
                        Console.Clear();
                        await BuyBook();                  
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Choose valid Option");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("0.Close");
                Console.WriteLine("1.Show BookWriter");
                Console.WriteLine("2.Show BookWriter by id");
                Console.WriteLine("3.Show BookWriter's books");
                Console.WriteLine("4.Get Book  by BookWriter");
                Console.WriteLine("5.Buy Book");
                Request = Console.ReadLine();
            }

        }

        private async Task CreateBookWriter()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();
            Console.WriteLine("Add SurName");
            string surname = Console.ReadLine();
            Console.WriteLine("Add Age");
            int.TryParse(Console.ReadLine(), out int age);

            string message = await bookWriterService.CreateAsync(name, surname, age);
            Console.WriteLine(message);
        }
        private async Task ShowBookWriter()
        {

            await bookWriterService.GetAllAsync();
        }
        private async Task ShowBookWriterById()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add BookWriter Id");
            int.TryParse(Console.ReadLine(), out int id);

            BookWriter bookwriter = await bookWriterService.GetAsync(id);

            if (bookwriter != null)
                Console.WriteLine(bookwriter);
        }
        private async Task ShowBookWriterBooks()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add BookWriter Id");
            int.TryParse(Console.ReadLine(), out int id);
            List<Book> books = await bookWriterService.GetAllBooksAsynnc(id);
            if (books != null)
            {
                foreach (var item in books)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("----------");

                }
            }
        }
        private async Task UpdateBookWriter()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();
            Console.WriteLine("Add SurName");
            string surname = Console.ReadLine();
            Console.WriteLine("Add Age");
            int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Add BookWriter Id");
            int.TryParse(Console.ReadLine(), out int id);

            string message = await bookWriterService.UpdateAsync(id, name, surname, age);
            Console.WriteLine(message);

        }
        private async Task RemoveBookWriter()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add BookWriter Id");
            int.TryParse(Console.ReadLine(), out int id);

            string message = await bookWriterService.DeleteAsync(id);

            Console.WriteLine(message);

        }
        private async Task CreateBook()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add BookWriter Id");
            int.TryParse(Console.ReadLine(), out int id);
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();
            Console.WriteLine("Add Price");
            int.TryParse(Console.ReadLine(), out int price);
            Console.WriteLine("Add DiscoutPrice");
            int.TryParse(Console.ReadLine(), out int discountprice);
            Console.WriteLine("InStock?");
            bool.TryParse(Console.ReadLine(), out bool InStock);
            BookCategory category;
            Console.WriteLine("Choose Category");
            foreach (var item in Enum.GetValues(typeof(BookCategory)))
            {
                Console.WriteLine((int)item + "." + item);
            }
            int.TryParse(Console.ReadLine(), out int categoryindex);

           var result= Enum.GetName(typeof(BookCategory), categoryindex);

            while (result==null)
            {
                Console.WriteLine("Choose Valid Category");
                int.TryParse(Console.ReadLine(), out categoryindex);
                result = Enum.GetName(typeof(BookCategory), categoryindex);

            }
            category = (BookCategory)categoryindex;
            string message = await bookService.CreateAsync(id, name, price, discountprice, category, InStock);
            Console.WriteLine(message);
        }
        private async Task UptadeBook()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add BookWriter BookWriterId");
            int.TryParse(Console.ReadLine(), out int bkrtid);
            Console.WriteLine("Add BookWriter BookId");
            int.TryParse(Console.ReadLine(), out int bookid);
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();
            Console.WriteLine("Add Price");
            int.TryParse(Console.ReadLine(), out int price);
            Console.WriteLine("Add DiscoutPrice");
            int.TryParse(Console.ReadLine(), out int discountprice);
            

            BookCategory category;
            Console.WriteLine("Choose Category");
            foreach (var item in Enum.GetValues(typeof(BookCategory)))
            {
                Console.WriteLine((int)item + "." + item);
            }
            int.TryParse(Console.ReadLine(), out int categoryindex);

            bool result = Enum.IsDefined(typeof(BookCategory), categoryindex);

            while (!result)
            {
                Console.WriteLine("Choose Valid Category");
                int.TryParse(Console.ReadLine(), out categoryindex);

            }
            category = (BookCategory)categoryindex;
            string message = await bookService.UpdateAsync(bkrtid, bookid, name, price, discountprice, category);
        }
        private async Task GetBookByBW()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add BookWriter BookWriterId");
            int.TryParse(Console.ReadLine(), out int bkrtid);
            Console.WriteLine("Add BookWriter BookId");
            int.TryParse(Console.ReadLine(), out int bookid);
            Book book = await bookService.GetAsync(bkrtid, bookid);
            if (book != null) 
            {
                Console.WriteLine(book);
            }

        }
        private async Task RemoveBook()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add BookWriter BookWriterId");
            int.TryParse(Console.ReadLine(), out int bkrtid);
            Console.WriteLine("Add BookWriter BookId");
            int.TryParse(Console.ReadLine(), out int bookid);
           
            string message = await bookService.DeleteAsync(bkrtid, bookid);
               
            Console.WriteLine(message);
           

        }

        private async Task BuyBook()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Add AuthorId");
            int.TryParse(Console.ReadLine(), out int bkrtid);
            Console.WriteLine("Add BookWriter BookId");
            int.TryParse(Console.ReadLine(), out int bookid);
            bool.TryParse(Console.ReadLine(), out bool InStock);

            string message = await bookService.BuyBookAsync(bkrtid, bookid, InStock);
                 Console.WriteLine(message);
        }
    }
 } 
