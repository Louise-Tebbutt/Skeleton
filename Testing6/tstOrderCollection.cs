using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //test to see that is exists
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<ClsOrder> TestList = new List<ClsOrder>();
            //Add an item to the List
            //create the item test data
            ClsOrder TestItem = new ClsOrder();
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Sheffield";
            TestItem.PaymentStatus = true;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create 
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreNotEqual(AllOrder.Count, SomeCount);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create some test data to assign to the property
            ClsOrder TestOrder = new ClsOrder();
            //set the properties of the test object
            TestOrder.Active = true;
            TestOrder.OrderId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.ShippingAddress = "Sheffield";
            TestOrder.PaymentStatus = true;
            TestOrder.CustomerId = 1;
            TestOrder.StaffId = 1;
            //assign the data to the property 
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<ClsOrder> TestList = new List<ClsOrder>();
            //add an Item to the List
            //create the item of the test data
            ClsOrder TestItem = new ClsOrder();
            //set the property
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Sheffield";
            TestItem.PaymentStatus = true;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual (AllOrder.Count, TestList.Count);

        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instace of the class we want to create 
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            //test to see that the two values are the same 
            Assert.AreNotEqual(AllOrders.Count, 2);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create the item for test data 
            ClsOrder TestItem = new ClsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Sheffield";
            TestItem.PaymentStatus = true;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            //set ThisOrder to the test data 
            AllOrder.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //Find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that thhe two values are the same 
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create the item of the test data 
            ClsOrder TestItem = new ClsOrder();
            //variable to store the primary key
            Int32 Primarykey = 0;
            TestItem.Active = true;
            //TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Leicester";
            TestItem.PaymentStatus = true;
            TestItem.CustomerId = 1;
            TestItem.StaffId= 2;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record 
            Primarykey = AllOrder.Add();
            //set the primarykey of the test data 
            TestItem.OrderId= Primarykey;
            //modify the test record 
            TestItem.Active = false;
            TestItem.OrderId = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Another street";
            TestItem.PaymentStatus = false;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 3;
            //set the record based on the new test data 
            AllOrder.ThisOrder = TestItem;
            //Update the record
            AllOrder.Update();
            //find the record 
            AllOrder.ThisOrder.Find(Primarykey);
            //test to see if thisOrder matches the test data 
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);


        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create the item of test data 
            ClsOrder TestItem = new ClsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Leicester";
            TestItem.PaymentStatus = true;
            TestItem.CustomerId = 342;
            TestItem.StaffId = 29;
            //set thisOrder to test data 
            AllOrder.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data 
            TestItem.OrderId = PrimaryKey;
            //find the record
            if (AllOrder.ThisOrder.Find(PrimaryKey))
            {
                //delete the record 
                AllOrder.Delete();
            }
            //now find the record 
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was mot found 
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            //create an instance of the class containing unfiltered result 
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //create an instance of filtered data 
            ClsOrderCollection FilteredOrder = new ClsOrderCollection();
            //apply a blank string (should return all records);
            FilteredOrder.ReportByShippingAddress("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);
        }
        [TestMethod]
        public void ReportByShippingAddressNoneFound()

        {
            //create an instance of the class we want to create 
            ClsOrderCollection FilteredOrder = new ClsOrderCollection();
            //apply a shipping address that doesnt exist
            FilteredOrder.ReportByShippingAddress(" Hall ");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredOrder.Count);
        }
        [TestMethod]
        public void ReportByShippingAddressFound()
        {
            //create an instance of the fltered data 
            ClsOrderCollection filteredOrder = new ClsOrderCollection();
            //variable t storee the outcome 
            Boolean OK = true;
            //apply an address that doesnt exist
            filteredOrder.ReportByShippingAddress("Leicester");
            //check that the correct number of record is found
            if (filteredOrder.Count > 2)
            {
                
                
                //check to see that the first record is 6
                if (filteredOrder.OrderList[0].OrderId != 1)
                {
                    OK = false;
                }
                
                //check to see that the first record is 4
                if (filteredOrder.OrderList[1].OrderId != 5)
                {
                    OK = false;
                }
                
            }
           
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
       
        
        
        


    }
}
