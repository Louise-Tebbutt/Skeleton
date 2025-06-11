using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomer();
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the Customer collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        //setthe data source to list of customers in the colletion
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerNo";
        //set the data field to display
        lstCustomerList.DataTextField = "FullName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate that this is a new record
        Session["CustomerNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomersDataEntry.aspx");
    }

    protected void bntEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CustomerNo;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the data entry page
            Response.Redirect("CustomersDataEntry.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}
