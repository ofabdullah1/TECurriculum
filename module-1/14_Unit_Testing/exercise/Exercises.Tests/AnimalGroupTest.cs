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

   


    



   


   



   


















}
