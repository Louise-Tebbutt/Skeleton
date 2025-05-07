using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock

    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
           ClsStock AStock = new ClsStock();

            // test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void GameIdPropertyOK()
        {
            //create an instance of the class we want to create 
            ClsStock Astock = new ClsStock();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property 
            Astock.GameId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(Astock.GameId, TestData);
        }


        [TestMethod]
        public void GameTitlePropertyOK()
        {
            //create an instance of the class we want to create 
            ClsStock Astock = new ClsStock();
            //create some test data to assign to the property 
            string TestData = "Elden Ring";
            //create the data to the property 
            Astock.GameTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Astock.GameTitle, TestData);

        }

        [TestMethod]
        public void GameReleaseDatePropertyOK()
        {
            //create an instance of the class we want to create 
            ClsStock Astock = new ClsStock();
            //create some test data to assisgn to the property
            DateTime TestData = DateTime.Now.Date;
            //create the data to the property 
            Astock.GameReleaseDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(Astock.GameReleaseDate, TestData);

        }

        [TestMethod]
        public void GamePricePropertyOK()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();

            //create some test data to assisgn to the property
            decimal TestData = 59.99m;
            //create the data to the property
            AStock.GamePrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.GamePrice, TestData);

        }

        [TestMethod]
        public void StockQtyPropertyOK()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //create some test data to assisgn to the property
            int TestData = 100;
            //create the data to the property
            AStock.StockQty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockQty, TestData);

        }

        [TestMethod]
        public void GameRatingPropertyOK()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //create some test data to assisgn to the property
            int TestData = 8;
            //create the data to the property
            AStock.GameRating = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.GameRating, TestData);

        }

        [TestMethod]
        public void IsDigitalPropertyOK()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //create some test data to assisgn to the property
            bool TestData = true;
            //create the data to the property
            AStock.IsDigital = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.IsDigital, TestData);

        }
    }
}
