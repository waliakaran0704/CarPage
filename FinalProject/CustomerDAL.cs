/*
 * Raj Patel
 * This class is responsible for interacting with the Database. It will be using Offline connectivity and the dataset in action
 * is "dsCustomer". This class responds to the customerBLL and has no interaction with the webform classes
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject.dsCustomerTableAdapters;

namespace FinalProject
{
    public class CustomerDAL
    {
        //private fields

        private CustomerTableAdapter adpCustomer;

        private dsCustomer.CustomerDataTable tblCustomer;

//        private List<CustomerBLL> listCustomer; //list of business logic layer objects

        //constructor
        /// <summary>
        /// This is the constructor fotr this class. It initialises both the table adapter and datatable which will be key objects when
        /// interacting with the dataset or database
        /// </summary>
        public CustomerDAL()
        {
            adpCustomer = new CustomerTableAdapter();
            tblCustomer = new dsCustomer.CustomerDataTable();
        }

        //methods
        
            /// <summary>
            /// This method returns a cstomerBLL object with the customer object's properties like Name, username etc from the 
            /// database.
            /// </summary>
            /// <param name="username">This parameter is used to uniquely identify a customer record in the database</param>
            /// <returns>A single customerBLL object with customer information like address, phone etcfrom the database</returns>
        public CustomerBLL GetCustomerByUsername(string username)
        {
            //this method uses a configured query to fill a datatable with specific customer information which is uniquely 
            //identified using a username
            adpCustomer.FillByUsername(tblCustomer, username);

            CustomerBLL customer = null;

            //the if statement checks if a result is returned and if it is then it fills the customer object's properties with 
            //values from the database
            if (tblCustomer.Count > 0)  
            {
                customer = new CustomerBLL();
                var row = tblCustomer[0]; //for typed datasets ifs table[index] and 0 because it is only one row

                customer.Id = row.Id;
                customer.Name = row.Name;
                customer.Username = row.Username;
                customer.Password = row.Password;
                customer.Phone = row.Phone;
                customer.Address = row.Address;
                customer.Age = row.Age;
                
            }

            return customer;
        }

        /// <summary>
        /// The method will add a new customer or register a new user.
        /// It takes in a customerBLL object and populates the database with the object's properties
        /// </summary>
        /// <param name="customer">This object contains properties which hold the customer's information and this
        /// information will be populated to the database</param>
        /// <returns>A boolean value; true or false basing on whether the insertion succeeded or failed</returns>
        public bool AddNewUser(CustomerBLL customer)
        {
            int result = adpCustomer.Insert(customer.Name, customer.Username, customer.Password, customer.Phone,
                customer.Address, customer.Age);

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        //updating customer information

        /// <summary>
        /// this method takes customer information and updates the database with the new information which is in the object's properties
        /// </summary>
        /// <param name="customer">This is a customerBLL object with properties that contain new information for the object</param>
        /// <returns>A boolean depending on whether update was successful or not</returns>
        public bool UpdateCustomerInformation(CustomerBLL customer)
        {
            
            int result = adpCustomer.UpdateCustomerInfo
                (customer.Name, customer.Password, customer.Phone, customer.Address, customer.Age, customer.Username);


            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
    }
}