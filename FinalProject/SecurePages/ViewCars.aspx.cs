/*
 * Author: Raj Patel
 * This is used to display all available cars for reservation
 * This is the home page for logged in users
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
    public partial class ViewCars : System.Web.UI.Page
    {
        CarsInformationReturned car;

        protected void Page_Load(object sender, EventArgs e)
        {
            car = new CarsInformationReturned();

            string message = Request.QueryString["msg"];

            lblMessage.Text = message;
            
            List<CarsInformationReturned> listCar = new List<CarsInformationReturned>();

            //this method will retrieve all cars which are available and display them in a grid view
            listCar = car.GetAvailableCars();
            grdCars.DataSource = listCar;
            grdCars.DataBind();
            
        }

 
    }
}