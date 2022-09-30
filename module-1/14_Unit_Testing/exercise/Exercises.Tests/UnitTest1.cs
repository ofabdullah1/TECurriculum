using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest

    {
        [TestMethod]
        public void GetHerdTest()
        {
            //Arrange
            AnimalGroupName myGroup = new AnimalGroupName();


            //Act
            string result = myGroup.GetHerd("rhino");


            //Assert
            Assert.AreEqual("Crash", result);


        }


        [TestMethod]
        public void GetHerdTest2()
        {
            //Arrange
            AnimalGroupName myGroup = new AnimalGroupName();


            //Act
            string result = myGroup.GetHerd("giraffe");


            //Assert
            Assert.AreEqual("Tower", result);



        }

        [TestMethod]
        public void GetHerdTest3()
        {
            //Arrange
            AnimalGroupName myGroup = new AnimalGroupName();




            //Act
            string result = myGroup.GetHerd("elephant");


            //Assert
            Assert.AreEqual("Herd", result);

        }


    }

    [TestClass]
    public class CigarPartyTest

    {
        [TestMethod]
        public void HavePartyTest()
        {

            //Arrange
            CigarParty cigar = new CigarParty();


            //Act
            bool cigars = cigar.HaveParty(30, false);


            //Assert
            Assert.AreEqual(false, cigars);




        }


        [TestMethod]
        public void HavePartyTest2()
        {
            //Arrange
            CigarParty cigar = new CigarParty();


            //Act
            bool cigars = cigar.HaveParty(50, false);


            //Assert
            Assert.AreEqual(true, cigars);




        }




        [TestMethod]
        public void HavePartyTest3()
        {
            //Arrange
            CigarParty cigar = new CigarParty();


            //Act
            bool cigars = cigar.HaveParty(70, true);


            //Assert
            Assert.AreEqual(true, cigars);



        }

    }


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
