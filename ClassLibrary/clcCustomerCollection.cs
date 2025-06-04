using System;
using System.Collections.Generic;
namespace ClassLibrary

{
    public class clcCustomerCollection
    {
        public clcCustomerCollection() 
        {
            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 5;
            TestItem.Email = "AshokaTano@outlook.com";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FullName = "AshokaTanno";
            TestItem.Address = "112 Ahsoka Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.Active = true;
            //add the test item to the test list
            mCustomerList.Add(TestItem);

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