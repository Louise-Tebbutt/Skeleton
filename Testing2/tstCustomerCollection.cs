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
        public object clsCustomerCollection { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clcCustomerCollection AllCustomer = new clcCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clcCustomerCollection AllCustomer = new clcCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create an item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 5;
            TestItem.Email = "AshokaTano@outlook.com";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FullName = "AshokaTanno";
            TestItem.Address = "112 Ahsoka Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are teh same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        public void ListAndCountOK()
        {
            //create an instnace of the class we wnat to create
            clcCustomerCollection AllCustomer = new clcCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 5;
            TestItem.Email = "AshokaTano@outlook.com";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FullName = "AshokaTanno";
            TestItem.Address = "112 Ahsoka Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.Active = true;
            //add tem to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two vlaues are the same
            Assert.AreEqual (AllCustomer.CustomerList.Count, TestList.Count);
        }
    }
}
