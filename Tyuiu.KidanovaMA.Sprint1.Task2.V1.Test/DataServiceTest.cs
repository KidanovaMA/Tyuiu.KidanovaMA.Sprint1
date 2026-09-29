using Tyuiu.KidanovaMA.Sprint1.Task2.V1.Lib;

namespace Tyuiu.KidanovaMA.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 10;
            var res = ds.ConvertKmToM(value);
            Assert.AreEqual(6.215, res);
        }
    }
}
