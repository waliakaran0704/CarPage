/*
 *Author: Raj Patel
 * This form is to accept user input and validate it before it is uodated in the database
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.SecurePages
{
    public partial class EditProfile : System.Web.UI.Page
    {
        CustomerBLL customer;

        //this username variable holds the username of the curent logged in user
        string username = HttpContext.Current.User.Identity.Name;

        string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            msg = Request.QueryString["msg"];
            customer = new CustomerBLL();
            //first obtain the information of the customer and show the current information to the customer
            customer = customer.GetCustomerByUsername(username);

            txtNameE.Text = customer.Name;
            txtUsernameE.Text = customer.Username;
            txtPasswordE.Text = customer.Password;
            txtConfirmPasswordE.Text = customer.Password;
            txtPhoneE.Text = customer.Phone;
            txtAddressE.Text = customer.Address;
            txtAgeE.Text = customer.Age.ToString();
            //txtId.Text = customer.Id.ToString();
           

            lblMessage.Text = msg;


        }

        /// <summary>
        /// On update button click, aceot user input and uodate changes to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            customer.Name = txtNameE.Text;
            customer.Username = txtUsernameE.Text;
            customer.Password = txtPasswordE.Text;
            customer.Phone = txtPhoneE.Text;
            customer.Address = txtAddressE.Text;
            customer.Age = int.Parse(txtAgeE.Text);
            customer.Id = customer.Id; //original id
            lblMessage.Text = customer.Username;

            
            if (customer.UpdateCustomerInformation(customer))
            {
                Response.Redirect("EditProfile.aspx?msg=Information Updated");
                
            }
            else
            {
                Response.Redirect("EditProfile.aspx?msg=Information was not updated");
                 
            }
            
        }
    }
}