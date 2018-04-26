using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LifePath.Common;

namespace LifePath.CommonTest
{
    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void OrdinalTest()
        {
            // Arrange
            int n0 = 0;
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;
            int n10 = 10;
            int n11 = 11;
            int n20 = 20;
            int n21 = 21;
            int bigst = 54321;
            int bigth = 12345;
            int negative = -1;

            // Act
            string str0 = n0.Ordinal();
            string str1 = n1.Ordinal();
            string str2 = n2.Ordinal();
            string str3 = n3.Ordinal();
            string str4 = n4.Ordinal();
            string str10 = n10.Ordinal();
            string str11 = n11.Ordinal();
            string str20 = n20.Ordinal();
            string str21 = n21.Ordinal();
            string strBigst = bigst.Ordinal();
            string strBigth = bigth.Ordinal();
            string strNegative = negative.Ordinal();

            // Assert
            Assert.AreEqual("0th", str0);
            Assert.AreEqual("1st", str1);
            Assert.AreEqual("2nd", str2);
            Assert.AreEqual("3rd", str3);
            Assert.AreEqual("4th", str4);
            Assert.AreEqual("10th", str10);
            Assert.AreEqual("11th", str11);
            Assert.AreEqual("20th", str20);
            Assert.AreEqual("21st", str21);
            Assert.AreEqual("54321st", strBigst);
            Assert.AreEqual("12345th", strBigth);
            Assert.AreEqual("-1st", strNegative);
        }
    }
}
