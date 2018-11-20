/*
 * Author: Raj Patel
 * Purpose of this class: This is the business logic layer of the Customer Object. All properties and method calls will be 
 * set and called using this class.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class CustomerBLL
    {
        private CustomerDAL customerDAL;

        /// <summary>
        /// This method is the constructor for this class and it instantiates a CustomerDataAccessLayer Class' Object which is 
        /// responsible for interacting with the database
        /// </summary>
        public CustomerBLL()
        {
            customerDAL = new CustomerDAL();
        }

        //public properties. These are the properties of the Customer Entity
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //public methods

            /// <summary>
            /// This method will request for a specific customer's information from the CustomerDataAccessLayer Object
            /// 
            /// </summary>
            /// <param name="username">The username is used to uniquely identify a particular customer and obtain the right details</param>
            /// <returns>A customer object with properties obtained from the CustomerDataAccessLayer Object</returns>
        public CustomerBLL GetCustomerByUsername(string username)
        {
            return customerDAL.GetCustomerByUsername(username);
        }

        //adding user to database

            /// <summary>
            /// This method will pass the customer object and ask the dataAccessLayer object to populate the database with the object's properties
            /// </summary>
            /// <param name="customer">This object contains all the properties of the object to be added to the database</param>
            /// <returns>True or false basing on the success of the execution</returns>
        public bool AddNewUser(CustomerBLL customer)
        {
            return customerDAL.AddNewUser(customer);

        }

        /// <summary>
        /// This method will command the customerDAL to update information in the databse. The information to be updated is stored 
        /// customer objects properties and this object will be passed by this method
        /// </summary>
        /// <param name="customer">COntains propeties whose new values need to be updated into the database</param>
        /// <returns>True or False basing on the whether the update was successful or not</returns>
        public bool UpdateCustomerInformation(CustomerBLL customer)
        {
            return customerDAL.UpdateCustomerInformation(customer);
        }


    }
}