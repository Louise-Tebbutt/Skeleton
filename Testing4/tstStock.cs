using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {

        //good test data 
        //create some test data to pass method
        string GameId = "8";
        string GameTitle = "Cyberpunk 2077";
        string GameReleaseDate = DateTime.Now.ToShortDateString();
        string GamePrice = "49.99";
        string StockQty = "50";
        string GameRating = "8";
        string IsDigital = "False";

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
            string TestData = "Cyberpunk 2077";
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameIdFound()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //check the game id 
            if (AStock.GameId != 8)
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameTitleFound()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            string GameTitle = "Cyberpunk 2077";
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //check the game id 
            if (AStock.GameTitle != "Cyberpunk 2077")
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameReleaseDateFound()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //check the game id 
            if (AStock.GameReleaseDate != Convert.ToDateTime("10/12/2022"))
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGamePriceFound()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //check the game id 
            if (AStock.GamePrice != 49.99m)
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockQtyFound()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //check the game id 
            if (AStock.StockQty != 50)
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestGameRatingFound()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //check the game id 
            if (AStock.GameRating != 8)
            {
                OK = false;
            }
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestIsDigitalFound()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //create a Boolean Variable to store th results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int GameId = 8;
            //invoke the method
            Found = AStock.Find(GameId);
            //check the game id 
            if (AStock.IsDigital != false)
            {
                OK = false;
            }

            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //invoke the method 
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMin()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string GameTitle = "a";
            //invoke the method 
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string GameTitle = "aa";
            //invoke the method 
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxLessOne()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string GameTitle = "aaaaa";
            //invoke the method 
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMax()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string GameTitle = "aaaaaa";
            //invoke the method 
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMid()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string GameTitle = "aaa";
            //invoke the method 
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            //create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string GameTitle = "aaaaaaa";
            //invoke the method 
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateExtremeMin()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateMinLessOne()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateMin()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDatePlusOne()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateExtremeMax()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
