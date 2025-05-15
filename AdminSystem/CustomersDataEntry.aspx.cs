using System;
using System.Collections.Generic;
using System.Linq;
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
        AnCustomer.CustomerNo = Convert.ToInt32(txtCustomer.Text);
        //Capture the Email
        AnCustomer.Email = txtEmail.Text;
        //capture the dateOfBirth
        AnCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        //capture the fullname
        AnCustomer.FullName = txtFullName.Text;
        //capture the address
        AnCustomer.Address = txtAddress.Text;
        //capture the PhoneNumber
        AnCustomer.PhoneNumber = txtPhoneNumber.Text;
        //capture the active stuff
        AnCustomer.Active = cbActive.Checked;

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