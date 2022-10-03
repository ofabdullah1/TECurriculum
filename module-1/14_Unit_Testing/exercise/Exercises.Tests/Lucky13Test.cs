using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test

    {
        [TestMethod]
        public void GetLucky()
        {

            //Arrange
            Lucky13 myObject = new Lucky13();


            int[] nums = new int[] { 0, 2, 5 };
            
            
             bool result = myObject.GetLucky(new int[] { 0, 2, 5 });


            //Assert
             Assert.AreEqual(true, result);




        }


        [TestMethod]
        public void GetLucky2()
        {

            //Arrange
            Lucky13 myObject = new Lucky13();



            int[] nums = new int[] { 1, 2, 3 };


            bool result = myObject.GetLucky(new int[] { 1, 2, 3 });



            Assert.AreEqual(false, result);


        }




        [TestMethod]
        public void GetLucky3()
        {

            //Arrange
            Lucky13 myObject = new Lucky13();


            int[] nums = new int[] { 1, 2, 4 };



            bool result = myObject.GetLucky(new int[] { 1, 2, 4 });

         
            Assert.AreEqual(false, result); 


        }



    }




















}




