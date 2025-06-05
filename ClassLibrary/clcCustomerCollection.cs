using System;
using System.Collections.Generic;
namespace ClassLibrary

{
    public class clcCustomerCollection
    {
        public clcCustomerCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            //varible to show the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the sotred procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of reconrds
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //creates a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the feilds for the current record
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data meber
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
            

        }


        //private data meber for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }
        public int Count 
        { 
            get { return mCustomerList.Count; }
            set
            {
                //we shall worry about this later
            }
        }
       
        public clsCustomer ThisCustomer { get; set; }
    }
}