using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        private StringExercises stringExercises;

        //before each test
        [TestInitialize]
        public void Initialize()
        {
            stringExercises = new StringExercises();
        }

        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]
        public void MakeAbbaTestVersion1()
        {
            //makeAbba("Hi", "Bye") → "HiByeByeHi"
            //makeAbba("Yo", "Alice") → "YoAliceAliceYo"
            //makeAbba("What", "Up") → "WhatUpUpWhat"

            //StringExercises stringExercises = new StringExercises();

            string result = stringExercises.MakeAbba("Hi", "Bye");
            Assert.AreEqual("HiByeByeHi", result);

            result = stringExercises.MakeAbba("Yo", "Alice");
            Assert.AreEqual("YoAliceAliceYo", result);

            Assert.AreEqual("WhatUpUpWhat", stringExercises.MakeAbba("What", "Up"), "Please try agin, cutie!");
        }

        [TestMethod]
        [DataRow("Hi", "Bye", "HiByeByeHi")]
        [DataRow("Yo", "Alice", "YoAliceAliceYo")]
        [DataRow("What", "Up", "WhatUpUpWhat")]
        public void MakeAbbaTestVersion2(string first, string second, string expected)
        {
            //makeAbba("Hi", "Bye") → "HiByeByeHi"
            //makeAbba("Yo", "Alice") → "YoAliceAliceYo"
            //makeAbba("What", "Up") → "WhatUpUpWhat"

            //StringExercises stringExercises = new StringExercises();

            string result = stringExercises.MakeAbba(first, second);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void FirstTwoTest()
        {
            //firstTwo("Hello") → "He"
            //firstTwo("abcdefg") → "ab"
            //firstTwo("ab") → "ab"

            //Arrange
            //StringExercises stringExercises = new StringExercises();

            //Assert
            Assert.AreEqual("He", stringExercises.FirstTwo("Hello"));
            Assert.AreEqual("ab", stringExercises.FirstTwo("abcdefg"));
            Assert.AreEqual("ab", stringExercises.FirstTwo("ab"));

        }



    }
}
