using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QualityThought.UtilityLibrary.Test
{
    [TestClass]
    public class NumberUtilityTest
    {
        [TestMethod]
        public void TestIsEven_Positive()
        {
            Assert.IsTrue(NumberUtility.IsEven(4),"4 is even but shown as odd");
            Assert.IsFalse(NumberUtility.IsEven(5), "5 is odd but shown as even");
        }

        [TestMethod]
        public void TestIsEven_Negative_withZero()
        {
            bool isPass = false;
            try
            {
                NumberUtility.IsEven(0);
            }
            catch (ArgumentException)
            {
                isPass = true;
                
            }
            Assert.IsTrue(isPass, "Argument exception is not thrown");
            
        }

        [TestMethod]
        public void TestIsEven_Negative_withNegativeNumber()
        {
            bool isPass = false;
            try
            {
                NumberUtility.IsEven(-2);
            }
            catch (ArgumentException)
            {
                isPass = true;

            }
            Assert.IsTrue(isPass, "Argument exception is not thrown");

        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestIsEven_Negative_withNegativeNumber_Approach2()
        {
            NumberUtility.IsEven(-2);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestIsEven()
        {
            Assert.AreEqual(int.MaxValue%2==0,NumberUtility.IsEven(int.MaxValue),"Expected is true");
        }
    }
}
