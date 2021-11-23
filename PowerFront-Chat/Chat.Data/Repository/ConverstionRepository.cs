using Chat.Data.Data;
using Chat.Data.Repository.IRepository;
using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Repository
{

    public class ConverstionRepository : Repository<Conversation>, IConversation
    {
        private readonly ApplicationDbContext _db;

        public ConverstionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
   
}
