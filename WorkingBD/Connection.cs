using MySql.Data.MySqlClient;
namespace WorkingBD
{
    public class Connection
    {
        static readonly string strConnection = "server=localhost;database=Airlines;uid=root;pwd=root;";
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(strConnection);
            connection.Open();

            return connection;
        }
        public static MySqlDataReader Query(string Sql, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("SELECT * From `Airlines`.`tickets`;", connection);
            return command.ExecuteReader();
        }
    }
}
