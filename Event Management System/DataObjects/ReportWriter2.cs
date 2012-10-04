using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Event_Management_System.DataObjects
{
    static class ReportWriter2
    {
        /// <summary>
        /// creates a file which contains the report
        /// </summary>
        /// <param name="file">The file path and name</param>
        /// <param name="grandTotals">a bool containing the grandtotal</param>
        /// <param name="runningTotals">a bool containing the runningtotal</param>
        /// <param name="eventsList">a list of events to proccess</param>
        public static void CreateForm (string file,bool grandTotals,bool runningTotals,List<events> eventsList)
        {
            //starts the streamwriter
            StreamWriter sw = new StreamWriter(file, false);

            //prints the header block
            #region Header
            sw.WriteLine("<html>");
            sw.WriteLine("<header>");
            sw.WriteLine("<style>");
            sw.WriteLine("body {margin:0;padding:0;}");
            sw.WriteLine("#container {width:80%;margin-left:10%}");
            sw.WriteLine("#header {text-align:center;background:lightgreen}");
            sw.WriteLine("#graph {height:300px;background:pink;}");
            sw.WriteLine("table.report {width:100%;}");
            sw.WriteLine("td.report {text-align:center;background:ddffdd;}");
            sw.WriteLine("th {background:lightgreen;}");
            sw.WriteLine("</style>");
            sw.WriteLine("</header>");
            sw.WriteLine("<body>");

            sw.WriteLine("<div id=\"container\">");
            sw.WriteLine("<div id=\"header\">");
            sw.WriteLine("<h1> Event Breakdown </h1>");
            sw.WriteLine("</div>");
            sw.WriteLine("<div>");
            sw.WriteLine("<table Class=\"report\">");

            #endregion

            //initialize the grandtotals
            decimal grandTotal = 0;
            int grandAttendance = 0 ;
            //run though all the events
            foreach (events ev in eventsList)
            {
                //initialize the runningtotals
                decimal runningIncome = 0;
                int runningAttendance = 0;
                //prints more information
                sw.WriteLine("<tr><th colspan=\"4\">" + ev.eventname + "</th></tr>");
                sw.WriteLine("<tr><th colspan=\"2\">Attendance</th><th>Ticket</th><th>Price</th></tr>");
                //runningTotals though each users tickets
                foreach (UserTicket u in SQL.ReportTool.GetAttandance(ev))
                {
                    sw.WriteLine("<tr><td class=\"report\" colspan=\"2\">" + u.User.username + "</td><td class=\"report\">" + u.PurchasedTicket.ticket.ticketname + "</td><td class=\"report\">" + u.PurchasedTicket.paid.ToString("C") + "</td></tr>");
                    //increment totals
                    runningIncome += u.PurchasedTicket.paid;
                    runningAttendance++;
                    
                }
                //if running totals is active print the running total
                if (runningTotals)
                {
                    sw.WriteLine("<tr><th>Total Attendance</th><td class=\"report\">" + runningAttendance + "</td><th>Total Sales</th><td class=\"report\">" + runningIncome.ToString("C") + "<td></tr>");
                }
                //increment totals
                grandTotal += runningIncome;
                grandAttendance += runningAttendance;
                //print blank line
                sw.WriteLine("<tr><td colspan=\"4\"></td></tr>");
            }
            //if grandtotals are active and print the grand total
            if (grandTotals)
            {
                sw.WriteLine("<tr><th>Grand Total Attendance</th><td class=\"report\">" + grandAttendance + "</td><th>Grand Total Sales</th><td class=\"report\">" + grandTotal.ToString("C") + "<td></tr>");
            }
            //print the footer
            #region Footer
            sw.WriteLine("</table>");
            sw.WriteLine("</div>");
            sw.WriteLine("</div>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            #endregion
            //close the stream writer
            sw.Close();
        }

    }
}
