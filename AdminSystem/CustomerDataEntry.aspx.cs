using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //variable to store the primary key with page level scope
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        //string values for valid method
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Address = txtAddress.Text;
        string DateAdded = txtDateAdded.Text;
        //send string values to validate method
        string Error = "";
        Error = ACustomer.Valid(Name, Email, Address, DateAdded);
        if(Error == "")
        {
            ACustomer.CustomerID = CustomerID;
            ACustomer.Name = Name;
            ACustomer.Email = Email;
            ACustomer.Address = Address;
            DateTime Date = Convert.ToDateTime(DateAdded);
            ACustomer.DateAdded = Date;
            ACustomer.ReceiveMarketing = chkReceiveMarketing.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if(CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of Customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            lblError.Text = "";
            //display the values of the properties in the form
            txtName.Text = ACustomer.Name;
            txtEmail.Text = ACustomer.Email;
            txtAddress.Text = ACustomer.Address;
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
            if (ACustomer.ReceiveMarketing == true)
            {
                chkReceiveMarketing.Checked = true;
            }
            else
            {
                chkReceiveMarketing.Checked = false;
            }
        }
        else
        {
            lblError.Text = "Error CustomerID Not Found";
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customercol = new clsCustomerCollection();
        //find the record to update
        Customercol.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = Customercol.ThisCustomer.CustomerID.ToString();
        txtName.Text = Customercol.ThisCustomer.Name;
        txtEmail.Text = Customercol.ThisCustomer.Email;
        txtAddress.Text = Customercol.ThisCustomer.Address;
        txtDateAdded.Text = Customercol.ThisCustomer.DateAdded.ToString();
        chkReceiveMarketing.Checked = Customercol.ThisCustomer.ReceiveMarketing;
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}