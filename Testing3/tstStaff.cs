﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        // Good test data
        string StaffName = "Jane Doe";
        string JoinDate = DateTime.Now.ToShortDateString();
        string StaffEmail = "JaneDoe@example.com";
        string StaffPhoneNumber = "09876543219";
        string StaffSalary = "44.04";
        string MorePermissions = "False";

        [TestMethod]
        public void InstanceOk()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Test to see if it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffIdOk()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign to the property
            Int32 TestData = 1;

            // Assign the data to the property
            AnStaff.StaffId = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);

        }

        [TestMethod]
        public void StaffNameOk()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign the property
            string TestData = "TestName";

            // Assign the data to the property
            AnStaff.StaffName = TestData;

            // Test to see the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);

        }

        [TestMethod]
        public void JoinDateOk()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;

            // Assign the data to the property
            AnStaff.JoinDate = TestData;

            // Test to see the two values are the same
            Assert.AreEqual(AnStaff.JoinDate, TestData);

        }

        [TestMethod]
        public void MorePermissionsOk()
        {
            // reate an instance of the class we  want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign the property
            Boolean TestData = true;

            // Assign the data to the property
            AnStaff.MorePermissions = TestData;

            // Test to see the two values are the same
            Assert.AreEqual(AnStaff.MorePermissions, TestData);
        }

        [TestMethod]
        public void StaffEmailOk()
        {
            // reate an instance of the class we  want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign the property
            String TestData = "Test Email";

            // Assign the data to the property
            AnStaff.StaffEmail = TestData;

            // Test to see the two values are the same
            Assert.AreEqual(AnStaff.StaffEmail,TestData);
        }

        [TestMethod]
        public void StaffPhoneNumberOk()
        {
            // reate an instance of the class we  want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign the property
            String TestData = "Test Phone Number";

            // Assign the data to the property
            AnStaff.StaffPhoneNumber = TestData;

            // Test to see the two values are the same
            Assert.AreEqual(AnStaff.StaffPhoneNumber, TestData);
        }

        [TestMethod]
        public void StaffSalaryOk()
        {
            // create an instance of the class we  want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign the property
            Decimal TestData = 1;

            // Assign the data to the property
            AnStaff.StaffSalary = TestData;

            // Test to see the two values are the same
            Assert.AreEqual(AnStaff.StaffSalary, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Test to see if the result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create a Boolean variable to record if the data is Ok
            Boolean OK = true;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffId != 2)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create a Boolean variable to record if the data is Ok
            Boolean OK = true;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffName != "Jane Doe")
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJoinDateFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create a Boolean variable to record if the data is Ok
            Boolean OK = true;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.JoinDate != Convert.ToDateTime("05/05/2005"))
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMorePermissionsFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create a Boolean variable to record if the data is Ok
            Boolean OK = true;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.MorePermissions != false)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create a Boolean variable to record if the data is Ok
            Boolean OK = true;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffEmail != "JaneDoe@example.com")
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNumberFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create a Boolean variable to record if the data is Ok
            Boolean OK = true;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffPhoneNumber != "09876543219")
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffSalaryFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            Boolean found = false;

            // Create a Boolean variable to record if the data is Ok
            Boolean OK = true;

            // Create some test data to use within the method
            Int32 StaffId = 2;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffSalary != 44.04m)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // String vairable to store error messages
            string Error = "";

            // Invoke the method
            Error = AnStaff.Valid(StaffSalary, StaffName, JoinDate, StaffEmail, StaffPhoneNumber, MorePermissions);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // String c=variable to store any error message
            string Error = "";

            // Create some test data to pass to the method
            string StaffSalary = "0";

            // Invoke the method
            Error = AnStaff.Valid(StaffSalary, StaffName, JoinDate, StaffEmail, StaffPhoneNumber, MorePermissions);

            // Test to see that the result is correct
            Assert.AreNotEqual("" ,Error);

        }

        [TestMethod]
        public void StaffSalaryMin()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // String variable to store an error messages
            string Error = "";

            // Create some test data to pass to the method
            string StaffSalary = "0.01";

            // Invoke the method
            Error = AnStaff.Valid(StaffSalary, StaffName, JoinDate, StaffEmail, StaffPhoneNumber, MorePermissions);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string StaffSalary = "1.00";

            // Invoke the method
            Error = AnStaff.Valid(StaffSalary, StaffName, JoinDate, StaffEmail, StaffPhoneNumber, MorePermissions);

            // Test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass the method
            string StaffSalary = "999999999.99";

            // Invoke the method
            Error = AnStaff.Valid(StaffSalary, StaffName, JoinDate, StaffEmail, StaffPhoneNumber, MorePermissions);

            // Test to see the result is correct
            Assert.AreNotEqual(Error, "");


        }
    }
}
