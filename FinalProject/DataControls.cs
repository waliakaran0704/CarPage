using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject.CarsTableAdapters;

namespace FinalProject
{


    public class DataControls
    {
        private CarTableAdapter carInfo;
        private Cars.CarDataTable carTable;
        private List<CarsInformationReturned> displayCarInfo;

        
        public DataControls()
        {
            carInfo = new CarTableAdapter();
            carTable = new Cars.CarDataTable();
        }

        public List<CarsInformationReturned> GetCarsInformation()
        {
            carInfo.Fill(carTable);

            if (carTable.Count > 0)
            {
                displayCarInfo = new List<CarsInformationReturned>();

                foreach (var cursor in carTable)
                {
                    CarsInformationReturned cars = new CarsInformationReturned();

                    cars.make = cursor.Make;
                    cars.model = cursor.Model;
                    cars.year = cursor.Year;
                    cars.VIN = cursor.VIN;
                    cars.color = cursor.Color;
                    cars.odometer = cursor.Odometer;
                    cars.price = cursor.Price;
                    cars.licensePlate = cursor.LicensePlate;
                    cars.Available = cursor.Available;

                    displayCarInfo.Add(cars);
                }
            }
            return displayCarInfo;

        }


        public CarsInformationReturned GetCar_InfoByLicenseplate(string Lic_plate)
        {
            carInfo.FillByLic(carTable, Lic_plate);
            CarsInformationReturned cars = null;

            if (carTable.Count > 0)
            {
                cars = new CarsInformationReturned();
                var cursor = carTable[0];

                cars.make = cursor.Make;
                cars.model = cursor.Model;
                cars.year = cursor.Year;
                cars.VIN = cursor.VIN;
                cars.color = cursor.Color;
                cars.odometer = cursor.Odometer;
                cars.price = cursor.Price;
                cars.licensePlate = cursor.LicensePlate;

            }

            return cars;
        }

        public bool Add_car(CarsInformationReturned car)
        {
            int add = carInfo.Insert(car.make, car.model, car.year, car.VIN, car.color, car.odometer, car.price, car.licensePlate, car.Available);

            return add == 1;
        }

        public bool Update_car(CarsInformationReturned car)
        {
            int res = 
            carInfo.Update(car.make, car.model, car.year, car.VIN, car.color, car.odometer, car.price, car.Available, car.licensePlate);

            return res == 1;
        }
    


public bool Delete_car(string lic_plate)
{
    int delete = carInfo.Delete(lic_plate);
    return true;
}



            /// <summary>
            /// Author: Raj Patel
            /// This method accesses a car record in database using license plate and changes its availability
            /// </summary>
            /// <param name="car_licensePlate">Uniquely identifies the car</param>
            /// <param name="status">Changes the availability of a car to true or false</param>
            /// <returns></returns>
        public bool Update_Reservation_Status(string car_licensePlate, bool status)
        {

            int result = carInfo.UpdateCarAvailability(status, car_licensePlate);
            return result == 1;
        }


            /// <summary>
            /// Author: Raj Patel
            /// This method retrieves all cars that are available and eturns a list which will later populate a grid view control
            /// </summary>
            /// <returns>A list view of all available cars</returns>
        public List<CarsInformationReturned> GetAvailableCars()
        {
            carInfo.FillByAvailability(carTable);

            if (carTable.Count > 0)
            {
                displayCarInfo = new List<CarsInformationReturned>();

                foreach (var cursor in carTable)
                {
                    CarsInformationReturned cars = new CarsInformationReturned();

                    cars.make = cursor.Make;
                    cars.model = cursor.Model;
                    cars.year = cursor.Year;
                    cars.VIN = cursor.VIN;
                    cars.color = cursor.Color;
                    cars.odometer = cursor.Odometer;
                    cars.price = cursor.Price;
                    cars.licensePlate = cursor.LicensePlate;
                    cars.Available = cursor.Available;

                    displayCarInfo.Add(cars);
                }
            }
            return displayCarInfo;
        }


    }




}