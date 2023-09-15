namespace tyuiu.iipb_22_2.SoloviovIA.marketplace.tests
{
    [TestClass]
    public class SalesmanTest
    {
        [TestMethod]
        public void CreateSalesmanValid()
        {
            DateTime dates = new(2006, 12, 7);
            Salesman salesman = new("soloviov", dates);
            string name = salesman.Name;
            DateTime date = salesman.Date;
            Assert.AreEqual("soloviov", name);
            Assert.AreEqual(new DateTime(2006, 12, 7), date);

        }
    }
}