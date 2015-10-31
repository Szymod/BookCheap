using BookCheap.Busines.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.DataAccess
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationDbContext DbContext { get; set; }

        public UnitOfWork()
        {
            CreateDbContext();
        }

        private IApplicationsRepository _applications;
        private IAttachmentsRepository _attachments;
        private ICommentsRepository _comments;
        private IHotelsRepository _hotels;
        private IHotelsTypesRepository _hotelsTypes;
        private IReservationsRepository _reservations;
        private IRoomsRepository _rooms;
        private IRoomsTypesRepository _roomsTypes;
        private ITagsRepository _tags;
        private IUsersRepository _users;


        public IApplicationsRepository Applications
        {
            get
            {
                if (_applications == null)
                {
                    _applications = new ApplicationsRepository(DbContext);
                }

                return _applications;
            }
        }
        public IAttachmentsRepository Attachments
        {
            get
            {
                if (_attachments == null)
                {
                    _attachments = new AttachmentsRepository(DbContext);
                }

                return _attachments;
            }
        }
        public ICommentsRepository Comments
        {
            get
            {
                if (_comments == null)
                {
                    _comments = new CommentsRepository(DbContext);
                }

                return _comments;
            }
        }
        public IHotelsRepository Hotels
        {
            get
            {
                if (_hotels == null)
                {
                    _hotels = new HotelsRepository(DbContext);
                }

                return _hotels;
            }
        }
        public IHotelsTypesRepository HotelsTypes
        {
            get
            {
                if (_hotelsTypes == null)
                {
                    _hotelsTypes = new HotelsTypesRepository(DbContext);
                }

                return _hotelsTypes;
            }
        }
        public IReservationsRepository Reservations
        {
            get
            {
                if (_reservations == null)
                {
                    _reservations = new ReservationsRepository(DbContext);
                }

                return _reservations;
            }
        }
        public IRoomsRepository Rooms
        {
            get
            {
                if (_rooms == null)
                {
                    _rooms = new RoomsRepository(DbContext);
                }

                return _rooms;
            }
        }
        public IRoomsTypesRepository RoomsTypes
        {
            get
            {
                if (_roomsTypes == null)
                {
                    _roomsTypes = new RoomsTypesRepository(DbContext);
                }

                return _roomsTypes;
            }
        }
        public ITagsRepository Tags
        {
            get
            {
                if (_tags == null)
                {
                    _tags = new TagsRepository(DbContext);
                }

                return _tags;
            }
        }
        public IUsersRepository Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UsersRepository(DbContext);
                }

                return _users;
            }
        }
      
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        protected void CreateDbContext()
        {
            DbContext = new ApplicationDbContext();

            DbContext.Configuration.ProxyCreationEnabled = true;
            DbContext.Configuration.LazyLoadingEnabled = true;
            DbContext.Configuration.ValidateOnSaveEnabled = true;

        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }

        }
        #endregion
    }
}
