using Chat.Data.Data;
using Chat.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Conversation = new ConverstionRepository(_db);
            Visitor = new VisitorRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ISP_Call SP_Call { get; private set; }
        public IConversation Conversation { get; private set; }
        public IVisitor Visitor { get; private set; }
      
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
