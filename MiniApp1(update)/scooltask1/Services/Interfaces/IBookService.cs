

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;


namespace BookApp.App.Services.Interface
{
    public interface IBookService 
    {
        public void Showbooks();
        public void CreateBook();
        public DateTime CreateDateTime();
    }




        
  
}
