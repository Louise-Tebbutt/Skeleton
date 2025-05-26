﻿using System;
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
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        // Create an instance of the staff collection
        clsStaffCollection AllStaff = new clsStaffCollection();

        // Set the data source to list of staff in the collection
        lstStaffList.DataSource = AllStaff.StaffList;

        // Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        // Set the data field to display
        lstStaffList.DataTextField = "StaffName";

        // bind the data to the list
        lstStaffList.DataBind();
    }
}