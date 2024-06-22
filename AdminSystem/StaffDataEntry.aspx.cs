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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();

        AStaff.StaffID = Convert.ToInt32(textStaffID.Text);
        AStaff.CustomerID = Convert.ToInt32(textCustomerID.Text);
        AStaff.StaffFullName = textStaffFullName.Text;
        AStaff.Availability = Convert.ToBoolean(textAvailability.Text);
        AStaff.StaffRole = textStaffRole.Text;
        AStaff.StartDate = Convert.ToDateTime(textStartDate.Text);
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }
}