using System;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class ClsOrder
    {

        //private data member for the OrderId property
        private Int32 mOrderId;
        private DateTime mDateAdded;
        private decimal mTotalAmount;
        private int mStaffId;
        private bool mPaymentStatus;
        private string mShippingAddress;
        private int mCustomerId;
        private DateTime mOrderDate;
        private bool mActive;

        //dateAdded public property

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //line allows code to send data out of property
                return mOrderId;
            }
            set
            {
                //this line of code allows into the property
                mOrderId = value;
            }
        }
        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
               
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

         public decimal TotalAmount

        {
            get
            {
                return mTotalAmount;

            }
            set
            {
                mTotalAmount = value;

            }
        }
     
        
       
        public bool PaymentStatus
        {
            get
            {
                return mPaymentStatus;
            }
            set
            {
                mPaymentStatus = value;
            }
        }
       
        
        public string ShippingAddress
        {
            get
            {
                return mShippingAddress;
            }
            set
            {
                mShippingAddress = value;
            }
        }
        public int StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        public bool Find(int orderId)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderId to search for
            DB.AddParameter("@OrderId", OrderId);
            //Excecute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record id found (should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mPaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentStatus"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            // if no record was found 
            else
            {
                return false;
            }
        
       
        }
        // function for the public validation method
        public string Valid(string OrderId,
                            string CustomerId,
                            string Orderdate,
                            string Totalamount,
                            string Paymentstatus,
                            string Shippingaddress,
                            string StaffId);
        
        

       

        }
    }
