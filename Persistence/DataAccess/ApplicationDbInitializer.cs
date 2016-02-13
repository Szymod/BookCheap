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
            //TODO wypełnienie słowników i stworzenie konta administratora 
            base.Seed(context);

            context.Users.Add(
                new User
                {
                    Login = "Admin",
                    Email = "Admin",
                    Phone = "123123123",
                    Firstname = "Admin",
                    Lastname = "Admin",
                    Password = "Admin1234",
                    IsAdmin = true,
                    IsBlocked = false
                });
            context.SaveChanges();
           
        }
    }
}