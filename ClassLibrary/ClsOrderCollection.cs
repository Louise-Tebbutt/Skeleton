using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsOrderCollection
    {
        public List<ClsOrder> OrderList
        {
            get
            {
                //return the private data 
                return mOrderList;
            }
            set
            {
                //return the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //
            }
        }
        public ClsOrderCollection()
        {
            //create the items of the data
            ClsOrder TestItem = new ClsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Sheffield";
            TestItem.PaymentStatus = true;
            TestItem.CustomerId = 1;
            //add the test item to the test list
            mOrderList.Add(TestItem);
            // re initialise the object for some new data
            TestItem = new ClsOrder();
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "Sheffield";
            TestItem.PaymentStatus = true;
            TestItem.CustomerId = 1;
            //add the item to the test list
            mOrderList.Add(TestItem) ;
            //variable for the index 
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount = 0;
            //omject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //excecute the stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                ClsOrder AnOrder = new ClsOrder();
                //read in the fields for the current record 
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.PaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentStatus"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                //add the record to the private data member 
                mOrderList.Add (AnOrder);
                //point at the next record 
                Index++;
            }
        }

        public ClsOrder ThisOrder { get; set; }
        //private data member for the list
        List<ClsOrder> mOrderList = new List<ClsOrder>();
    }
    
}