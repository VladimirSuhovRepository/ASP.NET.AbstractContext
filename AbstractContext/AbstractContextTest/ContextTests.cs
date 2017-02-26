using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractContext;
using System.Data.Entity;

namespace AbstractContextTest
{
    [TestClass]
    public class ContextTests
    {

        [TestMethod]
        public void FakeGetCustomer()
        {
            var user = new User { Name = "Test without database" };
            var context = new FakeContext();
            var rep = new UserRepository(context);
            rep.AddUser(user);
            Assert.AreEqual("Test without database", rep.GetUser(0).Name);
        }

    }
}
