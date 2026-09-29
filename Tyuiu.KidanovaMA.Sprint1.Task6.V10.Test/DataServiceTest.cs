using Tyuiu.KidanovaMA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.KidanovaMA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("кт", ds.DeleteMiddleLetter("кот"));
        }
    }
}
