using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{

    [TestClass]
    public class MaxEndTests
    {
        [TestMethod]

        public void MakeArray()
        {
        
            MaxEnd3 myObject = new MaxEnd3();

            int[] nums = new int[] { 4, 8, 9 };


            int[] result = myObject.MakeArray(new int[] { 4, 8, 9 });

            
            
           Assert.AreEqual(new int[] { 9, 9, 9 },result);

        }


        [TestMethod]

        public void MakeArray2()
        {

            MaxEnd3 myObject = new MaxEnd3();

            int[] nums = new int[] { 4, 8, 9 };


            int[] result = myObject.MakeArray(new int[] { 4, 8, 9 });



            Assert.AreEqual(9, 9, 9);

        }








    }
}
