using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of the class
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the cusomterNo
        int CustomerNo = int.Parse(txtCustomer.Text);
        //Capture the Email
        string Email = txtEmail.Text;
        //capture the dateOfBirth
        string DateOfBirth = txtDateOfBirth.Text;
        //capture the fullname
        string FullName = txtFullName.Text;
        //capture the address
        string Address = txtAddress.Text;
        //capture the PhoneNumber
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the active stuff
        bool Active = cbActive.Checked;
        Session["AnCustomer"] = AnCustomer;
        //variale to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerNo, Email, DateOfBirth, FullName, Address, PhoneNumber);
        if (Error == "")
        {
            //capture the customer number 
            AnCustomer.CustomerNo = CustomerNo;
            //capture the email
            AnCustomer.Email = Email;
            //capture the date of birth
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture the full name
            AnCustomer.FullName = FullName;
            //caapture the address
            AnCustomer.Address = Address;
            //capture the phone number
            AnCustomer.Address = Address;
            //capture the active stuff
            AnCustomer.Active = Active;
        }
        //navigate to view page
        Response.Redirect("CustomersViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerNo;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomer.Text);
        //find the record
        Found = AnCustomer.Find(CustomerNo);
        //if found
        if (Found == true) 
        {
            //display the values of the properties in the form
            txtEmail.Text = AnCustomer.Email;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            txtFullName.Text = AnCustomer.FullName;
            txtAddress.Text = AnCustomer.Address;
            txtPhoneNumber.Text = AnCustomer.PhoneNumber;
            cbActive.Checked = AnCustomer.Active;

        }
    }
}