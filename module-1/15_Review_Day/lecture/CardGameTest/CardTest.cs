using CardGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameTest
{

    [TestClass]
    public class CardTest
    {

        [TestMethod]
        public void CardConstructorTest()
        {


            //Arrange
            Card testCard = new Card("S", "A", false);

            //Act

            //Assert
            Assert.AreEqual("S", testCard.Suit);
            Assert.AreEqual("K", testCard.Value);
            Assert.AreEqual(false, testCard.IsFaceUp);

        }

    }
}
