using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bineva_L_RestaurantMangmentForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sql.Open();
                string availabilityQuery = "SELECT Availability FROM Booking WHERE Table_num = @table_num";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sql);
                availabilityCmd.Parameters.AddWithValue("@table_num", table_num.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult == "Available" || availabilityResult == "available")
                {
                    MessageBox.Show("Booking Successful!");
                    string query = "INSERT INTO Reservations VALUES (@table_num, @name, @phone, @time, @restaurant)";
                    SqlCommand queryCmd = new SqlCommand(query, sql);

                    queryCmd.Parameters.AddWithValue("@table_num", table_num.Text);
                    queryCmd.Parameters.AddWithValue("@name", name.Text);
                    queryCmd.Parameters.AddWithValue("@phone", phone.Text);
                    queryCmd.Parameters.AddWithValue("@time", time.Text);
                    queryCmd.Parameters.AddWithValue("@restaurant", restaurant.Text);

                    queryCmd.ExecuteNonQuery();

                    string updateAvailabilityQuery = "UPDATE Booking SET Availability = 'Not Available' WHERE Table_num = @table_num";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sql);
                    updateAvailabilityCmd.Parameters.AddWithValue("@table_num", table_num.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sorry, the table is not available for booking.");
                }
            }
        }
    }
}
