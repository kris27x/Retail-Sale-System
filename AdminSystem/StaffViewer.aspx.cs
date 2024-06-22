using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();

        AStaff = (clsStaff)Session["AStaff"];
        Response.Write("StaffId" + " = " + AStaff.StaffID + "<br><br>");
        Response.Write("StartDate" + " = " + AStaff.StartDate + "<br><br>");
        Response.Write("CustomerID" + " = " + AStaff.CustomerID + "<br><br>");
        Response.Write("StaffFullName" + " = " + AStaff.StaffFullName + "<br><br>");
        Response.Write("StaffRole" + " = " + AStaff.StaffRole + "<br><br>");
        Response.Write("Availability" + " = " + AStaff.Availability + "<br><br>");

    }
}