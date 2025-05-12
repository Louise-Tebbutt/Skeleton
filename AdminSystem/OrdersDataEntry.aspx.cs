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

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsOrder
        ClsOrder AnOrder =  new ClsOrder();
        //capture an OrderId 
        AnOrder.OrderId = Convert.ToInt32(TextBox2.Text);
        //capture a customerId
        AnOrder.CustomerId = Convert.ToInt32(TextBox1.Text);
        //cature the order date
        AnOrder.OrderDate = Convert.ToDateTime(TextBox3.Text);
        //capture Total amount
        AnOrder.TotalAmount = Convert.ToDecimal(TextBox4.Text);
        //capture Payment Status 
        AnOrder.PaymentStatus = Convert.ToBoolean(Convert.ToInt32(TextBox5.Text));
        //capture Shipping Address
        AnOrder.ShippingAddress = Convert.ToString(TextBox6.Text);
        //capture StaffId
        AnOrder.StaffId = Convert.ToInt32(TextBox7.Text);
        //navigate to the view page
        Response.Redirect("OrderDataentry.aspx");
    }
}