using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BookCheap.Busines.Interfaces;
using BookCheap.Busines.DomainModel;
using BookCheap.Persistence.DataAccess;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Session" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Session.svc or Session.svc.cs at the Solution Explorer and start debugging.

        
    public class SessionManager : ISessionManager
    {
        TimeSpan sessionTime = TimeSpan.Parse("00:30:00");

        public void DoWork()
        {
        }

        public string GetSession(string login, string passwd)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                var x = u.Users.GetAll().Where(a => a.Login == login && a.Password == passwd).FirstOrDefault();
                if (x != null)
                {
                    string k = login + DateTime.Now.ToShortDateString()+DateTime.Now.Millisecond.ToString();
                    u.Sessions.Add(new Session(k, DateTime.Now+sessionTime));
                    return null;
                }
                else
                    return null;
            }                          
        }

        public bool IsSessionActive(string login, string session)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                var x = u.Sessions.GetAll().Where(a => a.User.Login == login && a.Key == session).FirstOrDefault();
                if (x != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
