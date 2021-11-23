using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {

        IConversation Conversation { get; }
        IVisitor Visitor { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
