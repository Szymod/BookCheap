using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.DataAccess
{
    internal class ApplicationDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            context.Users.Add(new User {Login="Admin", Password="Admin1234", IsAdmin=true, IsBlocked=false });
            context.SaveChanges();
            //TODO wypełnienie słowników i stworzenie konta administratora 
            base.Seed(context);
        }
    }
}