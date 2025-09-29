using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ComputerShop13B.Services
{
    internal class Users : IDatabase
    {
        Connect conn = new Connect();

        public object AddRecord(string username, string password, string email, string fullname)
        {
            conn._connection.Open();

            string sql = "INSERT INTO `users`(`UserName`, `FullName`, `Password`, `Email`) VALUES (@username,@password,@email,@fullname)";

            MySqlCommand cmd = new MySqlCommand(sql, conn._connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@fullname", fullname);

            cmd.ExecuteNonQuery();

            conn._connection.Close();

            return new { message = "Sikeres regisztráció!" };
        }

        public ICollection<object> GetAllData()
        {
            ICollection<object> data = new List<object>();
            conn._connection.Open();


            conn._connection.Close();

            return data;
        }

        public object GetData(string username, string password)
        {
            conn._connection.Open();

            string sql = "SELECT * FROM users WHERE UserName = @username AND Password = @password";

            MySqlCommand cmd = new MySqlCommand(sql, conn._connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            string result = "";
            if (reader.Read() == true)
                result = "Regisztrált tag";
            else
                result = "Nem regisztrált tag";

            conn._connection.Close();

            return new { message = result };
        }
    }
}
