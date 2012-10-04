using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Management_System.DataObjects
{
    class UserTicket
    {
        private user user;

        public user User
        {
            get { return user; }
            set { user = value; }
        }
        private purchased_ticket purchasedTicket;

        public purchased_ticket PurchasedTicket
        {
            get { return purchasedTicket; }
            set { purchasedTicket = value; }
        }
        
       public UserTicket()
        {
            user = new user();
            purchasedTicket = new purchased_ticket();
        }

       public UserTicket(user u, purchased_ticket pt)
       {
           user = u;
           purchasedTicket = pt;
       }
    }
}
