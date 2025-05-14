using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
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
            float TestData = 1;

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
            Int32 StaffId = 1;

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
            Int32 StaffId = 1;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffId != 1)
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
            Int32 StaffId = 1;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffName != "John Doe")
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
            Int32 StaffId = 1;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.JoinDate != Convert.ToDateTime("01/01/2000"))
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
            Int32 StaffId = 1;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.MorePermissions != true)
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
            Int32 StaffId = 1;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffEmail != "JohnDoe@email.com")
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
            Int32 StaffId = 1;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffPhoneNumber != "05555111999")
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
            Int32 StaffId = 1;

            // Invoke the method
            found = AnStaff.Find(StaffId);

            // Check the StaffId
            if (AnStaff.StaffSalary != 11.11F)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
