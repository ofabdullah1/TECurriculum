using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
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
}
