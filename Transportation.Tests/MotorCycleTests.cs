using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Tests
{
    [TestFixture]
    class MotorCycleTests
    {
        [Test]
        public void Create_Motor_Cycle()
        {
            //arrange
            Cycle testCycle = new Cycle();
            //action
            testCycle.GetMake = "BMW";
            string response = testCycle.GetMake;
            //assert
            Assert.That(response, Is.EqualTo("BMW"));
        }

        [Test]
        public void Get_Tread_Cycle()
        {
            //arrange
            Cycle testCycle = new Cycle();
            //action            
            string response = testCycle.GetWear(20, 85, 32);
            //assert
            Assert.That(response, Is.EqualTo("Safe"));
        }
    }
}
