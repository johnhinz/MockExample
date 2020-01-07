using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    public interface IDataRepository
    {
        SomePoco Read(Guid id);
        void Create(SomePoco poco);
        void Update(SomePoco poco);
        void Delete(SomePoco poco);
    }
}
