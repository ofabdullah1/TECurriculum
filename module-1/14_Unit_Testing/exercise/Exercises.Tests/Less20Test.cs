using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test

    {
        [TestMethod]
        public void IsLessThanMultipleOf20()
        {

            //Arrange
            Less20 myObject = new Less20();




            //Act
            bool result = myObject.IsLessThanMultipleOf20(18);


            //Assert
            Assert.AreEqual(true, result);




        }


        [TestMethod]
        public void IsLessThanMultipleOf202()
        {

            //Arrange
            Less20 myObject = new Less20();




            //Act
            bool result = myObject.IsLessThanMultipleOf20(20);


            //Assert
            Assert.AreEqual(false, result);





        }




        [TestMethod]
        public void IsLessThanMultipleOf203()
        {

            //Arrange
            Less20 myObject = new Less20();




            //Act
            bool result = myObject.IsLessThanMultipleOf20(19);


            //Assert
            Assert.AreEqual(true, result);


        }



    }


}

