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

    protected void txtGameTitle_TextChanged(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsStock
        ClsStock AStock = new ClsStock();
        //capture the Game Id 
        AStock.GameId = Int32.Parse(txtGameId.Text);
        AStock.GameTitle = TextBox1.Text;
        AStock.GameReleaseDate = Convert.ToDateTime(txtGameReleaseDate.Text);
        AStock.GamePrice = Convert.ToDecimal(txtGamePrice.Text);
        AStock.StockQty = Int32.Parse(txtStockQty.Text);
        AStock.GameRating = Int32.Parse(txtGameRating.Text);
        AStock.IsDigital = chkIsDigitial.Checked;
        Session["AStock"] = AStock;
        //navigate to the view page 
        Response.Redirect("StockViewer.aspx");
    }
}