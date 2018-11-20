/*
 * Author: Raj Patel
 * Purpose: This is a web form class and we will be taking input from the customer and validating it here
 *Note: this layer never communicates with Data Access Layer
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class RegisterUser : System.Web.UI.Page
    {

        private CustomerBLL bll;

        /// <summary>
        /// the constructor initiates the customerBLL object which will handle all the business logic
        /// </summary>
        public RegisterUser()
        {
            bll = new CustomerBLL();

        }

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            string username = txtCustomerUsername.Text;

            //we will create a customer object and set all its properties to user defined values from the form
            CustomerBLL customer = new CustomerBLL();
            customer.Name = txtCustomerName.Text.Trim();
            customer.Username = txtCustomerUsername.Text.Trim();
            customer.Password = txtCustomerPassword.Text.Trim();
            customer.Phone = txtCustomerPhone.Text.Trim();
            customer.Address = txtCustomerAddress.Text.Trim();
            customer.Age = int.Parse(txtCustomerAge.Text.Trim());

            //check if the username exists; if not then proceed otherwise notify the customer to provide a different username
            if (customer.GetCustomerByUsername(username) == null) //checking if username is unique
            {
                //add new user and return a boolean which depends on the success of the inserting
                if (customer.AddNewUser(customer)) //if true or if insert is successful,
                {
                    // navigate to the login page
                    Response.Redirect("CustomerLogin.aspx?msg=User was successfully registered. Log in to continue");
                }
                else
                {
                    lblMessage.Text = "Insertion Failed";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                lblMessage.Text = "Username already exists. Please provide a different username";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }








    }
}