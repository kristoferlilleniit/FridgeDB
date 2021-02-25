using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FridgeDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FridgeDB.Properties.Settings.FridgeDBConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFoodTypeTable();
        }

        private void PopulateFoodTypeTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FoodType", connection))
            {
                DataTable foodTable = new DataTable();
                adapter.Fill(foodTable);

                FoodType1.DisplayMember = "TypeName";
                FoodType1.ValueMember = "Id";
                FoodType1.DataSource = foodTable;
            }
        }

        private void PopulateFoodInTheFridge()
        {
            string query = "SELECT FoodInTheFridge.Name FROM FoodType INNER JOIN FoodInTheFridge ON FoodInTheFridge.TypeId = FoodType.Id WHERE FoodType.Id = @TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", FoodType1.SelectedValue);
                DataTable FoodInTheFridgeTable = new DataTable();
                adapter.Fill(FoodInTheFridgeTable);

                FoodInTheFridge1.DisplayMember = "Name";
                FoodInTheFridge1.ValueMember = "Id";
                FoodInTheFridge1.DataSource = FoodInTheFridgeTable;
            }
        }

        private void FoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFoodInTheFridge();
        }
    }
}
