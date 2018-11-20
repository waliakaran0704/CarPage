/*
 *Author: Raj Patel 
 * The purpose of this web form is to reserve a car and accept user input like reservation dates etc.
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.SecurePages
{
    public partial class ReserveCar : System.Web.UI.Page
    {
        private CarsInformationReturned car;
        private ReservationBLL reservation;
        string car_id;

        //the username holds the username of the current logged in user
        string username = HttpContext.Current.User.Identity.Name;

        /// <summary>
        /// This code executed on page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
           
            car_id = Request.QueryString["id"];

            //the if statement checks to see whether a car is selected for reservation
            if (car_id == null)
            {
                Response.Redirect("ViewCars.aspx?msg=select a car to reserve");
            }
            else
            {
                car = new CarsInformationReturned();

                //Car information is returned 
                car = car.GetCar_InfoByLicenseplate(car_id);
                
                txtReservedCarLicense.Text = car_id;
                
                
            }
        }

        /// <summary>
        /// This code executes when the reserve button is clicked
        /// it accepts the user input and creates a reservation object which will later be added to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReserveCar_Click(object sender, EventArgs e)
        {
            reservation = new ReservationBLL();

            car = new CarsInformationReturned();
            car = car.GetCar_InfoByLicenseplate(car_id);

            //car availability is updated. it is set to false if the car is reserved therefore it is no longer available for other users
            car.Update_Reservation_Status(car_id, false);

            //get all input and creating a reservation object
            reservation.CarLicensePlate = txtReservedCarLicense.Text;
            reservation.CustomerUsername = username;
            reservation.FromDate = calenderFromDate.SelectedDate;
            reservation.ToDate = calenderToDate.SelectedDate;
    //        reservation.LocationID = int.Parse(txtLocationId.Text);
            
            //adding a reservation and making a decision of successful insertion
            if (reservation.AddNewReservation(reservation))
            {
                Response.Redirect("ViewCars.aspx?msg=Car was successfully Reserved");
            }
            else
            {
                Response.Redirect("ViewCars.aspx?msg=Car reservation failed");
            }

        }
    }
}