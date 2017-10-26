using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Test
{
    [TestClass]
    public class DeckUnitTests
    {
        [TestMethod]
        public void SizeOfDeck()
        {
            Deck testDeck = new Deck();

            Assert.AreEqual(testDeck.Count, 52);
        }

        [TestMethod]
        public void NoDuplicates()
        {
            Deck testDeck = new Deck();

            foreach (var item in testDeck)
            {

            }
        }
    }
}
