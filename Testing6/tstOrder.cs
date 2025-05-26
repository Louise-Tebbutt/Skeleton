using System;
using System.IO;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass the method
        string OrderId = "2";
        string CustomerId = "567";
        string Orderdate = DateTime.Now.ToShortDateString();
        string Totalamount ="99.99";
        string Paymentstatus = "true";
        string Shippingaddress = "Leicester";
        string StaffId ="789";
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
            Int32 TestData = 2;
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
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //Test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance for the class we wanna create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
           Int32 OrderId = 2;
            //invoke the method
           Found = AnOrder.Find(OrderId);
            //check the Order Id
           if (AnOrder.OrderId != 2)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the active property
            if (AnOrder.Active != false)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the customer id property
            if (AnOrder.CustomerId != 567)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order date property
            if (AnOrder.OrderDate != Convert.ToDateTime("12/11/2023"))
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the total amount property
            if (AnOrder.TotalAmount != 87.23m)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestPaymentStatusFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the payment status property
            if (AnOrder.PaymentStatus != true)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestShippingAddressFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the shipping address property
            if (AnOrder.ShippingAddress.Trim() != "Sheffield")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the staff id property
            if (AnOrder.StaffId != 13)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the class we need 
            ClsOrder AnOrder = new ClsOrder();
            //string c=variable stores any error message 
            String Error = "";
            //create some test data to pass the method 
            String CustomerId = ""; // this should trigger an error 
            //Invoke the method
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMin()
        {
            //create an instance for the class we want to create 
            ClsOrder AnOrder = new ClsOrder();
            //StriNg variable to store any error 
            String Error = "";
            //create some test data to pass the method
            String CustomerId = "a"; // this ok 
            //invoke the methof 
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            //test to see that the test result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            String CustomerId = "aa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            String CustomerId = "aaaaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            String CustomerId = "aaaaaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            String CustomerId = "aaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            String CustomerId = "aaaaaaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            String CustomerId = "";
            CustomerId = CustomerId.PadRight(500, 'a');
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderdateExtremeMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderdateMinLessOne()
        {
            //create an instance of the class we want to create 
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            //String variable to store the test data date 
            DateTime TestDate;
            //change the date totodays time 
            TestDate = DateTime.Now.Date;
            //convert the date to  whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            // test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderdateMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderdateMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderdateExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderdateInvalidData()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            
            //set the orderdate to a non data value
            string DateAdded = "This is not a date!";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            //create an instance of the class we want to create 
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string ShippingAddress = "";
            //invoke the method 
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "a";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "aa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaaaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaaaaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaaaaaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "aaaa";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TotalAmount = 0.01;
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TotalAmount = 1.01;
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TotalAmount = 5000.00;
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TotalAmount = 9999.99;
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TotalAmount = 1000.00;
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            double TotalAmount = 1000.01;
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, Paymentstatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentStatusMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string PaymentStatus = "0";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, PaymentStatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentStatusMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string PaymentStatus = "1";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, PaymentStatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentStatusMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string PaymentStatus = "1";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, PaymentStatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentStatusMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string PaymentStatus = "0";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, PaymentStatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentStatusMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string PaymentStatus = "1";
            Error = AnOrder.Valid(CustomerId, Orderdate, Totalamount, PaymentStatus, Shippingaddress);
            Assert.AreEqual(Error, "");
        }

    }

}



 