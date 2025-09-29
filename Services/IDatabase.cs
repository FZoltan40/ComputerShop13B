using System.Collections.Generic;

namespace ComputerShop13B.Services
{
    internal interface IDatabase
    {
        ICollection<object> GetAllData();
        object GetData(string username, string password);
    }
}
