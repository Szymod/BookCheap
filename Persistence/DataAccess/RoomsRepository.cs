using BookCheap.Busines.DomainModel;
using BookCheap.Busines.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.DataAccess
{
    public class RoomsRepository : BaseRepository<Room>, IRoomsRepository
    {
        public RoomsRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}