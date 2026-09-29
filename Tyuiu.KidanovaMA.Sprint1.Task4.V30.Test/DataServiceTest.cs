using Tyuiu.KidanovaMA.Sprint1.Task4.V30.Lib;

namespace Tyuiu.KidanovaMA.Sprint1.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(9, res);
        }
    }
}
