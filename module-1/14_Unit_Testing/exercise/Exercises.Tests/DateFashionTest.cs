using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest

    {
        [TestMethod]
        public void GetATable()
        {

            //Arrange
            DateFashion you = new DateFashion();




            //Act
            int result = you.GetATable(5, 10);


            //Assert
            Assert.AreEqual(2, result);




        }


        [TestMethod]
        public void GetATable2()
        {
            //Arrange
            DateFashion you = new DateFashion();




            //Act
            int result = you.GetATable(5, 2);


            //Assert
            Assert.AreEqual(0, result);




        }

        [TestMethod]
        public void GetATable3()
        {
            //Arrange
            DateFashion you = new DateFashion();




            //Act
            int result = you.GetATable(5, 5);


            //Assert
            Assert.AreEqual(1, result);



        }



    }

}
