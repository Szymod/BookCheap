using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Session" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Session.svc or Session.svc.cs at the Solution Explorer and start debugging.
    public class Session : ISession
    {
        public void DoWork()
        {
        }

        public string GetSession(string login, string passwd)
        {

            
        }
    }
}
