using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Management_System.DataObjects
{
    static class ReportWriter
    {
        static private List<string> website = new List<string>();
        static private List<EventBlock> eventsList = new List<EventBlock>();


        static public List<string> GetForm (bool totals,List<events> eventsToReport)
        {

            #region Header
            website.Add("<html>");
            website.Add("<header>");
            website.Add("<style>");
            website.Add("body {margin:0;padding:0;}");
            website.Add("#container {width:80%;margin-left:10%}");
            website.Add("#header {text-align:center;background:lightgreen}");
            website.Add("#graph {height:300px;background:pink;}");
            website.Add("table.report {width:100%;}");
            website.Add("td.report {text-align:center;background:ddffdd;}");
            website.Add("th {background:lightgreen;}");
            website.Add("</style>");
            website.Add("</header>");
            website.Add("<body>");
            
            website.Add("<div id=\"container\">");
            website.Add("<div id=\"header\">");
            website.Add("<h1> Event Breakdown </h1>");
            website.Add("</div>");
            website.Add("<div>");
            website.Add("<table Class=\"report\">");

            #endregion

            foreach(events ev in eventsToReport)
            eventsList.Add( SQL.ReportTool.GetEventInfo(totals,ev));
             




            foreach (EventBlock eb in eventsList)
            {
                website.AddRange(eb.block);
            }

            #region Footer
            website.Add("</table>");
            website.Add("</div>");
            website.Add("</div>");
            website.Add("</body>");
            website.Add("</html>");
            #endregion


            return website;

    }
}
}
