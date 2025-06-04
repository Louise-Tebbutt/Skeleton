using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 3;
            TestItem.Email = "AshokaTano@outlook.com";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FullName = "Plo Koon";
            TestItem.Address = "501 Anakin Stret";
            TestItem.PhoneNumber = "1234567890";
            TestItem.Active = true;
            //addd the item to the test list
            mCustomerList.Add(TestItem);
            //re instilaise the object for some data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 4;
            TestItem.Email = "ObiWanKennobi@outlook.com";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.FullName = "Rey Skywalker";
            TestItem.Address = "212 Kennobi Street";
            TestItem.PhoneNumber = "1234567890";
            TestItem.Active = true;
            //addd the item to the test list
            mCustomerList.Add(TestItem);
        }
        //private data meber for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count 
        {
            get 
            { 
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        
    }
}
