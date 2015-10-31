using BookCheap.Busines.DomainModel;
using BookCheap.Persistence.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("BookCheap")
        {
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelType> HotelsTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomsTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new AttachmentMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new HotelMapping());
            modelBuilder.Configurations.Add(new HotelTypeMapping());
            modelBuilder.Configurations.Add(new RoomMapping());
            modelBuilder.Configurations.Add(new RoomTypeMapping());
            modelBuilder.Configurations.Add(new ReservationMapping());
            modelBuilder.Configurations.Add(new ApplicationMapping());
            modelBuilder.Configurations.Add(new TagMapping());
            base.OnModelCreating(modelBuilder);
        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
