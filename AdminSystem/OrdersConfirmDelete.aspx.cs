using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key of the record to be deleted 
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be deleteed from the sesssion object 
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btn_yes_Click(object sender, EventArgs e)
    {
        //create a new instance of the OrderId collectiob class
        ClsOrderCollection OrderId = new ClsOrderCollection();
        //find the record to delete 
        OrderId.ThisOrder.Find(OrderId);
        //delete the record 
        OrderId.Delete();
        //redirect  back to main page 
        Response.Redirect("OrderList.aspx");
    }

    protected void btn_No_Click(object sender, EventArgs e)
    {
        //redirect back to the main page 
        Response.Redirect("OrderList.aspx");
    }
}