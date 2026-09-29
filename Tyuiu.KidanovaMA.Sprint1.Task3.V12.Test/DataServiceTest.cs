using Tyuiu.KidanovaMA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.KidanovaMA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int lengthCathetus1 = 3;
            int lengthCathetus2 = 4;
            var res = ds.TriangleArea(lengthCathetus1, lengthCathetus2);
            Assert.AreEqual(6, res);
        }
    }
}
