using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Airlines_Alikin.Classes
{
    public class TicketContext : TicketClass
    {

        public TicketContext(int price, string from, string to, DateTime time_start, DateTime time_way) : base(price, from, to, time_start, time_way) { }
        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();

            MySqlConnection connection = WorkingBD.Connection.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * From `Airlines`.`tickets`;", connection);
            MySqlDataReader ticketQuery = command.ExecuteReader();
            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketContext(
                ticketQuery.GetInt32(3),
                ticketQuery.GetString(1),
                ticketQuery.GetString(2),
                ticketQuery.GetDateTime(4),
                ticketQuery.GetDateTime(5)
                ));

            }
            connection.Close();
            MySqlConnection.ClearPool(connection);
            return allTickets;
        }
    }
}
