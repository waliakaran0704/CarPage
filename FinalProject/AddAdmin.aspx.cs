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
    public partial class AddAdmin : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
            }
        }

        protected void btnadmin_Click(object sender, EventArgs e)
        {

            int adminID = 0;
            // String query = "INSERT INTO Admin (Username, Password) VALUES(@Username, @Password) ;";
            string query = "Select * from Admin where Username=@Username and Password=@Password;";
            using (conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Username", txtusr.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text);

                adminID = Convert.ToInt32(cmd.ExecuteScalar());
                SqlDataReader reader = cmd.ExecuteReader();
            
                if (reader.Read())
                {
                    lbl.Text = "Login Successfull";
                    Response.Redirect("~/Controls.aspx");
                }
                else
                {
                    lbl.Text = "Please try again!!";
                }


            }
          
           
                    
                

            
          
          
        }
    }
}