using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            ClsOrder AnOrder = new ClsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            AnOrder.Active = TestData;
            //Test to see that two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOk()
        {
            //create an instance of the class we want to create 
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values 
            Assert.AreEqual(TestData, AnOrder.DateAdded);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create 
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Int32 TestData = 123;
            // Assign the data to the property
            AnOrder.CustomerId = TestData;
            //Test to see that two valuses are the same 
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOk()
        {
            //Create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            // Create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            // Assign data to the property
            AnOrder.OrderDate = TestData;
            //Test to see that two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            // Create some test data to assign to the property
            decimal TestData = 99.99m;
            // Assign the data to the property
            AnOrder.TotalAmount = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void PaymentStatusPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            // Create some test data to assign to the property
            Boolean TestData = true;
            // Assign the data to the property
            AnOrder.PaymentStatus = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentStatus, TestData);
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            // Create some test data to assign to the property
            string TestData = "Leicester";
            // Assign the data to the property
            AnOrder.ShippingAddress = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            // Create some test data to assign to the property
            Int32 TestData = 789;
            // Assign the data to the property
            AnOrder.StaffId = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }


    }
}



