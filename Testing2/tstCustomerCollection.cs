using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 3;
            TestItem.Email = "ObiWanKennobi@outlook.com";
            TestItem.FullName = "ObiWan Kennobi";
            TestItem.Address = "212th Kennobi Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instnace of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerNo = 3;
            TestCustomer.Email = "ObiWanKennobi@outlook.com";
            TestCustomer.FullName = "ObiWan Kennobi";
            TestCustomer.Address = "212th Kennobi Street";
            TestCustomer.PhoneNumber = "1234567890";
            TestCustomer.DateOfBirth = DateTime.Now;
            TestCustomer.Active = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 3;
            TestItem.Email = "ObiWanKennobi@outlook.com";
            TestItem.FullName = "ObiWan Kennobi";
            TestItem.Address = "212th Kennobi Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an insantce of the class we wnat to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, 2);
        }
    }
}
