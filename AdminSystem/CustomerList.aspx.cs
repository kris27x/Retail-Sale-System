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
        lblError.Text = "";
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName(txtNameSearch.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName("");
        //clear any existing filter to tidy up the interface
        txtNameSearch.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}