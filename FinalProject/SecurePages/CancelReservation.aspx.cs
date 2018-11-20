/*
 * Author: Raj Patel 
 * This form is just to cancel a reservtaion. It does not display anything to the user
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.SecurePages
{
    public partial class CancelReservation : System.Web.UI.Page
    {
        int reservation_id = -1;
        ReservationBLL reservation;
        CarsInformationReturned car;

        protected void Page_Load(object sender, EventArgs e)
        {
            reservation = new ReservationBLL();

            //the reservation id is obtained from the query string passed from the viewreservations page 
            reservation_id = int.Parse(Request.QueryString["id"]);

            //if id does not exist then no reservation was selected, else proceed
            if (reservation_id == -1)
            {
                Response.Redirect("ViewReservations.aspx?msg=select the reservation to cancel");
            }
            else
            {
                reservation = reservation.GetReservationById(reservation_id);

                car = new CarsInformationReturned();
                string car_id = reservation.CarLicensePlate;
                car.Update_Reservation_Status(car_id, true); //making the car available

                reservation.CancelReservation(reservation_id);
                
                Response.Redirect("ViewReservations.aspx?msg=Reservation Cancelled");

            }
        }
    }
}