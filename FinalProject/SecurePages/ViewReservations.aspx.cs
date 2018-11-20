/*
 *Author: Raj Patel
 *Thi class will display all reservations of the current logged in user 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class ViewReservations : System.Web.UI.Page
    {

        ReservationBLL reservation;
        string username = HttpContext.Current.User.Identity.Name;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string msg = Request.QueryString["msg"];
            lblMessage.Text = msg;

            lblName.Text = username;

            reservation = new ReservationBLL();

            List<ReservationBLL> listMyReservations = new List<ReservationBLL>();

            //this method gets all reservations made by the user with the unique supplied username
            listMyReservations = reservation.GetMyReservations(username);

            //the reservations list is displayed in a grid view control
            grdReservations.DataSource = listMyReservations;
            grdReservations.DataBind();
            
        }
    }
}