
using bookapp.app.Services;

BookServices BookServices = new BookServices();

Console.WriteLine("0.Close App");
Console.WriteLine("1.Show All Books");
Console.WriteLine("2.Book Name and Price");


string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{
    switch (RequestNumber)
    {
        case "1":
            BookServices.Showbooks();
            break;

        case "2":
          BookServices.CreateBook();
            break;
         default:
            Console.WriteLine("Select valid option");
            break;
    }



    Console.WriteLine("0.Close App");
    Console.WriteLine("1.Show All Books");
    Console.WriteLine("2.Book Name and Price");
 
    RequestNumber = Console.ReadLine();
}