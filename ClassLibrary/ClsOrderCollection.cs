using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class ClsOrderCollection

    {
        
        //public data member for the list 
        List<ClsOrder> mOrderList = new List<ClsOrder>();
        ClsOrder mThisOrder = new ClsOrder();
        
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
    
        public ClsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
            
            
               
    

        public ClsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
            
            
        }
   

        public int Add()
        {
            //add a record to the database based on the value of mOrder
            //set the primary key of the new record 

            /*
            mThisOrder.OrderId = 123;
            //return the primary key of the new record 
            return mThisOrder.OrderId;
            */
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Orderdate", mThisOrder.OrderDate);
            DB.AddParameter("@Totalamount", mThisOrder.TotalAmount);
            DB.AddParameter("@Paymentstatus", mThisOrder.PaymentStatus);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@Active", mThisOrder.Active);
            return DB.Execute("sproc_tblOrder_Insert");


            // throw new NotImplementedException();
        }

        public void Update()
        {
            //update an excisting record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the new stored procedure 
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Orderdate", mThisOrder.OrderDate);
            DB.AddParameter("@Totalamount", mThisOrder.TotalAmount);
            DB.AddParameter("@Paymentstatus", mThisOrder.PaymentStatus);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.Execute("sproc_tblOrder_Update");

           // throw new NotImplementedException();
        }

        public void Delete()
        {
            //delete the record pointed to by thisOrder
            //connect to database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Delete");
           // throw new NotImplementedException();
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            //filters the records based on a full or partial address
            //connect to database 
            clsDataConnection DB = new clsDataConnection();
            //send the ShippingAddress parameter to the database 
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            //excecute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterbyShippingAddress");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the datatable in the parameter DB
            //variable for the index 
            Int32  Index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<ClsOrder>();
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank address object 
                ClsOrder AnOrder = new ClsOrder();
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);

                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);

                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.PaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentStatus"]);
                //add the record to the private data memeber 
                mOrderList.Add(AnOrder);
                //point at the next record 
                Index++;
            }

            Count = Index;
        }

    }
    
   
    
}