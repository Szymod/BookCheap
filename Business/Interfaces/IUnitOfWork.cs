using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.Interfaces
{
    public interface IUnitOfWork
    {

        IApplicationsRepository Applications { get; }
        IAttachmentsRepository Attachments { get; }
        ICommentsRepository Comments { get; }
        IHotelsRepository Hotels { get; }
        IHotelsTypesRepository HotelsTypes { get; }
        IReservationsRepository Reservations { get; }
        IRoomsRepository Rooms { get; }
        IRoomsTypesRepository RoomsTypes { get; }
        ITagsRepository Tags { get; }
        IUsersRepository Users { get; }
        void Commit();
        bool HasChanges();

    }
}
