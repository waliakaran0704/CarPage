/*
 * Raj Patel
 * This page will act as the business lgic layer for the reservation object. 
 * All object properties and method calls and returns will be decided here
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class ReservationBLL
    {

        private ReservationDAL reservationDAL;

        /// <summary>
        /// the default constructor initialises a reservationDAL object which will be responsible for database interaction
        /// </summary>
        public ReservationBLL()
        {
            reservationDAL = new ReservationDAL();
        }

        //public properties for the reservation object
        public int Id { get; set; }
        public string CarLicensePlate { get; set; }
        public string CustomerUsername { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        //public methods

            /// <summary>
            /// The method will return all reservtaions made by a specific user
            /// </summary>
            /// <param name="username">This parameter will be used to uniquely identify reservations made by a specific customer</param>
            /// <returns>A list of all reservations made by the user</returns>
        public List<ReservationBLL> GetMyReservations(string username)
        {
            return reservationDAL.GetMyReservations(username);
        }

        /// <summary>
        /// This method adds a new reservation. It supplies the reservation object which takes in the date for the resravtion
        /// and adds it to the database
        /// </summary>
        /// <param name="reservation">The resrrvation object contains properties like reserved car, reservation from and to dates etc.</param>
        /// <returns>Returns true or false depending on whether insertion was successful or not</returns>
        public bool AddNewReservation(ReservationBLL reservation)
        {
            return reservationDAL.AddNewReservation(reservation);

        }
        /// <summary>
        /// This method takes in a reservation id to uniquely identify a reservation and cancel it
        /// </summary>
        /// <param name="id">Uniquely identifies a reservation</param>
        /// <returns>A booloean depending on the success of the method execution</returns>
        public bool CancelReservation(int id)
        {
            return reservationDAL.CancelReservation(id);
        }


        /// <summary>
        ///Retrieves a reservation record using id to uniquely identify the record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ReservationBLL GetReservationById(int id)
        {
            return reservationDAL.GetReservationById(id);
        }
    }
}