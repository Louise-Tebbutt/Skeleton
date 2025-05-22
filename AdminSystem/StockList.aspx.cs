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
        if (!IsPostBack)
        {
            //update the list box 
            DisplayStock();
        }
    }

    private void DisplayStock()
    {
       //create an instance of the Stock Collection 
       ClsStockCollection Stock = new ClsStockCollection();
        //set the data source to list of stock in the collection 
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key 
        lstStockList.DataValueField = "GameId";
        //set the data field to display
        lstStockList.DataTextField = "GameTitle";
        //bind the data to the list
        lstStockList.DataBind();
    }
}