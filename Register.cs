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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace adsascxzcxz
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I0QCVD5;Initial Catalog=blackjack;Integrated Security=True;TrustServerCertificate=True");

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username.Text) || String.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Username or password cannot be empty !!!");
            }
            else
            {
                baglanti.Open();
                using (SqlCommand checkUsernameCommand = new SqlCommand("SELECT COUNT(*) FROM player WHERE username = @p1", baglanti))
                {
                    checkUsernameCommand.Parameters.AddWithValue("@p1", username.Text);
                    int existingUserCount = (int)checkUsernameCommand.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        baglanti.Close();
                        MessageBox.Show("This username is already in use!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }
                baglanti.Close();
          
                baglanti.Open();
                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO player (username, password,balance) VALUES (@p1, @p2,10000)", baglanti))
                {
                    insertCommand.Parameters.AddWithValue("@p1", username.Text);
                    insertCommand.Parameters.AddWithValue("@p2", password.Text);
                    insertCommand.ExecuteNonQuery();
                    baglanti.Close();
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
            }
        }
    }
}
