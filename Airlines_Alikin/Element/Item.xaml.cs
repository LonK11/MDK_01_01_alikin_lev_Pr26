using Airlines_Alikin.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airlines_Alikin.Element
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(TicketContext Ticket)
        {
            InitializeComponent();

            lprice.Content = Ticket.price + "P";
            fromTime.Content = Ticket.time_start.ToString("HH:mm");
            fromDate.Content = Ticket.time_start.ToString("MM.dd.yyyy");
            from.Content = Ticket.from;
            toTime.Content = Ticket.time_way.ToString("HH:mm");
            toDate.Content = Ticket.time_way.ToString("MM.dd.yyyy");
            to.Content = Ticket.to;

            TimeSpan WayTime = Ticket.time_way.Subtract(Ticket.time_start);
            int totalHours = (int)Math.Floor(WayTime.TotalMinutes / 60.0);
            int minutes = WayTime.Minutes;

            way.Content = $"в пути: {totalHours:D2}:{minutes:D2}";
        }
    }
}
