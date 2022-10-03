using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest

    {
        [TestMethod]
        public void GenerateString()
        {

            //Arrange
            FrontTimes myObject = new FrontTimes();




            //Act
            string result = myObject.GenerateString("Candy", 3);


            //Assert
            Assert.AreEqual("CanCanCan", result);




        }


        [TestMethod]
        public void GenerateString2()
        {
            //Arrange
            FrontTimes myObject = new FrontTimes();




            //Act
            string result = myObject.GenerateString("Muffins", 2);


            //Assert
            Assert.AreEqual("MufMuf", result);




        }




        [TestMethod]
        public void GenerateString3()
        {
            //Arrange
            FrontTimes myObject = new FrontTimes();




            //Act
            string result = myObject.GenerateString("Pancakes", 5);


            //Assert
            Assert.AreEqual("PanPanPanPanPan", result);

        }



    }

}
