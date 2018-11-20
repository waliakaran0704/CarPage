using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Controls : System.Web.UI.Page
    {
        private CarsInformationReturned data;

        public Controls()
        {
            data = new CarsInformationReturned();
        }

        private void displayCarData() 
        {
            grdView.DataSource = data.GetCarsInformation();
            grdView.DataBind();

        }

        //String cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayCarData();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //{
            //    String query = "INSERT INTO CAR (MAKE, MODEL, Year, VIN, Color, Odometer, Price, LicensePlate) VALUES(@MAKE, @MODEL, @Year, @VIN, @Color, @Odometer, @Price, @LicensePlate) ;";
            //    //string query = "Select* from Admin where Username=@Username and Password=@Password;";
            //    using (conn = new SqlConnection(cs))
            //    {
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        conn.Open();
            //        cmd.Parameters.AddWithValue("@MAKE", txtmake.Text);
            //        cmd.Parameters.AddWithValue("@MODEL", txtModel.Text);
            //        cmd.Parameters.AddWithValue("@Year", txtyear.Text);
            //        cmd.Parameters.AddWithValue("@VIN", txtVIN.Text);
            //        cmd.Parameters.AddWithValue("@Color", txtColor.Text);
            //        cmd.Parameters.AddWithValue("@Odometer", txtOdometer.Text);
            //        cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            //        cmd.Parameters.AddWithValue("@LicensePlate", txtLic.Text);
            //        int add = cmd.ExecuteNonQuery();
            //        if (add == 1)
            //        {

            //            lbl.Text = "Data Inserted";
            //        }
            //        else
            //        {
            //            lbl.Text = "Not inserted";
            //        }
            //    }


            CarsInformationReturned cars = new CarsInformationReturned();

            cars.make = txtmake.Text;
            cars.licensePlate = txtLic.Text;
            cars.color = txtColor.Text;
            cars.model = txtModel.Text;
            cars.odometer = long.Parse(txtOdometer.Text);
            cars.price = int.Parse(txtPrice.Text);
            cars.year = int.Parse(txtyear.Text);
            cars.VIN = txtVIN.Text;
            cars.Available = chkAvailable.Checked;

            if (data.Add(cars))
            {
                displayCarData();
                lbl.Text = "Car inserted";
                lbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {

                lbl.Text = "Car data not inserted";
                lbl.ForeColor = System.Drawing.Color.Red;
            }
            }

        protected void btn_fetch_Click(object sender, EventArgs e)
        {
            string lic_plate = txtLic.Text;

            CarsInformationReturned data1 = data.GetCar_InfoByLicenseplate(lic_plate);

            if (data1 != null)
            {
                txtLic.Text = data1.licensePlate;
                txtColor.Text = data1.color;
                txtmake.Text = data1.make;
                txtyear.Text = data1.year.ToString();
                txtModel.Text = data1.model;
                txtOdometer.Text = data1.odometer.ToString();
                txtVIN.Text = data1.VIN;
                txtPrice.Text = data1.price.ToString();
                lbl.Text = "Car data Found";
                lbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl.Text = "Car data not found";
                lbl.ForeColor = System.Drawing.Color.Red;
            }


    }

        protected void Update_Click(object sender, EventArgs e)
        {

            CarsInformationReturned cars = new CarsInformationReturned();

            cars.make = txtmake.Text;
            cars.licensePlate = txtLic.Text;
            cars.color = txtColor.Text;
            cars.model = txtModel.Text;
            cars.odometer = long.Parse(txtOdometer.Text);
            cars.price = int.Parse(txtPrice.Text);
            cars.year = int.Parse(txtyear.Text);
            cars.VIN = txtVIN.Text;

            if (data.Update(cars))
            {
                displayCarData();
                lbl.Text = "Car information updated ";
                lbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl.Text = "Car information not updated";
                lbl.ForeColor = System.Drawing.Color.Red;

            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string lic_plate = txtLic.Text;
            if (data.DeleteCar(lic_plate))
            {
                displayCarData();
                lbl.Text = "Car deleted";
                lbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {

                lbl.Text = "Car data not deleted";
                lbl.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
    }
    
