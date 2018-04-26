using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LifePath.Common.Entities;

namespace LifePath.CommonTest
{
    [TestClass]
    public class AsaTest
    {
        [TestMethod]
        public void EmptyConstrTest()
        {
            Asa asa = new Asa();

            Assert.AreEqual(0, asa.Strength);
            Assert.AreEqual(0, asa.Dexterity);
            Assert.AreEqual(0, asa.Constitution);
            Assert.AreEqual(0, asa.Intelligence);
            Assert.AreEqual(0, asa.Wisdom);
            Assert.AreEqual(0, asa.Charisma);
        }

        [TestMethod]
        public void SetConstrTest()
        {
            Asa asa = new Asa(1, 2, 3, 4, 5, 6);

            Assert.AreEqual(1, asa.Strength);
            Assert.AreEqual(2, asa.Dexterity);
            Assert.AreEqual(3, asa.Constitution);
            Assert.AreEqual(4, asa.Intelligence);
            Assert.AreEqual(5, asa.Wisdom);
            Assert.AreEqual(6, asa.Charisma);
        }

        [TestMethod]
        public void AsaAddition()
        {
            // Arrange
            Asa asa = new Asa(1, 2, 3, 4, 5, 6);
            Asi increase = new Asi(Ability.Dexterity, 5);
            Asi decrease = new Asi(Ability.Wisdom, -3);

            // Act
            asa = asa + increase;
            asa = asa + decrease;

            // Assert
            Assert.AreEqual(1, asa.Strength);
            Assert.AreEqual(7, asa.Dexterity);
            Assert.AreEqual(3, asa.Constitution);
            Assert.AreEqual(4, asa.Intelligence);
            Assert.AreEqual(2, asa.Wisdom);
            Assert.AreEqual(6, asa.Charisma);
        }
    }
}
