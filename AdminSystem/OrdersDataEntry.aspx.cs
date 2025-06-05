using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be processed 
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if(OrderId != -1)
            {
                DisplayAddress();
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsOrder
        ClsOrder AnOrder =  new ClsOrder();
        //capture an OrderId 
        //AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture a customerId
        string CustomerId = txtCustomerId.Text;
        //cature the order date
        string OrderDate = txtOrderDate.Text;
        //capture Total amount
        string TotalAmount = txtTotalAmount.Text;
        //capture Payment Status 
        string PaymentStatus = txtPaymentStatus.Text;
        //capture Shipping Address
        string ShippingAddress = txtShippingAddress.Text;
        //capture StaffId
        string StaffId = txtStaffId.Text;
        //captureActive check box
        string Active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, PaymentStatus, ShippingAddress);
        if (Error == "")
        {
            //capture Order ID 
            AnOrder.OrderId= OrderId;
            //capture the customerId
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            //capture Orderdate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the totalamount
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);
            //capture paymentstatus
            AnOrder.PaymentStatus = Convert.ToBoolean(PaymentStatus);
            //capture shippingAddress
            AnOrder.ShippingAddress = ShippingAddress;
            //capture actuve box
            AnOrder.Active = chkActive.Checked;
            //create a new instance of the Order collection
            ClsOrderCollection OrderList = new ClsOrderCollection();

           if(OrderId == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder= AnOrder;
                OrderList.Update();
            }
            //navigate to the view page
            Response.Redirect("OrdersList.aspx");
        }
       else
        {
            lblError.Text = Error;
        }
    }
    
    
    

    protected void Button3_Click(object sender, EventArgs e)
    {
        //create an instance of the Order Class
        ClsOrder AnOrder = new ClsOrder();
       
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties 
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToShortDateString();
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            txtPaymentStatus.Text = AnOrder.PaymentStatus.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress.ToString();
            txtStaffId.Text = AnOrder.StaffId.ToString();
            chkActive.Checked = AnOrder.Active;
        }
    }
     void DisplayAddress()
    {
        //create an instance of the Order book
        ClsOrderCollection Order = new ClsOrderCollection();
        //find the record to update 
        Order.ThisOrder.Find(OrderId);
        //display the data for the record 
        txtOrderId.Text = Order.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = Order.ThisOrder.CustomerId.ToString();
        txtOrderDate.Text = Order.ThisOrder.OrderDate.ToShortDateString();
        txtTotalAmount.Text = Order.ThisOrder.TotalAmount.ToString();
        txtPaymentStatus.Text = Order.ThisOrder.PaymentStatus.ToString();
        txtShippingAddress.Text = Order.ThisOrder.ShippingAddress;
        txtStaffId.Text = Order.ThisOrder.StaffId.ToString();
        chkActive.Checked = Order.ThisOrder.Active;


    }
}