using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope 
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if(IsPostBack == false)
        {
            //if this is not a new record 
            if(OrderId != -1)
            {
                //display the current data for the record 
                DisplayOrder();
            }
            //update the list box 
            DisplayOrder();
        }
    }
    void DisplayOrder()
    {
        //create an instance of Order collection
        ClsOrderCollection Order = new ClsOrderCollection();
        //set the data source to list of Order in the collection
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display 
        lstOrderList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }





    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited 
        Int32 OrderId;
        //if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //getthe primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the edit page 
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            btn_lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["OrderId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primarykey value of the record to be deleted 
        Int32 OrderId;
        //if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //getthe primary key value of the record to delete
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page 
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            btn_lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        ClsOrderCollection AnOrder = new ClsOrderCollection();
        //retrive the value of shipping address from the presentation layer 
        AnOrder.ReportByShippingAddress(btnApplyFilter_Click.Text);
        //set the data source to the list of shipping address in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "ShippingAddress";
        //bind the data to the list 
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click_Click(object sender, EventArgs e)
    {
        //create an instance of the address object 
        ClsOrderCollection AnOrder = new ClsOrderCollection();
        //set an empty string 
        AnOrder.ReportByShippingAddress("");
        //clear any existing filter to tidy up the interface 
        TextBox1.Text = "";
        //set the data source to the list of shipping address in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "ShippingAddress";
        //bind the data to the list 
        lstOrderList.DataBind();
    }
}