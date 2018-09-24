using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class CarTests
    {
        [Test]
        public void Create_Car()
        {
            //arrange
            Car testCar = new Car();
            //action
            testCar.GetMake = "Ford";
            string response = testCar.GetMake;
            //assert
            Assert.That(response, Is.EqualTo("Ford"));
        }
    }
}
