using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Management_System.DataObjects
{
    class EventBlock
    {
        private events events;
        private bool total;

        public bool Total
        {
            set { total = value; }
        }

        private decimal earnings;

        public decimal Earnings
        {
            set { earnings = value; }
        }

        private int attended;

        public int Attended
        {
            set { attended = value; }
        }

        private string eventname;

        public string Eventname
        {
            set { eventname = value; }
        }



        public List<string> block
        {
            get
            {
                List<string> temp = new List<string>();
                temp.Add("<tr><th colspan=\"4\">"+eventname+"</th></tr>");
                temp.Add("<tr><th colspan=\"2\">Attendance</th><th>Ticket</th><th>Price</th></tr>");
                foreach (UserTicket u in SQL.ReportTool.GetAttandance(events))
                {
                    temp.Add("<tr><td class=\"report\" colspan=\"2\">"+u.User.username+"</td><td class=\"report\">"+u.PurchasedTicket.ticket.ticketname+"</td><td class=\"report\">$"+u.PurchasedTicket.paid+"</td></tr>");
                }
                if (total == true)
                {
                    temp.Add("<tr><th>Total Attendance</th><td class=\"report\">" + attended + "</td><th>Total Sales</th><td class=\"report\">$" + earnings + "<td></tr>");
                }
                temp.Add("<tr><td colspan=\"4\"></td></tr>");
                    return temp;
            }
        }

        public EventBlock()
        {
            events = new events();
            total = false;
        }

    }
}
