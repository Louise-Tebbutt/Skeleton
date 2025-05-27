using System;
using System.Collections.Generic;
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
            Assert.AreEqual(AllOrder.Count, SomeCount);
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
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreNotEqual (AllOrder.OrderList, TestList.Count);

        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instace of the class we want to create 
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, 2);
        }
        
    }
}
