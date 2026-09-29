using Tyuiu.KidanovaMA.Sprint1.Task6.V6.Lib;

namespace Tyuiu.KidanovaMA.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1", ds.FindCardNameAndValue(8, 0));
        }
    }
}
