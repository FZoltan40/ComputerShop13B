using System.Data;

namespace ComputerShop13B.Services
{
    internal interface IDatabase
    {
        DataView GetAllData();
        bool GetData(string username, string password);
        object AddRecord(string username, string password, string email, string fullname);
        object DeleteUser(object id);
        object UpdateUser(object user);
    }
}
