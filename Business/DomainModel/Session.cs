﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
   public class Session
    {
       public Session()
       {

       }

       public int UserId { get; set; }
       public User User { get; set; }
       public int SessionId { get; set; }
       public string Key { get; set; }
       public DateTime ExpirationDate { get; set; }
    }
}
