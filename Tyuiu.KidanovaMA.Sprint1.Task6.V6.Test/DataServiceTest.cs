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
            int k = 10;
            var res = ds.Calculate(k);
            Assert.AreEqual(3, res);
        }
    }
}
