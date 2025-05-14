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
}