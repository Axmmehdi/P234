


using BookStore.Service.Services.Implementations;

MenuServices menuServices = new MenuServices();
Console.WriteLine("1.As Boss");
Console.WriteLine("2.As User");
string request = Console.ReadLine();
if (request == "1")
{
    bool result = await menuServices.Login();
    while (!result)
    {
        result = await menuServices.Login();

        if (!result)
        {
            Console.WriteLine("2.Return As User");
            request = Console.ReadLine();

            if (request == "2")
                result = true;

        }
    }
}

if (menuServices.IsAdmin)
    menuServices.ShowMenuByAdmin();
else
    menuServices.ShowmenuByUser();
