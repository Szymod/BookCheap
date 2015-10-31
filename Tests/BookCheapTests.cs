using System;
using System.Linq;
using System.Collections.Generic;
using BookCheap.Persistence.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCheap.Busines.Interfaces;
using BookCheap.Busines.DomainModel;

namespace Tests
{
    [TestClass]
    public class BookCheapTests
    {
        [TestMethod]
        public void CreateNewUser()
        {
            var uow = new UnitOfWork();
            var users = uow.Users.GetAll().ToList();
            users.ForEach(user => uow.Users.Delete(user));

            uow.Users.Add(
                new User()
                {
                    Firstname = "Admin",
                    Lastname = "Admin",
                    Phone = "123-123-123",
                    Email = "admin@wp.pl",
                    Login = "admin",
                    Password = "admin1234",
                    IsAdmin = true
                });
            uow.Commit();

            var admin = uow.Users.GetAll().Where(x => x.Firstname == "Admin" && x.Lastname == "Admin").SingleOrDefault();
            Assert.IsNotNull(admin);
        }
    }
}
