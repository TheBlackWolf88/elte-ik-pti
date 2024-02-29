using Bag;

namespace bag_test
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestofSetEmpty()
        {
            Bag.Bag bag = new Bag.Bag();
            Assert.AreEqual("[]", bag.ToString());
        }

        [TestMethod]
        public void TestofMax(){
            Bag.Bag bag = new Bag.Bag();

            Assert.ThrowsException<Bag.BagEmptyException>(() => bag.Max());
        }
    }
}

