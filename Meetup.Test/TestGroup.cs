using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meetup.Services;
using Meetup.Interfaces;

namespace Meetup.Test
{
    [TestFixture]
    public class TestGroup
    {
        IGroupsService service;
        [SetUp]
        public void Setup()
        {
            service = new GroupsService();
        }

        [Test]
        public async Task GetGroup()
        {
            var group = await service.Get("DFW-Mobile-NET");
            Assert.IsNotNull(group);
            Assert.AreEqual("DFW Mobile .NET", group.name);
            Assert.AreEqual("App Devs", group.who);
        }
    }
}
