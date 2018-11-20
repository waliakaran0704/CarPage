/*
 * Author: Raj Patel
 * This class will be responsible for interacting with the dataset or database
 *
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject.dsReservationTableAdapters;

namespace FinalProject
{
    public class ReservationDAL
    {

        //private fields
        private ReservationTableAdapter adpReservation;

        private dsReservation.ReservationDataTable tblReservation;

        private List<ReservationBLL> listReservation; //list of business logic layer objects

        /// <summary>
        /// The default constructor initialises a table adapter and datatable which will be very important when interacting 
        /// with the database
        /// </summary>
        public ReservationDAL()
        {
            adpReservation = new ReservationTableAdapter();
            tblReservation = new dsReservation.ReservationDataTable();
        }

        //public methods

            /// <summary>
            /// This methis will return all reservations that belong to a particular user
            /// </summary>
            /// <param name="username">This is a unique identifier to get all reservations that belong to a 
            /// particular user with the specified username</param>
            /// <returns>A list of reservations for a particular user</returns>
        public List<ReservationBLL> GetMyReservations(string username)
        {
            
            adpReservation.FillMyReservations(tblReservation, username);

            if (tblReservation.Count > 0)
            {
                listReservation = new List<ReservationBLL>();

                foreach (var myReservation in tblReservation)
                {
                    ReservationBLL reservation = new ReservationBLL();
                    reservation.Id = myReservation.Id;
                    reservation.CarLicensePlate = myReservation.CarLicensePlate;
                    reservation.CustomerUsername = myReservation.CustomerUsername;
                    reservation.FromDate = myReservation.FromDate;
                    reservation.ToDate = myReservation.ToDate;

                    listReservation.Add(reservation);
                }
            }

            return listReservation;
        }

        /// <summary>
        /// Gets a specific reservation record from the reservations table. This record is uniquely identified by the id
        /// </summary>
        /// <param name="id">Uniquely identifies the reservation in consideration</param>
        /// <returns></returns>
        public ReservationBLL GetReservationById(int id)
        {
            //the adapter fills the data table with the reservations
            adpReservation.FillById(tblReservation, id);

            ReservationBLL reservation = null;
            if (tblReservation.Count > 0) //or == 1 
            {
                reservation = new ReservationBLL();
                var row = tblReservation[0]; //for typed datasets ifs table[index] and 0 because it is only one row

                //reservation.Id = row.Id;
                reservation.CarLicensePlate = row.CarLicensePlate;
                reservation.CustomerUsername = row.CustomerUsername;
                reservation.FromDate = row.FromDate;
                reservation.ToDate = row.ToDate;
//              reservation.LocationID = row.LocationID;
            
            }

            return reservation;
        }


        /// <summary>
        /// this method adds a new reservation to the database. It takes in a reservation object and populates the database fields with the objects properties
        /// </summary>
        /// <param name="reservation">It contains the information to be added to the database</param>
        /// <returns></returns>
        public bool AddNewReservation(ReservationBLL reservation)
        {
            
            int result = adpReservation.Insert(reservation.CarLicensePlate, reservation.CustomerUsername, 
                (DateTime)reservation.FromDate, (DateTime)reservation.ToDate);

            if (result == 1)
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        /// <summary>
        /// This methiod will delete a reservation from the database 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CancelReservation(int id)
        {
            int result = adpReservation.Delete(id);

            if (result > 0)
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