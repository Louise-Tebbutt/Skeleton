using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            // Create a new instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOk()
        {
            // Create an insatance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Create some test data to assign the property
            List<clsStaff> TestList = new List<clsStaff>();

            // Add an item to the list
            clsStaff TestItem = new clsStaff();

            // Set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Test";
            TestItem.StaffEmail = "Test@example.com";
            TestItem.StaffPhoneNumber = "07517161922";
            TestItem.StaffSalary = 55.05m;
            TestItem.JoinDate = DateTime.Now;
            TestItem.MorePermissions = true;

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign the data to the test property
            AllStaff.StaffList = TestList;

            // Test to see the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisAddressPropertyOk()
        {
            // Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();

            // Set the properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.StaffName = "Test";
            TestStaff.StaffEmail = "Test@example.com";
            TestStaff.StaffPhoneNumber = "07517161922";
            TestStaff.StaffSalary = 55.05m;
            TestStaff.JoinDate = DateTime.Now;
            TestStaff.MorePermissions = true;

            // Assign the data to the property
            AllStaff.ThisStaff = TestStaff;

            // Test to see the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndcountOk()
        {
            // Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Create some test data to assign the property
            List<clsStaff> TestList = new List<clsStaff>();

            // Add an Item to the list
            clsStaff TestItem = new clsStaff();

            // Set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Test";
            TestItem.StaffEmail = "Test@example.com";
            TestItem.StaffPhoneNumber = "07517161922";
            TestItem.StaffSalary = 55.05m;
            TestItem.JoinDate = DateTime.Now;
            TestItem.MorePermissions = true;

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign the data to the property
            AllStaff.StaffList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            // Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Create the item of test data
            clsStaff TestItem = new clsStaff();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Test";
            TestItem.StaffEmail = "Test@example.com";
            TestItem.StaffPhoneNumber = "07517161922";
            TestItem.StaffSalary = 55.05m;
            TestItem.JoinDate = DateTime.Now;
            TestItem.MorePermissions = true;

            // Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;

            // Add the record
            PrimaryKey = AllStaff.Add();

            // Set the primary key of the test data
            TestItem.StaffId = PrimaryKey;

            // Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);

            // Test to see the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            // Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Create the item of test data
            clsStaff TestItem = new clsStaff();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.StaffName = "Test";
            TestItem.StaffEmail = "Test@example.com";
            TestItem.StaffPhoneNumber = "07517161922";
            TestItem.StaffSalary = 55.05m;
            TestItem.JoinDate = DateTime.Now;
            TestItem.MorePermissions = true;

            // Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;

            // Add the record
            PrimaryKey = AllStaff.Add();

            // Set the primary key of the test data
            TestItem.StaffId = PrimaryKey;

            // Modify the test record
            TestItem.StaffName = "TestUpdated";
            TestItem.StaffEmail = "TestUpdated@example.com";
            TestItem.StaffPhoneNumber = "07517100200";
            TestItem.StaffSalary = 44.05m;
            TestItem.JoinDate = DateTime.Now;
            TestItem.MorePermissions = false;

            // Set the record based on the new test data
            AllStaff.ThisStaff = TestItem;

            // Update the record
            AllStaff.Update();

            // Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);

            // Test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            // Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Create the item of test data
            clsStaff TestItem = new clsStaff();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Test";
            TestItem.StaffEmail = "Test@example.com";
            TestItem.StaffPhoneNumber = "07517161922";
            TestItem.StaffSalary = 55.05m;
            TestItem.JoinDate = DateTime.Now;
            TestItem.MorePermissions = true;

            // Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;

            // Add the record
            PrimaryKey = AllStaff.Add();

            // Set the primary key of the test data
            TestItem.StaffId = PrimaryKey;

            // Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);

            // Delete the record
            AllStaff.Delete();

            // Now find the record
            Boolean found = AllStaff.ThisStaff.Find(PrimaryKey);

            // Test to see that the record was not found
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ReportByStaffNameMethodOk()
        {
            // create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            // Apply a blank string (should return all records)
            FilteredStaff.ReportByStaffName("");

            // Test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffNameNoneFound()
        {
            // Create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            // Apply a staff name that doesnt exist
            FilteredStaff.ReportByStaffName("xxxx xxxx");

            // Test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffNameTestDataFound()
        {
            // Create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            // Variable to store the outcome
            Boolean OK = true;

            // Apply a staff name that does exist
            FilteredStaff.ReportByStaffName("John Doe");

            // Check that the correct number of records are found
            if (FilteredStaff.Count == 1)
            {
                // Check to see that the record is 1
                if (FilteredStaff.StaffList[0].StaffId != 1)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
