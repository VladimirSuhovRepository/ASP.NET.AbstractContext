using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractContext;
using System.Data.Entity;
using Ninject;

namespace AbstractContextTest
{
    [TestClass]
    public class ContextTests
    {

        [TestMethod]
        public void FakeGetCustomer()
        {
            var AppKernel = new StandardKernel(new ResolverConfigModule());

            var warrior = AppKernel.Get<ActionClass>();
            Assert.AreEqual("Test without database", warrior.DoWork());
        }

    }
}
