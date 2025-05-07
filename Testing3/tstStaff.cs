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
        public void MorePermissions()
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
        public void StaffEmail()
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
        public void StaffPhoneNumber()
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
        public void StaffSalary()
        {
            // reate an instance of the class we  want to create
            clsStaff AnStaff = new clsStaff();

            // Create some test data to assign the property
            float TestData = 1;

            // Assign the data to the property
            AnStaff.StaffSalary = TestData;

            // Test to see the two values are the same
            Assert.AreEqual(AnStaff.StaffSalary, TestData);
        }
    }
}
