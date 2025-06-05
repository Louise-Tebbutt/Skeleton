using System;
using System.Data;
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
        public void GameTitleExtremeMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(0, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameTitleMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(0, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameTitleMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(1, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(2, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameTitleMid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameTitleMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameTitleExtremeMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(500, 'a');
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameTitleInvalid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameTitle = "123456";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
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
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to more than 100 years ago
            TestDate = TestDate.AddYears(-101);
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
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to 100 years ago minus 1 day
            TestDate = TestDate.AddYears(-100).AddDays(-1);
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
            //set the date to exactly 100 years ago
            TestDate = DateTime.Now.Date.AddYears(-100);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateMinPlusOne()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to 100 years ago plus 1 day
            TestDate = DateTime.Now.Date.AddYears(-100).AddDays(1);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateToday()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateMaxLessOne()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to one day before today
            TestDate = DateTime.Now.Date.AddDays(-1);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateMax()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to tomorrow (future date)
            TestDate = DateTime.Now.Date.AddDays(1);
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
            //set the date to far future (100 years from now)
            TestDate = DateTime.Now.Date.AddYears(100);
            //convert the date variable to a string variable
            string GameReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameReleaseDateInvalid()
        {
            //Create an instance of the class we want to create 
            ClsStock AStock = new ClsStock();
            //string variable to store any error message 
            string Error = "";
            //this should fail (invalid data type)
            string GameReleaseDate = "not a date";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GamePriceExtremeMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GamePrice = "-1000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GamePriceMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GamePrice = "0";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GamePriceMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GamePrice = "0.01";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GamePriceMid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GamePrice = "500.00";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GamePriceMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GamePrice = "999.99";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GamePriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GamePrice = "-1";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GamePriceExtremeMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GamePrice = "1000000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GamePriceInvalid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GamePrice = "free";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void StockQtyExtremeMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string StockQty = "-1000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StockQtyMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string StockQty = "-1";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StockQtyMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string StockQty = "0";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StockQtyMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string StockQty = "1";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StockQtyMid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string StockQty = "5000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StockQtyMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string StockQty = "9999";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StockQtyMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string StockQty = "10000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StockQtyMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string StockQty = "10001";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StockQtyExtremeMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string StockQty = "50000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StockQtyInvalid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string StockQty = "many";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void GameRatingExtremeMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameRating = "-1000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameRatingMinLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameRating = "0";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameRatingMin()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameRating = "1";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameRatingMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameRating = "2";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameRatingMid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameRating = "5";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameRatingMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameRating = "9";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameRatingMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string GameRating = "10";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void GameRatingMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameRating = "11";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameRatingExtremeMax()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameRating = "1000";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void GameRatingInvalid()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string GameRating = "great";
            //invoke the method
            Error = AStock.Valid(GameTitle, GameReleaseDate, GamePrice, StockQty, GameRating, IsDigital);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void StatStatisticsGroupedByGameReleaseDate()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();

            //invoke the method
            DataTable dT = AStock.StatisticsGroupedByGameReleaseDate();

            //According to the last executed stored procedure, there should be X rows of data.
            int noOfRecord = 11; // <-- change this to match your database result

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedByGameTitle()
        {
            //create an instance of the class we want to create
            ClsStock AStock = new ClsStock();

            //invoke the method
            DataTable dT = AStock.StatisticsGroupedByGameTitle();

            //According to the last executed stored procedure, there should be X rows of data.
            int noOfRecord = 12; // <-- change this to match your database result

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}
