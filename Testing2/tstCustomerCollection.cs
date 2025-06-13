﻿using System;
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
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = 3;
            TestItem.Email = "ObiWanKennobi@outlook.com";
            TestItem.FullName = "ObiWan Kennobi";
            TestItem.Address = "212th Kennobi Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Active = true;
            //set ThisCustomer to the test item
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Email = "ObiWanKennobi@outlook.com";
            TestItem.FullName = "ObiWan Kennobi";
            TestItem.Address = "212th Kennobi Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Active = true;
            //set ThisCustomer to the test item
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test record
            TestItem.Email = "CodyFett@outlook.com";
            TestItem.FullName = "Cody Fett";
            TestItem.Address = "212th Cody Street";
            TestItem.PhoneNumber = "1234237890";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Active = true;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = 3;
            TestItem.Email = "ObiWanKennobi@outlook.com";
            TestItem.FullName = "ObiWan Kennobi";
            TestItem.Address = "212th Kennobi Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Active = true;
            //set ThisCustomer to the test item
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            //create an instance of the class containing unfilitered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByCustomerName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a name that doesn't exist
            FilteredCustomers.ReportByCustomerName("xxx xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
    }
}
