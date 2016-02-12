using BookCheap.Busines.DomainModel;
using BookCheap.Busines.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.DataAccess
{
    internal class RoomsTypesRepository : BaseRepository<RoomType>, IRoomsTypesRepository
    {
        public RoomsTypesRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}