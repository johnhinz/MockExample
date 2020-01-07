using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args) 
        {
            SomePocoLogic logic =
                new SomePocoLogic(
                    new DataRepository());
            logic.Read(Guid.NewGuid());
        }
    }




}
