﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISession" in both code and config file together.
    [ServiceContract]
    public interface ISessionManager
    {
        [OperationContract]
        string GetSession(string login, string passwd);


        [OperationContract]
         bool IsSessionActive(string login, string session);
    }
}
