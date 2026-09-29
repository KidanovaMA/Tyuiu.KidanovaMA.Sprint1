using Tyuiu.KidanovaMA.Sprint1.Task0.V25.Lib;

namespace Tyuiu.KidanovaMA.Sprint1.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
