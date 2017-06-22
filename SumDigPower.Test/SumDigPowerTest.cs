using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumDigPower.Test
{
    [TestClass]
    public class SumDigPowerTest
    {
        private SumDigPower SumDigPower;

        [TestInitialize]
        public void Setup()
        {
            SumDigPower = new SumDigPower();
        }

        [TestMethod]
        public void TenTo150_contains89and135()
        {
            CollectionAssert.AreEqual(SumDigPower.sumDigPow(10, 150), new List<long>(){ 89L, 135L});
        }

        [TestMethod]
        public void ZeroTo100_firstTenNumbersAnd89ShoudBeContained()
        {
            CollectionAssert.AreEqual(SumDigPower.sumDigPow(1, 100), new List<long>() { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L, 89L});
        }

        [TestMethod]
	    public void ninetyTo100_isEmpty()
        {
            CollectionAssert.AreEqual(SumDigPower.sumDigPow(90, 100), new List<long>());
        }


	    [TestMethod]
	    public void TenTo100_only89Contained() {
		    CollectionAssert.Contains(SumDigPower.sumDigPow(10, 100), 89L);
	    }

        [TestMethod]
	    public void firstTenNumbers_shouldBeAllContained() {
		    CollectionAssert.AreEqual(SumDigPower.sumDigPow(1, 10), new List<long>() { 1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L, 9L});
	    }

    }
}
