using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bineva_L_RestaurantMangmentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restaurant_box.SelectedIndex = 0;
            guests_box.SelectedIndex = 0;
            tables_box.SelectedIndex = 0;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sql.Open();

                string query = "SELECT * FROM Booking WHERE 1 = 1";

                List<string> filters = new List<string>();
                if (restaurant_box != null)
                {
                    filters.Add("Restaurant = @restaurant");

                }
                if (guests_box != null)
                {
                    filters.Add("Number_Guests = @guests");

                }
                if (tables_box != null)
                {
                    filters.Add("Number_Tables = @tables");

                }
                if (filters.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", filters);
                }
                SqlCommand cmd = new SqlCommand(query, sql);
                if (restaurant_box.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@restaurant", restaurant_box.SelectedItem.ToString());
                }
                if (guests_box.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@guests", guests_box.SelectedItem.ToString());
                }
                if (tables_box != null)
                {
                    cmd.Parameters.AddWithValue("@tables", tables_box.SelectedItem.ToString());
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    data_grid.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            data_grid.DataSource = null;
            restaurant_box.SelectedIndex = 0;
            guests_box.SelectedIndex = 0;
            tables_box.SelectedIndex = 0;
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            using (Form2 userInputForm = new Form2())
            {
                userInputForm.ShowDialog();
            }
        }
    }
}