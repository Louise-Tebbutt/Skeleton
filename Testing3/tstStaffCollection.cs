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
    }
}
