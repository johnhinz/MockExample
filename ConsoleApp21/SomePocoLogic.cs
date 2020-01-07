using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    public class SomePocoLogic
    {
        private IDataRepository _repo;

        public SomePocoLogic(IDataRepository repo)
        {
            _repo = repo;
        }

        public SomePoco Read(Guid id)
        {
            SomePoco poco = _repo.Read(id);
            return poco;
        }


    }
}
