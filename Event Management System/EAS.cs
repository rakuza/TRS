namespace Event_Management_System
{
    partial class EASDataContext
    {
    }

    partial class ticket
    {
        public override string ToString()
        {
                return ticketname;
        }
    }

    partial class events
    {
        public override string ToString()
        {
            return eventname;
        }
    }

    partial class user
    {
        public override string ToString()
        {
            return username;
        }
    }

    partial class purchased_ticket
    {
        public override string ToString()
        {
            return this.ticket.ticketname + " "+this.ticket.price.ToString("C");
        }
    }
}
