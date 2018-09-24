using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Tests
{
    [TestFixture]
    class TransPoTest
    {
        [Test]
        public void Get_Make()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            testTranspo.GetMake = "Ford";
            string response = testTranspo.GetMake;
            //assert
            Assert.That(response, Is.EqualTo("Ford"));
        }

        [Test]
        public void Get_Model()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            testTranspo.GetModel = "Bronco";
            string response = testTranspo.GetModel;
            //assert
            Assert.That(response, Is.EqualTo("Bronco"));
        }

        [Test]
        public void Get_Year()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            testTranspo.GetYear = "2002";
            string response = testTranspo.GetYear;
            //assert
            Assert.That(response, Is.EqualTo("2002"));
        }

        [Test]
        public void Get_Num_Wheels()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            testTranspo.GetNumWheels = "4";
            string response = testTranspo.GetNumWheels;
            //assert
            Assert.That(response, Is.EqualTo("4"));
        }

        [Test]
        public void Get_Color()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            testTranspo.GetColor = "Red";
            string response = testTranspo.GetColor;
            //assert
            Assert.That(response, Is.EqualTo("Red"));
        }

        [Test]
        public void Get_Engine_Size()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            testTranspo.GetEngineSize = "351";
            string response = testTranspo.GetEngineSize;
            //assert
            Assert.That(response, Is.EqualTo("351"));
        }

        [Test]
        public void Get_MPH()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            int response = testTranspo.GetMPH(55);
            //assert
            Assert.That(response, Is.EqualTo(55));
        }

        [Test]
        public void Get_MPG()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            int response = testTranspo.GetMPG(55,11);
            //assert
            Assert.That(response, Is.EqualTo(605));
        }

        [Test]
        public void Get_Wear()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            string response = testTranspo.GetWear(0, 0, 0);
            //assert
            Assert.That(response, Is.EqualTo("Invalid Entry"));
        }

        [Test]
        public void Get_Wear_If_Miles_div_Heat_Is_Less_Than_50_Percent_Tread_Return_Unsafe()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            string response = testTranspo.GetWear(200, 85, 32);
            //assert
            Assert.That(response, Is.EqualTo("Unsafe"));
        }

        [Test]
        public void Get_Wear_If_Miles_div_Heat_Is_Greater_Than_50_Percent_Tread_Return_Unsafe()
        {
            //arrange
            TransPo testTranspo = new TransPo();
            //action
            string response = testTranspo.GetWear(1500, 85, 32);
            //assert
            Assert.That(response, Is.EqualTo("Safe"));
        }
    }
}
