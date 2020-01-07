using ConsoleApp21;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Mock<IDataRepository> moqRepo =
            //    new Mock<IDataRepository>();
            Guid id = Guid.NewGuid();
            //moqRepo.Setup(
            //    repo => repo.Read(id))
            //    .Returns(
            //    new SomePoco() 
            //    { 
            //        Id = id, 
            //        Name = "Joe Smith" 
            //    });


            IDataRepository repo = new DataRepository();


            SomePocoLogic logic =
                new SomePocoLogic(repo);
            SomePoco poco = logic.Read(id);

            Assert.AreEqual("Joe Smith", poco.Name);

        }
    }
}
