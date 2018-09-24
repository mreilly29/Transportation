using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Tests
{
    [TestFixture]
    class TruckTests
    {
        [Test]
        public void Create_Truck()
        {
            //arrange
            Truck testTruck = new Truck();
            //action
            testTruck.GetMake = "Ford";
            string response = testTruck.GetMake;
            //assert
            Assert.That(response, Is.EqualTo("Ford"));
        }
    }
}
