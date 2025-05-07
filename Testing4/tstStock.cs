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
            Assert.AreEqual(Astock.GameId,TestData);
        }
       

        [TestMethod]
        public void GameTitlePropertyOK()
        {
            //create an instance of the class we want to create 
            ClsStock Astock = new ClsStock();
            //create some test data to assign to the property 
            Astock.GameTitle = "Elden Ring";
            //create the data to the property 
            Astock.GameTitle = TestData;
            //test to see that the twi values are the same
            Assert.AreEqual(Astock.GameTitle, TestData);

        }

        [TestMethod]
        public void GameReleaseDatePropertyOK()
        {
            //create an instance of the class we want to create 
            ClsStock Astock = new ClsStock();
            //create some test data to assisgn to the property
            Astock.GameReleaseDate =
        }




    }
}
