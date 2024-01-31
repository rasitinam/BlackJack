using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace adsascxzcxz
{
    public partial class Login : Form
    {
        public string enteredUsername;
        public string enteredPassword;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
        private bool ValidateUser(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I0QCVD5;Initial Catalog=blackjack;Integrated Security=True;TrustServerCertificate=True"))
            {
                baglanti.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM player WHERE username = @Username AND password = @Password", baglanti))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)command.ExecuteScalar();
                    isValid = userCount > 0;
                }
            }
            return isValid;
        }
        public string GetBalance(string enteredUsername, string enteredPassword)
        {
            string balance = null;

            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I0QCVD5;Initial Catalog=blackjack;Integrated Security=True;TrustServerCertificate=True"))
            {
                baglanti.Open();

                using (SqlCommand command1 = new SqlCommand("SELECT balance FROM player WHERE username = @Username AND password = @Password", baglanti))
                {
                    command1.Parameters.AddWithValue("@Username", enteredUsername);
                    command1.Parameters.AddWithValue("@Password", enteredPassword);

                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balance = reader["balance"].ToString();
                        }
                    }
                }
            }
            return balance;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Label betsql = new Label();
            enteredUsername = username.Text;
            enteredPassword = password.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateUser(enteredUsername, enteredPassword))
            {
                string balance = GetBalance(enteredUsername, enteredPassword);
                BET bet = new BET(balance);
                int balance1 = int.Parse(balance);
                Form1 form1 = new Form1(balance1);
                Globals.Username = username.Text;
                this.Hide();

                Label labelusername = new Label();
                Font labelfont = new Font("Bahnschrift", 24);
                Font balancefont = new Font("Bahnschrift Condensed", 12.25f, FontStyle.Regular);

                labelusername.Font = labelfont;
                labelusername.Size = new System.Drawing.Size(200, 50);
                labelusername.Location = new System.Drawing.Point(10, 10);
                labelusername.Text = enteredUsername;
                form1.Controls.Add(labelusername);

                betsql.Font = balancefont;
                betsql.Size = new System.Drawing.Size(200, 50);
                betsql.Location = new System.Drawing.Point(27, 412);
                bet.Controls.Add(betsql);
                bet.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
