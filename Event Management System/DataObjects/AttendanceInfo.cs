using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Management_System.DataObjects
{
    class AttendanceInfo
    {
        private attended_event attendedEvent;

        public attended_event AttendedEvent
        {
            get { return attendedEvent; }
            set { attendedEvent = value; }
        }
        private purchased_ticket purchasedTicket;

        public purchased_ticket PurchasedTicket
        {
            get { return purchasedTicket; }
            set { purchasedTicket = value; }
        }

        public AttendanceInfo(attended_event ae, purchased_ticket pt)
        {

            attendedEvent = ae;
            purchasedTicket = pt;
        }
    }
}
