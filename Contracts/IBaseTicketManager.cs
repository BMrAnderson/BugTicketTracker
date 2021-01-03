using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IBaseTicketManager
    {
        void Create();
        void Remove();
        void Update();
        object Get(int id);
    }
}
