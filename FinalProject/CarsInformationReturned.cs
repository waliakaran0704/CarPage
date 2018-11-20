using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class CarsInformationReturned
    {
        private DataControls data;

        public CarsInformationReturned()
        {
            data = new DataControls();
        }

        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string VIN { get; set; }

        public string color { get; set; }
        public long odometer { get; set; }
        public decimal price { get; set; }
        public string licensePlate { get; set; }

        public bool Available { get; set; } // Raj Patel

        public List<CarsInformationReturned> GetCarsInformation()
        {
            return data.GetCarsInformation();
        }

        public CarsInformationReturned GetCar_InfoByLicenseplate(string lic_plate)
        {
            return data.GetCar_InfoByLicenseplate(lic_plate);
        }

        public bool Add (CarsInformationReturned Add)
        {
            return data.Add_car(Add);
        }

        public bool Update(CarsInformationReturned update)
        {
            return data.Update_car(update);
        }

        public bool DeleteCar(string lic_plate)
        {
            return data.Delete_car(lic_plate);
        }

        /// <summary>
        /// Method By Raj Patel
        /// Purpose: This method will change the status of thwe car to the provided value i.e it will make a car available or unavailable
        /// </summary>
        /// <param name="car_licensePlate">It is used to uniquely identify a car</param>
        /// <param name="status">It specifies the new state of the car i.e true means the car is available</param>
        /// <returns></returns>
        public bool Update_Reservation_Status(string car_licensePlate, bool status) 
        {
            return data.Update_Reservation_Status(car_licensePlate, status);
        }

        /// <summary>
        /// Author: Raj Patel
        /// This method returns all available cars 
        /// </summary>
        /// <returns></returns>
        public List<CarsInformationReturned> GetAvailableCars()
        {
            return data.GetAvailableCars();
        }


    }
}