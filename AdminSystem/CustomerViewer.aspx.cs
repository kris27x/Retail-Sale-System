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
        //Create a new instance of the class
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //Display the house number on the page
        Response.Write(ACustomer.CustomerID);
        Response.Write(ACustomer.Name);
        Response.Write(ACustomer.Email);
        Response.Write(ACustomer.Address);
        Response.Write(ACustomer.DateAdded);
    }
}