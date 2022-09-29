using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses.Classes;

namespace TestableClasses.Test
{
    [TestClass]
    public class LoopsAndArraysExercisesTest
    {
        [TestMethod]
        public void MiddleWayTest()
        {
            //Arrange 
            LoopsAndArrayExercises myObject = new LoopsAndArrayExercises();
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 4, 5, 6 };

            //Act
            int[] result = myObject.MiddleWay(a, b);

            //Assert
            CollectionAssert.AreEquivalent(new int[] { 5, 2 }, result);
        }
    }
}
