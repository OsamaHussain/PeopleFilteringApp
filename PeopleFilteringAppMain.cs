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

namespace PeopleFilteringApp
{
    public partial class peopleFilteringAppMain : Form
    {
        private SqlConnection connection;
        int Offset = 0;
        int Limit = 50;
        int maxLimit = 0;

        public peopleFilteringAppMain()
        {
            InitializeComponent();

            connection = new SqlConnection("Data Source=DESKTOP-2GGTQSU\\SQLEXPRESS01;Initial Catalog=demo;Integrated Security=True");
            PopulateComboBoxCity();
            PopulateComboBoxCountry();
            PopulateComboBoxZipCode();
            PopulateDataGridView();
            cbox_SearchField.SelectedIndex = 0;
        }

        private void PopulateComboBoxCity()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT City FROM Persons;", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add an empty item at the top of the ComboBox
            DataRow emptyRow = dt.NewRow();
            emptyRow["City"] = ""; // Replace "City" with the appropriate column name
            dt.Rows.InsertAt(emptyRow, 0);

            cbox_City.DataSource = dt;
            cbox_City.ValueMember = "City";
            cbox_City.DisplayMember = "City";
        }

        private void PopulateComboBoxCountry()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Country FROM Persons;", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add an empty item at the top of the ComboBox
            DataRow emptyRow = dt.NewRow();
            emptyRow["Country"] = ""; // Replace "Country" with the appropriate column name
            dt.Rows.InsertAt(emptyRow, 0);

            cbox_Country.DataSource = dt;
            cbox_Country.ValueMember = "Country";
            cbox_Country.DisplayMember = "Country";
        }
        private void PopulateComboBoxZipCode()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Zip FROM Persons;", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add an empty item at the top of the ComboBox
            DataRow emptyRow = dt.NewRow();
            emptyRow["Zip"] = ""; // Replace "Zip" with the appropriate column name
            dt.Rows.InsertAt(emptyRow, 0);

            cbox_Zip.DataSource = dt;
            cbox_Zip.ValueMember = "Zip";
            cbox_Zip.DisplayMember = "Zip";
        }

        private void PopulateDataGridView()
        {
            string selectedCity = cbox_City.SelectedValue.ToString();
            string selectedCountry = cbox_Country.SelectedValue.ToString();
            string selectedZipCode = cbox_Zip.SelectedValue.ToString();
            string searchValue = txt_Search.Text;

            string query = "Persons WHERE 1=1";

            if (!string.IsNullOrEmpty(selectedCity))
            {
                query += $" AND city = '{selectedCity}'";
            }

            if (!string.IsNullOrEmpty(selectedCountry))
            {
                query += $" AND country = '{selectedCountry}'";
            }

            if (!string.IsNullOrEmpty(selectedZipCode))
            {
                query += $" AND zip = '{selectedZipCode}'";
            }

            if (!string.IsNullOrEmpty(searchValue))
            {

                if (cbox_SearchField.SelectedIndex == 0)
                {
                    query += $" AND FullName LIKE '%{searchValue}%'";
                }
                else if (cbox_SearchField.SelectedIndex == 1)
                {
                    query += $" AND city LIKE '%{searchValue}%'";
                }else if (cbox_SearchField.SelectedIndex == 2)
                {
                    query += $" AND country LIKE '%{searchValue}%'";
                }else if (cbox_SearchField.SelectedIndex == 3)
                {
                    query += $" AND zip LIKE '%{searchValue}%'";
                }
            }

            query = $"SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM {query}) AS T WHERE T.RowNum > 0 ORDER BY T.RowNum OFFSET {Offset} ROWS FETCH NEXT {Limit} ROWS ONLY";

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            gv_Data.DataSource = dt;


            SqlCommand command = new SqlCommand("SELECT COUNT(*) AS TotalCount FROM Persons;", connection);
            connection.Open();
            int rowCount = (int)command.ExecuteScalar();
            Console.WriteLine($"Total rows: {rowCount}");
            connection.Close();

            maxLimit = rowCount;
        }

        private void cbox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            Offset = 0;
            PopulateDataGridView();
        }

        private void cbox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Offset = 0;
            PopulateDataGridView();
        }

        private void cbox_Zip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Offset = 0;
            PopulateDataGridView();
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            Offset = 0;
            PopulateDataGridView();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (Offset >= 0 && Offset+Limit < maxLimit)
            {
                Offset += Limit;
                PopulateDataGridView();
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (Offset > 0)
            {
                Offset -= Limit;
                PopulateDataGridView();
            }
        }
    }
}
