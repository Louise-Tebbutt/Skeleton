using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance clsOrder
        ClsOrder AnOrder = new ClsOrder();
        //get the data from the session object
        AnOrder = (ClsOrder)Session["AnOrder"];
        //display the CustomerId for this entry
        Response.Write(AnOrder.OrderId);
        
    }
}