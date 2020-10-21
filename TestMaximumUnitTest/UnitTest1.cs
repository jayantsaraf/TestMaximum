using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace TestMaximumUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Find_Maximum_Should_Return_Max_When_Max_Present_At_1st_Position()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindIntMax(13, 12, 11);
            int expected = 13;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Find_Maximum_Should_Return_Max_When_Max_Present_At_2nd_Position()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindIntMax(13, 14, 11);
            int expected = 14;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Find_Maximum_Should_Return_Max_When_Max_Present_At_3rd_Position()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindIntMax(13, 14, 15);
            int expected = 15;
            Assert.AreEqual(expected, actual);
        }
    }
}
