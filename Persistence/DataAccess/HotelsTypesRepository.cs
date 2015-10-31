using BookCheap.Busines.DomainModel;
using BookCheap.Busines.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.DataAccess
{
    public class HotelsTypesRepository : BaseRepository<HotelType>, IHotelsTypesRepository
    {
        public HotelsTypesRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}