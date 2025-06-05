using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq.Expressions;
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
            DB.AddParameter("@OrderId", orderId);
            //Excecute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record id found (should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
               // mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]); 
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);

                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);

                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mPaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentStatus"]);
               
                //mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            // if no record was found 
            else
            {
                return false;
            }


        }

       public void Find(ClsOrderCollection orderId)
        {
        // throw new NotImplementedException();
       }


        // function for the public validation method

        public string Valid(string customerId,
                            string orderdate,
                            string totalamount,
                            string paymentstatus,
                            string shippingaddress)


        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //if the CustomerId is blank
            if (customerId.Length == 0)

            {
                //record the error 
                Error = Error + "The Customer Id must not be blank : ";

            }
            // if the customer Id is greater than 6 characters
            if (customerId.Length > 6)
            {
                //record the error
                Error = Error + "The Customer Id must be less than 6 characters : ";
            }
            //copy the Orderdate value to the datetemp value
            DateTemp = Convert.ToDateTime(orderdate);
            
            double AmountTemp;
            {
                AmountTemp = Convert.ToDouble(totalamount);
                if (AmountTemp < 0.01)
                {
                    Error = Error + "The total amount will be at least 0.01 : ";
                }
                if(AmountTemp > 1000.00)
                {
                    Error = Error + "The total amount must not exceed 1000.00 : ";
                }
               
                if(shippingaddress.Length == 0)
                {
                    Error = Error + "The shipping address must not be blank : ";
                }
                if (shippingaddress.Length > 9)
                {
                    Error = Error + "The shipping address must be less than or equal to 9 characters : ";
                }
                
                
                

            }
            
            
           

            // Return an error message 
            return Error;


        }


        public string Valid(string OrderId,
                            string CustomerId,
                            string Orderdate,
                            string Totalamount,
                            string Paymentstatus,
                            string Shippingaddress,
                            string StaffId)
        {
            return "";
        }
        
        

       


        
        public DataTable StatisticsGroupedByShippingAddress()
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Count_GroupByShippingAddress");
            // There should be either zero, one or more records 
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedOrderDate()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_Count_GroupOrderDate");
            return DB.DataTable;
        }

    }
}
