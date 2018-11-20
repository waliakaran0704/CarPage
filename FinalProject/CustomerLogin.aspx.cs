/*
 * Author: Raj Patel
 * This is a web form which takes in username and password as input from the customer
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this method will be executed when the login button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerBLL customer = new CustomerBLL();
            string username = txtCustomerUsernameLogin.Text;
            string password = txtCustomerPasswordLogin.Text;

            //this method will return a customer object if a customer with the username exists
            customer = customer.GetCustomerByUsername(username);

            //if no customer with username exists and the password authentication is done, then the if part will execute
            if (customer != null && password == customer.Password)
            {
                //this method will store the username and use it to check if the user is logged in and has access to the page
                FormsAuthentication.RedirectFromLoginPage(username, false);
            }
            else
            {
                lblMessage.Text = "Login failed. Please try again.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            
        }
        
    }
}