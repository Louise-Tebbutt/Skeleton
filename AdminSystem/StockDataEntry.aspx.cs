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
        
        //capture the data from the form fields
        AStock.GameId = Int32.Parse(txtGameId.Text);
        AStock.GameTitle = txtGameTitle.Text;
        AStock.GameReleaseDate = Convert.ToDateTime(txtGameReleaseDate.Text);
        AStock.GamePrice = Convert.ToDecimal(txtGamePrice.Text);
        AStock.StockQty = Int32.Parse(txtStockQty.Text);
        AStock.GameRating = Int32.Parse(txtGameRating.Text);
        AStock.IsDigital = chkIsDigital.Checked;
        
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }

    protected void chkIsDigital_CheckedChanged(object sender, EventArgs e)
    {

    }

   
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        ClsStock AStock = new ClsStock();
        //create a variable to store the primary key
        Int32 GameId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        GameId = Convert.ToInt32(txtGameId.Text);
        //find the record
        Found = AStock.Find(GameId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtGameId.Text = AStock.GameId.ToString();
            txtGameTitle.Text = AStock.GameTitle;
            txtGameReleaseDate.Text = AStock.GameReleaseDate.ToString("yyyy-MM-dd");
            txtGamePrice.Text = AStock.GamePrice.ToString("0.00");
            txtStockQty.Text = AStock.StockQty.ToString();
            txtGameRating.Text = AStock.GameRating.ToString();
            chkIsDigital.Checked = AStock.IsDigital;
        }
    }
}
