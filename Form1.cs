using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace adsascxzcxz
{
    public partial class Form1 : Form
    {
        public Form1(int toplambet)
        {
            InitializeComponent();
        }
        public List<int> dealer = new List<int>();
        public List<int> player1 = new List<int>();
        public List<int> playersplit1 = new List<int>();
        public List<int> playersplit2 = new List<int>();
        public List<int> player2 = new List<int>();
        public List<int> player2split1 = new List<int>();
        public List<int> player2split2 = new List<int>();
        public List<int> player3 = new List<int>();
        public List<int> player3split1 = new List<int>();
        public List<int> player3split2 = new List<int>();
        public List<int> nulll = new List<int>();
        public bool dealer1 = false;
        public bool player11 = true;
        public bool playersplit11 = false;
        public bool playersplit22 = false;
        public bool player22 = false;
        public bool player2split11 = false;
        public bool player2split22 = false;
        public bool player33 = false;
        public bool player3split11 = false;
        public bool player3split22 = false;
        public int betplayer1= 0;
        public int betplayer11 = 0;
        public int betplayer12 = 0;
        public int bet2player1 = 0;
        public int bet2player11 = 0;
        public int bet2player12 = 0;
        public int bet3player1 = 0;
        public int bet3player11 = 0;
        public int bet3player12 = 0;
        public int betdealer= 0;
        public int nullint = 999999999;
        public int winbet = 0;
        Random rnd = new Random();
        public int bet = 0;
        public string enteredUsernamee;
        public int bet1 { get; set; }
        public int bet2 { get; set; }

        public int bet3 { get; set; }
        public int bet4 { get; set; }
        
        public int balance { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            bettext1.Text = bet1.ToString();
            bettext2.Text = bet2.ToString();
            bettext3.Text = bet3.ToString();
            balancetext.Text = balance.ToString();
            nulll.Add(5); nulll.Add(2);
            AddCard(dealertext, dealer);
            AddCard(dealertext, dealer);
            dealertext.Text = dealer.First().ToString() + " *";
            AddCard(player1text, player1);
            AddCard(player1text, player1);
            AddCard(player2text, player2);
            AddCard(player2text, player2);
            AddCard(player3text, player3);
            AddCard(player3text, player3);
            if (player1.Sum() == player1.First() * 2)
            {
                split.Show();
            }
            if (bet1 < balance)
            {
                btndouble.Show();
            }
            else
            {
                btndouble.Hide();
            }
        }
        public void Dealer()
        {
            winlosescreen.Visible = true;
            dealertext.Text = "";
            foreach (int i in dealer)
            {
                dealertext.Text += i.ToString() + " ";
            }

            while (dealer.Sum() < 17)
            {
                AddCard(dealertext, dealer);
            }
            if (dealer.Sum() < 22) { }
            else { betdealer += 1; }
            Bet(betplayer1, bet1, player1);
            Bet(betplayer11, bet1, playersplit1);
            Bet(betplayer12, bet1, playersplit2);
            Bet(bet2player1, bet2, player2);
            Bet(bet2player11, bet2, player2split1);
            Bet(bet2player12, bet2, playersplit2);
            Bet(bet3player1, bet3, player3);
            Bet(bet3player11, bet3, player3split1);
            Bet(bet3player12, bet3, player3split2);
            button1.Visible = true;
            winlosescreen.Location = new System.Drawing.Point(500, 324);
            winlosescreen.Text = winbet.ToString()+"$ WİN";
        }
        public int Bet(int qbetplayer,int qbet,List<int>qplayerlist) 
        {
            if (qbetplayer == 1)
            {
                if (betdealer == 1)
                {
                    winbet += qbet * 2;
                }
                else
                {
                    if (qplayerlist.Sum() < dealer.Sum()) { }
                    if (qplayerlist.Sum() > dealer.Sum()) { qbetplayer += 2; winbet += qbet * 2; }
                    if (qplayerlist.Sum() == dealer.Sum()) { qbetplayer += 1; winbet += qbet; }
                }
            }
            return winbet;
        }
        public void AddCard(Label etiket, List<int> liste)
        {
            etiket.Text = "";
            liste.Add(rnd.Next(1, 12));
            foreach (int i in liste)
            {
                etiket.Text += i.ToString() + " ";
            }
        }
        public int Hand(int a)
        {
            int newX = a;
            int newY = hand.Location.Y;
            hand.Location = new System.Drawing.Point(newX, newY);
            return a;
        }
        public bool SıraDevrediciNotPic(ref bool bool1, ref bool bool2,int i)
        {
            if (i < balance) 
            {
                btndouble.Show();
            }
            else 
            {
                btndouble.Hide();
            }
            if (i < balance)
            {
                split.Show();
            }
            else
            {
                split.Hide();
            }
            bool1 = false; bool2 = true;
            return bool2;
        }
        public bool SıraDevredici(ref bool booldeğer, ref bool booldeğer2, ref PictureBox pic1, ref PictureBox pic2, List<int> liste1,int i)
        {
            if (liste1.Sum() == liste1.First() * 2)
            {
                if (i < balance)
                {
                    split.Show();
                }
                else
                {
                    split.Hide();
                }
            }
            if (i < balance)
            {
                btndouble.Show();
            }
            else
            {
                btndouble.Hide();
            }
            pic1.Visible = false;
            pic2.Visible = true;
            booldeğer = false; booldeğer2 = true;
            return booldeğer2;
        }

        public void hit_Click(object sender, EventArgs e)
        {
            btndouble.Hide();
            if (player3split22 == true)
            {
                if (player3split2.Sum() < 22)
                {
                    AddCard(player32text, player3split2);
                }
                if (player3split2.Sum() >= 22)
                {
                    hand.Hide();
                    groupBox1.Hide();
                    player3boom.Visible = true;
                    SıraDevredici(ref player3split22, ref dealer1, ref pictureBox2, ref pictureBox3, nulll,bet4);
                }
            }
            if (player3split11 == true)
            {
                if (player3split1.Sum() < 22)
                {
                    AddCard(player31text, player3split1);
                }
                if (player3split1.Sum() >= 22)
                {
                    Hand(139);
                    player3boom.Visible = true;
                    SıraDevredici(ref player3split11, ref player3split22, ref pictureBox2, ref pictureBox3, nulll,bet4);
                }
            }
            if (player33 == true)
            {
                if (player3.Sum() < 22)
                {
                    AddCard(player3text, player3);
                }
                if (player3.Sum() >= 22)
                {
                    hand.Hide();
                    groupBox1.Hide();
                    player3boom.Visible = true;
                    SıraDevredici(ref player33, ref dealer1, ref pictureBox4, ref nullpicturebox, nulll,bet4);
                    Dealer();
                }
            }
            if (player2split22 == true)
            {
                if (player2split2.Sum() < 22)
                {
                    AddCard(player22text, player2split2);
                }
                if (player2split2.Sum() >= 22)
                {
                    Hand(194);
                    player2boom.Visible = true;
                    SıraDevredici(ref player2split22, ref player33, ref pictureBox3, ref pictureBox4, player3,bet3);
                }
            }
            if (player2split11 == true)
            {
                if (player2split1.Sum() < 22)
                {
                    AddCard(player21text, player2split1);
                }
                if (player2split1.Sum() >= 22)
                {
                    Hand(448);
                    player2boom.Visible = true;
                    SıraDevredici(ref player2split11, ref player2split22, ref pictureBox2, ref pictureBox3, nulll,bet4);
                }
            }
            if (player22 == true)
            {
                if (player2.Sum() < 22)
                {
                    AddCard(player2text, player2);
                }
                if (player2.Sum() >= 22)
                {
                    Hand(194);
                    player2boom.Visible = true;
                    SıraDevredici(ref player22, ref player33, ref pictureBox3, ref pictureBox4, player3,bet3);
                }
            }
            if (playersplit22 == true)
            {
                if (playersplit2.Sum() < 22)
                {
                    AddCard(player12text, playersplit2);
                }
                if (playersplit2.Sum() >= 22)
                {
                    Hand(501);
                    player1boom.Visible = true;
                    SıraDevredici(ref playersplit22, ref player22, ref pictureBox2, ref pictureBox3, player2,bet2);
                }
            }
            if (playersplit11 == true)
            {
                if (playersplit1.Sum() < 22)
                {
                    AddCard(player11text, playersplit1);
                }
                if (playersplit1.Sum() >= 22)
                {
                    Hand(764);
                    player1boom.Visible = true;
                    SıraDevredici(ref playersplit11, ref playersplit22, ref pictureBox2, ref nullpicturebox, nulll,bet4);
                }
            }
            if (player11 == true)
            {
                if (player1.Sum() < 22)
                {
                    AddCard(player1text, player1);
                }
                if (player1.Sum() >= 22)
                {
                    Hand(501);
                    player1boom.Visible = true;
                    SıraDevredici(ref player11, ref player22, ref pictureBox2, ref pictureBox3, player2,bet2);
                }
            }
        }
        public void Stand()
        {
            if (player3split22 == true)
            {
                bet3player12 += 1;
                pictureBox4.Hide();
                hand.Hide();
                SıraDevrediciNotPic(ref player3split22, ref dealer1,nullint);
                Dealer();
                groupBox1.Hide();

            }
            if (player3split11 == true)
            {
                bet3player11 += 1;
                bet3player1-= 1;
                Hand(143);
                SıraDevrediciNotPic(ref player3split11, ref player3split22,nullint);
            }
            if (player33 == true)
            {
                bet3player1 += 1;

                hand.Hide();
                SıraDevredici(ref player33, ref dealer1, ref pictureBox4, ref nullpicturebox, nulll,bet4);
                Dealer();
                groupBox1.Hide();
            }
            if (player2split22 == true)
            {
                bet2player12 += 1;

                Hand(194);
                SıraDevredici(ref player2split22, ref player33, ref pictureBox3, ref pictureBox4, player3, bet3);
            }
            if (player2split11 == true)
            {
                bet2player11 += 1;
                bet2player1 -= 1;

                Hand(448);
                SıraDevrediciNotPic(ref player2split11, ref player2split22,nullint);
            }
            if (player22 == true)
            {
                bet2player1 += 1;
                Hand(194);
                SıraDevredici(ref player22, ref player33, ref pictureBox3, ref pictureBox4, player3,bet3);
            }
            if (playersplit22 == true)
            {
                betplayer12 += 1;
                Hand(501);
                SıraDevredici(ref playersplit22, ref player22,ref pictureBox2,ref pictureBox3,player2, bet2);
            }
            if (playersplit11 == true)
            {
                betplayer11 += 1;
                betplayer1 -= 1;
                Hand(764);
                SıraDevrediciNotPic(ref playersplit11, ref playersplit22,nullint);
            }
            if (player11 == true)
            {
                betplayer1 += 1;
                Hand(501);
                SıraDevredici(ref player11, ref player22, ref pictureBox2, ref pictureBox3, player2,bet2);
            }
        }
        public void stand_Click(object sender, EventArgs e)
        {
            Stand();
        }
        public void splitstart(Label p, Label p1, Label p2, List<int> l, List<int> l1, List<int> l2)
        {
            p.Visible = false;
            p1.Visible = true;
            p2.Visible = true;
            l1.Add(l.First());
            l2.Add(l.First());
            AddCard(p1, l1);
            AddCard(p2, l2);
        }
        public void split_Click(object sender, EventArgs e)
        {
            btndouble.Hide();
            if (player33 == true)
            {
                balance -= bet3;
                bet3 *= 2;
                balancetext.Text = balance.ToString();
                bettext3.Text = bet3.ToString();
                if (player3.Sum() == player3.First() * 2)
                {
                    Hand(277);
                    player33 = false;
                    player3split11 = true;
                    player3split22 = false;
                    splitstart(player3text, player31text, player32text, player3, player3split1, player3split2);
                }
                split.Hide();
            }
            if (player22 == true)
            {
                balance -= bet2;
                bet2 *= 2;
                balancetext.Text = balance.ToString();
                bettext2.Text = bet2.ToString();
                if (player2.Sum() == player2.First() * 2)
                {
                    Hand(581);
                    player22 = false;
                    player2split11 = true;
                    player2split22 = false;
                    splitstart(player2text, player21text, player22text, player2, player2split1, player2split2);
                }
                split.Hide();
            }
            if (player11 == true)
            {
                balance -= bet1;
                bet1 *= 2;
                balancetext.Text = balance.ToString();
                bettext1.Text = bet1.ToString();
                if (player1.Sum() == player1.First() * 2)
                {
                    Hand(913);
                    player11 = false;
                    playersplit11 = true;
                    playersplit22 = false;
                    splitstart(player1text, player11text, player12text, player1, playersplit1, playersplit2);
                }
                split.Hide();
            }
        }

        private void esc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndouble_Click(object sender, EventArgs e)
        {
            if (player33 == true)
            {
                balance -= bet3;
                bet3 *= 2;
                balancetext.Text = balance.ToString();
                bettext3.Text = bet3.ToString();
                AddCard(player3text, player3);
                Stand();
                if (player3.Sum() > 21) { bet3player1 -= 2; }

            }
            if (player22 == true)
            {
                balance -= bet2;
                bet2 *= 2;
                balancetext.Text = balance.ToString();
                bettext2.Text = bet2.ToString();
                AddCard(player2text, player2);
                Stand();
                if (player2.Sum() > 21) { bet2player1 -= 2; }


            }
            if (player11 == true)
            {
                balance -= bet1;
                bet1 *= 2;
                balancetext.Text = balance.ToString();
                bettext1.Text = bet1.ToString();
                AddCard(player1text, player1);
                Stand();
                if (player1.Sum() > 21) { betplayer1 -= 2; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string q = (balance += winbet).ToString(); ; 
            BET betttt = new BET(q);
            string enteredUsername = Globals.Username;
            int newBalance = balance;
            using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I0QCVD5;Initial Catalog=blackjack;Integrated Security=True;TrustServerCertificate=True"))
            {
                baglanti.Open();

                using (SqlCommand command1 = new SqlCommand("UPDATE player SET balance=@newBalance WHERE username=@enteredUsername", baglanti))
                {
                    command1.Parameters.AddWithValue("@enteredUsername", enteredUsername);
                    command1.Parameters.AddWithValue("@newBalance", newBalance);
                    command1.ExecuteNonQuery();
                }
            }
            betttt.Show();
            this.Hide();
        }
    }
}
