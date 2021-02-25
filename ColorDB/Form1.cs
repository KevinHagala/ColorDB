using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorDB.Properties.Settings.ColorsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorTable();
        }

        private void ColorTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From PrimaryColor", connection))
            {
                DataTable colorTable = new DataTable();
                adapter.Fill(colorTable);

                PrimaryColor.DisplayMember = "PrimaryColorName";
                PrimaryColor.ValueMember = "Id";
                PrimaryColor.DataSource = colorTable;
            }
        }

        private void PrimaryColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorTypes();
        }

        private void ColorTypes()
        {
            string query = "SELECT PrimaryColor.Name FROM ColorId INNER JOIN Pet ON color.IdId = ColorId.Id WHERE PrimaryColor.Id =@TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", PrimaryColor.SelectedValue);
                DataTable colorTable = new DataTable();
                adapter.Fill(colorTable);
                ColorType.DisplayMember = "Name";
                ColorType.ValueMember = "Id";
                ColorType.DataSource = colorTable;
            }
        }
    }
}
