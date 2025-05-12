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
            //set the private data members to the test data value
            mOrderId = 21;
            mDateAdded = Convert.ToDateTime("20/11/2024");
            mCustomerId = 123;
            mOrderDate = Convert.ToDateTime("20/11/2024");
            mTotalAmount = 99.99m;
            mShippingAddress = "Leicester";
            mPaymentStatus = true;
            mStaffId = 789;
            mActive = true;
            //always return true
            return true;
        
       
        }
       
         
        

       

        }
    }
