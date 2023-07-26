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

namespace Casgem.AdoNet
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-13123BI; Initial Catalog=CasgemDBMovie; Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Category");
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridCategory.DataSource = dataTable;
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            //((Button)sender).Text = "";
            connection.Open();
            SqlCommand command = new SqlCommand("Insert Into Category(CategoryName) Values(@p1)");
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", txtBoxCategoryName.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori başarılı bir şekilde kaydedildi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From Category Where CategoryId = @p1");
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", txtBoxCategoryID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori başarılı bir şekilde silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
    }
}