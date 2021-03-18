using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FridgeDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FridgeDB.Properties.Settings.FridgeConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFoodTypeTable();
        }

        private void PopulateFoodTypeTable()
        {
            using(connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FoodType", connection))
            {
                DataTable foodTypesTable = new DataTable();
                adapter.Fill(foodTypesTable);

                listFoodType.DisplayMember = "TypeName";
                listFoodType.ValueMember = "Id";
                listFoodType.DataSource = foodTypesTable;
            }
        }

        private void listFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFoodInTheFridge();
        }

        private void PopulateFoodInTheFridge()
        {
            string query = "SELECT FoodInTheFridge.Name FROM FoodType INNER JOIN FoodInTheFridge ON FoodInTheFridge.TypeId = FoodType.Id WHERE FoodType.Id = @TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", listFoodType.SelectedValue);
                DataTable foodInTheFridgeTable = new DataTable();
                adapter.Fill(foodInTheFridgeTable);

                listFoodInTheFridge.DisplayMember = "Name";
                listFoodInTheFridge.ValueMember = "Id";
                listFoodInTheFridge.DataSource = foodInTheFridgeTable;
            }
        }

    }
}
