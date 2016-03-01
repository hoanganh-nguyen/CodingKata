using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoKatas.Scheduling;
using FluentAssertions;
using NUnit.Framework;

namespace AlgoKatas.Tests.Scheduling
{
    [TestFixture]
    public class ShowSchedulerTest
    {
        private IShowScheduler _scheduler;
        [SetUp]
        public void Init()
        {
            _scheduler = new ShowScheduler();
        }

        [Test]
        public void Should_optimize_scheduling()
        {
            //Arrange
            IList<Show> shows = new List<Show>
            {
                new Show("Show1", DateTime.Parse("21/01/2016 06:00"), DateTime.Parse("21/01/2016 08:00")),
                new Show("Show2", DateTime.Parse("21/01/2016 07:00"), DateTime.Parse("21/01/2016 09:00")),
                new Show("Show3", DateTime.Parse("21/01/2016 08:00"), DateTime.Parse("21/01/2016 10:00")),
                new Show("Show4", DateTime.Parse("21/01/2016 09:00"), DateTime.Parse("21/01/2016 11:00")),
                new Show("Show5", DateTime.Parse("21/01/2016 10:00"), DateTime.Parse("21/01/2016 12:00")),
                new Show("Show6", DateTime.Parse("21/01/2016 12:00"), DateTime.Parse("21/01/2016 14:00"))
            };
            //Act
            var tmp = _scheduler.Schedule(shows);
            //Assert
            tmp.Should().HaveCount(4);

        }
    }
}
