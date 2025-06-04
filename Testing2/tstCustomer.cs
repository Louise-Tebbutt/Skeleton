using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class TstCustomer
    {

        //good test data
        //test data to pass the method
        int CustomerNo = 7;
        string Email = "ShmiSkywalker@outlook.com";
        string DateOfBirth = DateTime.Now.ToShortDateString();
        string FullName = "AvarKriss";
        string Address = "212 Kennobi street";
        string PhoneNumber = "07836208634";


        public clsCustomer AnCustomer { get; private set; }
        public clsCustomer clsCustomer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instnace of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void CustomerNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some data to assign to a property
            int TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);

        }
        [TestMethod]
        public void EmailOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some data to assign to a property
            string TestData = "ObiwanKennobi@outlook.com";
            //asign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void DateOfBirthOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some data to assign to a property
            DateTime TestData = new DateTime(2012, 5, 25);
            //assign the data to the property
            AnCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void FullNameOk()
        {
            //create an insantace of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some data to assign to a property
            string TestData = "Anakin Skywalker";
            //assign the data to the property
            AnCustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FullName, TestData);
        }
        [TestMethod]
        public void AddressOk()
        {
            //create an instnace of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some data to assign to the property
            string TestData = "212 Jedi Street";
            //assign the data to the propery
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }
        [TestMethod]
        public void PhoneNumberOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some data to assign to the property
            string TestData = "512122212";
            //assign the data to the property 
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual (AnCustomer.PhoneNumber, TestData);
        }
        [TestMethod]
        public void ActiveOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some data to assign to the property
            bool TestData = false;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of what we want to create
            clsCustomer = AnCustomer = new clsCustomer();
            //create a Boolean varibale to store the restult of the validiation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerID = 5;
            //invoke method
            Found = AnCustomer.Find(CustomerID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check address ID
            if (AnCustomer.CustomerNo != 7)
            {
               OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmail()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check Email
            if(AnCustomer.Email != "AnakinSkwyalker@outlook.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirth()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the DateOfBirth property
            if(AnCustomer.DateOfBirth != Convert.ToDateTime("23/08/2005"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFullName()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the data of fullname property
            if(AnCustomer.FullName != "Anakin Skywalker")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddress()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the data of Address property
            if(AnCustomer.Address != "212 Jedi Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumber()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the data of the PhoneNumber property
            if(AnCustomer.PhoneNumber != "07836208634")
            {
                OK = false;
            }
            //test to see if the reulst is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActive()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the data of the Active property
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFind()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is okay
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the data in all the properties
            if (AnCustomer.Email != "AnakinSkwyalker@outlook.com"
                && AnCustomer.DateOfBirth != Convert.ToDateTime("23/08/2005")
                && AnCustomer.FullName != "AnakinSkywalker"
                && AnCustomer.Address != "212 Jedi Street"
                && AnCustomer.PhoneNumber != "07836208634"
                && AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke method 
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address);
            //test to see that the result is correct
            AssertAreEqual (Error, "");
        }

        private string AssertAreEqual(string error, string v)
        {
            return "";
        }


        //Email boundary tests
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see if that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the mthod
            string Email = "a"; //this should be okay
            //imvoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "an"; //this should be okay
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "anakinSkywalker@outlook.comanakinSkywalker@outloo"; //this should be okay
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "anakinSkywalker@outlook.comanakinSkywalker@outlook"; //this should be okay
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "anakinSkywalker@outlook.c"; //this should be okay
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "anakinSkywalker@outlook.comanakinSkywalker@outlook."; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //DateOfBirth boundary tests
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1000 years
            TestDate = TestDate.AddYears(-1000);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years less 1 day
            TestDate = TestDate.AddYears(-100).AddDays(-1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years plus 1 day
            TestDate = TestDate.AddYears(-100).AddDays(1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 50 years
            TestDate = TestDate.AddYears(-50);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtemeMax()
        {
            //create a new insance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1000 years
            TestDate = TestDate.AddYears(1000);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to  a non date value
            string DateOfBirth = "this is not a date";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinMinusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to an empty string
            string FullName = "";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin() 
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string wiht one character
            string FullName = "A";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne() 
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string wiht two characters
            string FullName = "An";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string FullName = "AnakinSkywalkerObiWanKenn";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string FullName = "";
            FullName = FullName.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string FullName = "";
            FullName = FullName.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string FullName = "";
            FullName = FullName.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinMinusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "2";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "21";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "";
            Address = Address.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FullName to a string with 25 characters
            string Address = "";
            Address = Address.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to a empty string
            string PhoneNumber = "";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to a string with 1 character
            string PhoneNumber = "2";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to string with 2 characters
            string PhoneNumber = "21";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to string with 7 characters
            string PhoneNumber = "2125012";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to string with 14 characters
            string PhoneNumber = "21250121250121";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to straing with 15 characters
            string PhoneNumber = "21250121250121";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to staring of 16 characters
            string PhoneNumber = "2125012125012150";
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtreameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the PhoneNumber to a straing with 50 characters
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Email, DateOfBirth, FullName, Address, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
    }
}
