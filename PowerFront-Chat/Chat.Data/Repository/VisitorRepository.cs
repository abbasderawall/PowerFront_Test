using Chat.Data.Data;
using Chat.Data.Repository.IRepository;
using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Repository
{

    public class VisitorRepository : Repository<Visitor>, IVisitor
    {
        private readonly ApplicationDbContext _db;

        public VisitorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }    
    }
   
}
