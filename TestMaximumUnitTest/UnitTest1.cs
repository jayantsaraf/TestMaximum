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
    }
}
