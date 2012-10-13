using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using Event_Management_System.Properties;

namespace Event_Management_System.DataObjects
{
    static class SQL
    {
        static private EASDataContext db = new EASDataContext(Settings.Default.ConnectionString);
    

        static public bool CheckConnection()
        {
            try{
            db.Connection.Open();

            var expiredtickets = (from pt in db.purchased_tickets
                                  where (DateTime)pt.expires >= DateTime.Today
                                  select pt);

                for(int i = 0; i >= expiredtickets.ToList().Count;i++)
                {
                    expiredtickets.ToList()[i].used = 1;
                }

                db.SubmitChanges();

            db.Connection.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        static public void UpdateConnectionString()
        {
            db.Connection.Close();
            db = new EASDataContext(Settings.Default.ConnectionString);
        }


        static public class UserAdmin
        {
            static public BindingList<user> SelectAllUsers()
            {
                var results = from u in db.users
                              where u.deleted == 0
                              select u;

                BindingList<user> listUsers = new BindingList<user>();
                foreach (user u in results)
                    listUsers.Add(u);

                return listUsers;
            }

            static public void UpdateUser(user userToUpdate)
            {
                if (userToUpdate.username == null)
                {
                    userToUpdate.username = "";
                }
                if (userToUpdate.lastname == null)
                {
                    userToUpdate.lastname = "";
                }
                if (userToUpdate.firstname == null)
                {
                    userToUpdate.firstname = "";
                }

                var updatedUser = (from u in db.users
                                   where u.userid == userToUpdate.userid
                                   select u).Single();

                updatedUser.username = userToUpdate.username;
                updatedUser.firstname = userToUpdate.firstname;
                updatedUser.lastname = userToUpdate.lastname;
                updatedUser.Email = userToUpdate.Email;
                updatedUser.PhoneNumber = userToUpdate.PhoneNumber;
                updatedUser.University = userToUpdate.University;
                updatedUser.studentid = userToUpdate.studentid;
                //Console.WriteLine(updatedUser.username + " " + updatedUser.lastname + " " + updatedUser.firstname);
                db.SubmitChanges();
            }

            static public void InsertUser(user userToInsert)
            {
                string msgs = "";
                if (userToInsert.firstname == null )
                {
                    msgs = "Please finish entering the First Name" + Environment.NewLine;
                }

                if(userToInsert.lastname == null)
                {
                    msgs = "Please finish entering the Last Name" + Environment.NewLine;
                }

                if(userToInsert.username == null)
                {
                    msgs = "Please finish entering the Username" + Environment.NewLine;
                }

                if (msgs == "")
                {
                    db.users.InsertOnSubmit(userToInsert);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(msgs);
                }
            }

            static public void DeleteUser(user userToDelete)
            {


                var person = (from u in db.users
                              where u.userid == userToDelete.userid
                              select u).Single();

                person.deleted = 1;
                db.SubmitChanges();

            }
        }

        static public class TicketAdmin
        {
            static public BindingList<ticket> GetAllTickets()
            {
                var tickets = from t in db.tickets
                              where t.deleted == 0
                              select t;

                BindingList<ticket> ticketlist = new BindingList<ticket>();

                foreach (ticket t in tickets)
                    ticketlist.Add(t);


                return ticketlist;
            }

            static public void DeleteTicket(ticket ticketToDelete)
            {
                var ticket = (from t in db.tickets
                              where t.ticketid == ticketToDelete.ticketid
                              select t).Single();

                ticket.deleted = 1;

                db.SubmitChanges();
            }

            static public void EditTicket(ticket ticketToEdit)
            {
                var ticket = (from t in db.tickets
                              where t.ticketid == ticketToEdit.ticketid
                              select t).Single();

                ticket.ticketname = ticketToEdit.ticketname;
                ticket.price = ticketToEdit.price;
                ticket.condition = ticketToEdit.condition;

                db.SubmitChanges();
            }

            static public void InsertTicket(ticket ticketToInsert)
            {
                if (ticketToInsert.ticketname == null)
                {
                    MessageBox.Show( "Please enter a name for the ticket.");
                }

                db.tickets.InsertOnSubmit(ticketToInsert);
                db.SubmitChanges();
            }

        }

        static public class EventAdmin
        {
            static public BindingList<events> GetAllEvents()
            {
                var events = from ev in db.events
                             where ev.deleted == 0
                             select ev;

                BindingList<events> eventsList = new BindingList<events>();

                foreach (events ev in events)
                    eventsList.Add(ev);

                return eventsList;
            }

            static public void InsertEvent(events eventToAdd)
            {
                string msgs = "";
                if(eventToAdd.eventname == null )
                {
                   msgs= "Please Enter a name" + Environment.NewLine;
                }

                if (eventToAdd.eventdate == null)
                {
                    msgs +="No Date Entered. Please enter a date or the event will not show";
                }
                else if (eventToAdd.eventdate < DateTime.Now)
                {
                    msgs +="The event has already occured either try another date or adjust system clock";
                }

                if (msgs != "")
                {
                    MessageBox.Show(msgs);
                }
                else
                {
                    db.events.InsertOnSubmit(eventToAdd);
                    db.SubmitChanges();
                }
            }

            static public void UpdateEvent(events eventToUpdate)
            {
                var events = (from ev in db.events
                              where ev.eventid == eventToUpdate.eventid
                              select ev).Single();


                db.SubmitChanges();
            }

            static public void DeleteEvent(events eventToDelete)
            {
                var events = (from ev in db.events
                              where ev.eventid == eventToDelete.eventid
                              select ev).Single();

                events.deleted = 1;

                db.SubmitChanges();
            }

        }

        static public class RunEvent
        {
            static public events[] SelectUpComingEvents()
            {
                var events = from ev in db.events
                             where ev.deleted == 0 && ev.eventdate > DateTime.Today
                             select ev;

                return events.ToArray();
            }

            static public user[] SelectUsersNotAttending(events events)
            {

                List<user> listUsers = new List<user>();

                var users = (from u in db.users
                            join pt in db.purchased_tickets
                            on u.userid equals pt.userid into upt
                            from x in upt.DefaultIfEmpty()
                            join ae in db.attended_events
                            on x.purchaseid equals ae.purchaseid into xae
                            from y in xae.DefaultIfEmpty()
                            where y.eventid == null || y.eventid != events.eventid
                            select u);



                listUsers = users.ToList();
                List<user> peopleToRemove = new List<user>();
                peopleToRemove.AddRange( SelectAttendingUsers(events));
                foreach (user u in peopleToRemove)
                {
                    foreach (user us in users)
                    {
                        if (us.userid == u.userid)
                        {
                            listUsers.RemoveAll(ur => ur.userid == us.userid);
                        }
                    }
                }

                //returns empty tickets


                return listUsers.Distinct().ToArray();
            }

            static public List<ticket> SelectAllTicketsAsList()
            {
                var tickets = from t in db.tickets
                              select t;

                return tickets.ToList();
            }

            static public ticket[] SelectPurchasedTickets(user user)
            {
                var tickets = from pt in db.purchased_tickets
                              join t in db.tickets
                              on pt.ticketid equals t.ticketid
                              where pt.userid == user.userid
                              && pt.used == 0
                              select t;

                return tickets.ToArray();
            }

            static public void UseTicket(user user, ticket ticket, events events)
            {
                attended_event ae = new attended_event();

                ae.attended = 1;
                ae.eventid = events.eventid;

                var editingUser = (from u in db.users
                                   join pt in db.purchased_tickets
                                   on u.userid equals pt.userid
                                   where u.userid == user.userid
                                   select u).Distinct().Single();

                var editingTicket = (from pt in db.purchased_tickets
                                     where pt.userid == editingUser.userid
                                     && pt.ticketid == ticket.ticketid
                                     select pt).First();

                editingTicket.used = 1;

                editingTicket.attended_events.Add(ae);

                db.SubmitChanges();


            }

            static public void QuickTicketUser(user user, ticket ticket, events events)
            {
                attended_event ae = new attended_event();
                purchased_ticket pt = new purchased_ticket();
                ae.attended = 1;
                ae.eventid = events.eventid;

                var editingUser = (from u in db.users
                                   where u.userid == user.userid
                                   select u).Single();
                pt.userid = user.userid;
                pt.ticketid = ticket.ticketid;
                pt.paid = ticket.price;
                pt.used = 1;
                pt.attended_events.Add(ae);
                editingUser.purchased_tickets.Add(pt);

                db.SubmitChanges();


            }

            static public user[] SelectAttendingUsers(events events)
            {
                var users = from u in db.users
                            join pt in db.purchased_tickets
                            on u.userid equals pt.userid
                            join ae in db.attended_events
                            on pt.purchaseid equals ae.purchaseid
                            where ae.eventid == events.eventid
                            select u;


                return users.ToArray();
            }

            static public string SelectSingleTicket(user users, events events)
            {
                var ticket = (from t in db.tickets
                              join pt in db.purchased_tickets
                              on t.ticketid equals pt.ticketid
                              join ae in db.attended_events
                              on pt.purchaseid equals ae.purchaseid
                              where pt.userid == users.userid
                              && ae.eventid == events.eventid
                              select t.ticketname).Single();
                return ticket;
            }

            static public void UndoTicket(user users, events events)
            {
                var ticket = (from t in db.tickets
                              join pt in db.purchased_tickets
                              on t.ticketid equals pt.ticketid
                              join ae in db.attended_events
                              on pt.purchaseid equals ae.purchaseid
                              where pt.userid == users.userid
                              && ae.eventid == events.eventid
                              select new { ae,pt }).Single();
                ticket.pt.used = 0;
                db.attended_events.DeleteOnSubmit(ticket.ae);
                db.SubmitChanges();

            }
        }

        static public class PurchaseTickets
        {
            static public user[] GetUsersAsArray()
            {
                var users = from u in db.users
                            select u;

                return users.ToArray();
            }

            static public purchased_ticket[] GetUsersUnusedTickets(user users)
            {
                var tickets = from pt in db.purchased_tickets
                              where pt.used == 0
                              && pt.userid == users.userid
                              select pt;

                return tickets.ToArray();
             
            }

            static public purchased_ticket BuyTicket(user userToPurchase, ticket ticket)
            {
                var user = (from u in db.users
                            where u.userid == userToPurchase.userid
                            select u).Single();

                purchased_ticket pt = new purchased_ticket();

                if (ticket.condition == "annual")
                {
                    DateTime DT = new DateTime();
                    DT.AddYears(DateTime.Today.Year);
                    DT.AddMonths(12);
                    DT.AddDays(31);
                        
                    pt.expires = DT;
                }
                pt.ticketid = ticket.ticketid;
                pt.paid = ticket.price;
                pt.userid = user.userid;
                user.purchased_tickets.Add(pt);

                db.SubmitChanges();

                return pt;
            }

            static public List<ticket> SelectAllTicketsAsList()
            {
                var tickets = from t in db.tickets
                              select t;

                return tickets.ToList();
            }

            static public void RemoveTicket(purchased_ticket pt)
            {
                var ticket = (from t in db.purchased_tickets
                              where t.purchaseid == pt.purchaseid
                              select t).Single();

                if (ticket.attended_events.Count != 0)
                {
                    ticket.used = 1;
                    db.SubmitChanges();
                }
                else
                {
                    db.purchased_tickets.DeleteOnSubmit(ticket);
                    db.SubmitChanges();
                }
            }
        }

        static public class QuickStats
        {
            static public int[] GetStats()
            {


                int[] stats = new int[5];

                //stats[0] user count

                stats[0] = (from u in db.users
                            select u).Count();

                //stats[1] number of tickets

                stats[1] = (from t in db.tickets
                            select t).Count();

                //stats[2] number of events

                stats[2] = (from ev in db.events
                            select ev).Count();
                //stats[3] tickets sold
                stats[3] = (from pt in db.purchased_tickets
                            select pt).Count();

                //stats[4] tickets used

                stats[4] = (from ev in db.attended_events
                            where ev.attended == 1
                            select ev).Count();

                return stats;
            }

            static public string GetSales()
            {
                decimal total = new decimal();
                var purchasedTickets = from pt in db.purchased_tickets
                                       select pt.paid;

                foreach (decimal pt in purchasedTickets)
                    total += pt;

                return total.ToString("C");
            }

        }

        static public class ReportTool
        {
            static public events[] GetEventsAsArray()
            {
                return (from ev in db.events
                        select ev).ToArray();
            }



            static public List<UserTicket> GetAttandance (events events)
            {
                List<UserTicket> userTickets = new List<UserTicket>();

                var userInfo = (from u in db.users
                               join pt in db.purchased_tickets
                               on u.userid equals pt.userid
                               join ae in db.attended_events
                               on pt.purchaseid equals ae.purchaseid
                               where ae.eventid == events.eventid
                               select new { u, pt }).ToList();

                for (int i = 0; i < userInfo.Count; i++)
                    userTickets.Add(new UserTicket(userInfo[i].u, userInfo[i].pt));


                 return userTickets;
            }


        }

    }
}