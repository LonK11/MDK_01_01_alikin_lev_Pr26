using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Airlines_Alikin.Classes;

namespace Airlines_Alikin.Pages
{
    /// <summary>
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        public List<TicketContext> AllTickets;
        public Ticket(string from, string to, DateTime date)
        {
            InitializeComponent();

            DateTime selectedDay = date.Date;
            AllTickets = TicketContext.AllTickets().FindAll(x =>
            ((x.from == from && to == "") ||
            (from == "" && x.to == to) ||
            (x.from == from && x.to == to)) ||
            (from == "" && to == "") &&
            x.time_start.Date == selectedDay);

            CreateUI();
        }
        public void CreateUI()
        {
            foreach (TicketContext ticket in AllTickets)
            {
                parent.Children.Add(new Element.Item(ticket));
            }
        }
    }
}
