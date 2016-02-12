using BookCheap.Busines.DomainModel;
using BookCheap.Busines.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.DataAccess
{
    internal class CommentsRepository : BaseRepository<Comment>, ICommentsRepository
    {
        public CommentsRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}