using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;

namespace TestableClasses.Test
{
    [TestClass]
    public class StringExercisesTest
    {
        [TestMethod]
        public void TestAbbaWithSimpleStrings()
        {
            //Arrange
            StringExercises testObject = new StringExercises();

            //Act
            string result = testObject.MakeAbba("one", "two");

            //Assert
            Assert.AreEqual("onetwotwoone", result);

        }

        [TestMethod]
        public void TestAbbaWithSimplerStrings()
        {
            //Arrange
            StringExercises testObject = new StringExercises();

            //Act
            string result = testObject.MakeAbba("a", "b");

            //Assert
            Assert.AreEqual("abba", result);

        }


        [TestMethod]
        public void TestAbbaWithEmptyStrings()
        {
            //Arrange
            StringExercises testObject = new StringExercises();

            //Act
            string result = testObject.MakeAbba("a", "");

            //Assert
            Assert.AreEqual("aa", result);

        }



        [TestMethod]

        public void TestFirstWithString()
        {
            //Arrange
            StringExercises myStringExercises = new StringExercises();
            //Act
            string result = myStringExercises.FirstTwo("abcdefg");
            //Assert

            Assert.AreEqual("ab", result);
        }


        //[TestMethod]

        //public void TestFirstTwoWithNull()
        //{
        //    //Arrange
        //    StringExercises myStringExercises = new StringExercises();
        //    //Act
        //    string result = myStringExercises.FirstTwo(null);
        //    //Assert

        //    Assert.IsNull(result);



    }










}

