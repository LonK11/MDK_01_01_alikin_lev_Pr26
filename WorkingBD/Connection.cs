using MySql.Data.MySqlClient;
namespace WorkingBD
{
    public class Connection
    {
        static readonly string strConnection = "server=127.0.0.1;port=3307;database=Airlines;uid=root;pwd=;";
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
