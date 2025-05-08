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
        //create a new instance of ClsStock
        ClsStock AStock = new ClsStock();
        //get the data from the session object 
        AStock = (ClsStock)Session["AStock"];
        //display the Game Id for this entry 
        Response.Write(AStock.GameId);
        Response.Write(AStock.GameTitle);
    }
}