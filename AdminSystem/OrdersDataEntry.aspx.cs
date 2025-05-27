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
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsOrder
        ClsOrder AnOrder =  new ClsOrder();
        //capture an OrderId 
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture a customerId
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //cature the order date
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //capture Total amount
        AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        //capture Payment Status 
        AnOrder.PaymentStatus = Convert.ToBoolean(Convert.ToInt32(txtPaymentStatus.Text));
        //capture Shipping Address
        AnOrder.ShippingAddress = Convert.ToString(txtShippingAddress.Text);
        //capture StaffId
        AnOrder.StaffId = Convert.ToInt32(txtStaffId.Text);
        //captureActive check box
        string Active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(CustomerId, Orderdate, TotalAmount, PaymentStatus, ShippingAddress);
        if (Error == "")
        {
            //capture the customerId
            AnOrder.CustomerId = CustomerId;
            //capture Orderdate
            AnOrder.OrderDate = Orderdate;
            //capture the totalamount
            AnOrder.TotalAmount = TotalAmount;
            //capture paymentstatus
            AnOrder.PaymentStatus = PaymentStatus;
            //capture shippingAddress
            AnOrder.ShippingAddress = ShippingAddress;
            //store the Order in the same session object
            Session["AnOrder"] = AnOrder;

        }
        //navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
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
            txtOrderDate.Text = AnOrder.OrderDate.ToString("yyyy-MM-dd");
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            txtPaymentStatus.Text = AnOrder.PaymentStatus.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtStaffId.Text = AnOrder.StaffId.ToString();
            chkActive.Checked = AnOrder.Active;
        }
    }
}