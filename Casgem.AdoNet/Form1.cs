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
            SqlCommand command = new SqlCommand("Select * From Category;");
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
            SqlCommand command = new SqlCommand("Insert Into Category(CategoryName) Values(@p1);");
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", txtBoxCategoryName.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From Category Where CategoryId = @p1;");
            command.Connection = connection;
            command.Parameters.AddWithValue("@p1", txtBoxCategoryID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori başarılı bir şekilde silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            connection.BeginTransaction();
            SqlCommand command = new SqlCommand("Update Category Set CategoryName = @p1 Where CategoryId = @p2;", connection);
            command.Parameters.AddWithValue("@p1", txtBoxCategoryName.Text);
            command.Parameters.AddWithValue("@p2", txtBoxCategoryID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            command.Transaction.Commit();
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region
            connection.Open();
            SqlCommand command = new SqlCommand("Select Count(*) From Category;", connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                lblCategoryNumber.Text = reader[0].ToString();
            }
            connection.Close();
            #endregion

            #region
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select MovieName From Movie Where MovieIMBD = (Select Max(MovieIMBD) from Movie);", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while(reader2.Read())
            {
                lblBestMovie.Text = reader2[0].ToString();
            }
            reader2.Close();
            connection.Close();
            #endregion

            #region
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select * From Category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command3);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboCategory.DisplayMember = "CategoryName";
            comboCategory.ValueMember = "CategoryID";
            comboCategory.DataSource = dt;
            connection.Close();
            #endregion
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select MovieName, MovieIMBD, MovieDuration, CategoryName From Movie Inner Join Category On Movie.MovieCategory = Category.CategoryId;", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridMovie.DataSource = dt;
        }

        private void btnMovieList_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Movie", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridMovie.DataSource = dt;
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            connection.BeginTransaction();
            SqlCommand command = new SqlCommand("Insert Into Movie(MovieName, MovieIBDM, MovieDuration, MovieCategory) Values(@p1, @p2, @p3, @p4);", connection);
            command.Parameters.AddWithValue("@p1", txtBoxMovieName.Text);
            command.Parameters.AddWithValue("@p2", txtBoxImdbPoint.Text);
            command.Parameters.AddWithValue("@p3", txtBoxMovieDuration.Text);
            command.Parameters.AddWithValue("@p4", comboCategory.SelectedValue);
            var degisenKayitSayisi = command.ExecuteNonQuery();
            MessageBox.Show($"Film kaydedildi. Değişen kayıt sayısı {degisenKayitSayisi}", "Bilgi.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            command.Transaction.Commit();
            connection.Close();
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            connection.Open();
            connection.BeginTransaction();
            SqlCommand command = new SqlCommand("Delete From Movie Where MovieId = @p1", connection);
            command.Parameters.AddWithValue("@p1", txtBoxMovieID.Text);
            var degisenKayitSayisi = command.ExecuteNonQuery();
            MessageBox.Show($"Film silindi. Değişen kayıt sayısı {degisenKayitSayisi}", "Bilgi.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            command.Transaction.Commit();
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            connection.BeginTransaction();
            SqlCommand command = new SqlCommand("Update Movie Set MovieName=@p1, MovieIMBD = @p2, MovieDuration = @p3 MovieCategory = @p4 Where MovieID = @p5", connection);
            command.Parameters.AddWithValue("@p1", txtBoxMovieID.Text);
            command.Parameters.AddWithValue("@p2", txtBoxImdbPoint.Text);
            command.Parameters.AddWithValue("@p3", txtBoxMovieDuration.Text);
            command.Parameters.AddWithValue("@p4", comboCategory.SelectedValue);
            command.Parameters.AddWithValue("@p5", txtBoxMovieID.Text);
            var degisenKayitSayisi = command.ExecuteNonQuery();
            MessageBox.Show($"Film güncellendi. Değişen kayıt sayısı {degisenKayitSayisi}", "Bilgi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            command.Transaction.Commit();
            connection.Close();
        }
    }
}