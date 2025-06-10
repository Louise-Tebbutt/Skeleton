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

        public void DisplayCustomer()
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
    }
