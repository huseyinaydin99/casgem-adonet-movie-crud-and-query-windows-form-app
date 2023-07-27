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
    public partial class FormLogin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-13123BI; Initial Catalog=CasgemDBMovie; Integrated Security=true");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Admin Where Username = @p1 and Password = @p2", connection);
            cmd.Parameters.AddWithValue("@p1", txtBoxUserName.Text);
            cmd.Parameters.AddWithValue("@p2", txtBoxPassword.Text);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.BackColor = Color.FromArgb(rnd.Next(10,250), rnd.Next(10, 250), rnd.Next(10, 250));
        }
    }
}
