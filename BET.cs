using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace adsascxzcxz
{
    public partial class BET : Form
    {
        public bool bool100 = false;
        public bool bool500 = false;
        public bool bool1000 = false;
        public bool bool2500 = false;
        public bool bool5000 = false;
        public bool bool10k = false;
        public int balance = 0;
        public List<int> betlist3 = new List<int>();
        public List<int> betlist2 = new List<int>();
        public List<int> betlist1 = new List<int>();
        public BET(string balanceFromForm1)
        {
            InitializeComponent();
            balance = int.Parse(balanceFromForm1);
            Print(betlist1, betlist2, betlist3);
        }

        private void BET_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (betlist1.Sum() == 0 || betlist2.Sum() == 0 || betlist3.Sum() == 0)
            {
                MessageBox.Show("Please Place Your Bet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int bet1 = betlist1.Sum();
                int bet2 = betlist2.Sum();
                int bet3 = betlist3.Sum();
                Form1 frm = new Form1(balance);
                frm.bet1 = bet1;
                frm.bet2 = bet2;
                frm.bet3 = bet3;
                frm.balance = balance;
                this.Hide();
                frm.Show();
            }
        }
        public int betbalance(int q, List<int> list)
        {
            if (balance >= q)
            {
                list.Add(q);
                balance -= q;
            }

            return q;
        }
        public int Print(List<int> l, List<int> l1, List<int> l2)
        {
            int toplambahis = l.Sum() + l1.Sum() + l2.Sum();
            label5.Text = balance.ToString();
            label4.Text = Convert.ToString(toplambahis);
            label6.Text = l.Sum().ToString();
            label7.Text = l1.Sum().ToString();
            label8.Text = l2.Sum().ToString();
            return toplambahis;
        }
        private void yuvarlakButon12_Click(object sender, EventArgs e)
        {
            if (bool100 == true) { betbalance(100, betlist3); }
            if (bool500 == true) { betbalance(500, betlist3); }
            if (bool1000 == true) { betbalance(1000, betlist3); }
            if (bool2500 == true) { betbalance(2500, betlist3); }
            if (bool5000 == true) { betbalance(5000, betlist3); }
            if (bool10k == true) { betbalance(10000, betlist3); }
            Print(betlist1, betlist2, betlist3);
        }

        private void chip100_Click(object sender, EventArgs e)
        {
            bool100 = true;
            bool500 = false;
            bool1000 = false;
            bool2500 = false;
            bool5000 = false;
            bool10k = false;
        }

        private void chip500_Click(object sender, EventArgs e)
        {
            bool100 = false;
            bool500 = true;
            bool1000 = false;
            bool2500 = false;
            bool5000 = false;
            bool10k = false;
        }

        private void chip1000_Click(object sender, EventArgs e)
        {
            bool100 = false;
            bool500 = false;
            bool1000 = true;
            bool2500 = false;
            bool5000 = false;
            bool10k = false;
        }

        private void chip2500_Click(object sender, EventArgs e)
        {
            bool100 = false;
            bool500 = false;
            bool1000 = false;
            bool2500 = true;
            bool5000 = false;
            bool10k = false;
        }

        private void chip5000_Click(object sender, EventArgs e)
        {
            bool100 = false;
            bool500 = false;
            bool1000 = false;
            bool2500 = false;
            bool5000 = true;
            bool10k = false;
        }

        private void chip10k_Click(object sender, EventArgs e)
        {
            bool100 = false;
            bool500 = false;
            bool1000 = false;
            bool2500 = false;
            bool5000 = false;
            bool10k = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            balance += betlist3.Sum();
            betlist3.Clear();
            balance += betlist2.Sum();
            betlist2.Clear();
            balance += betlist1.Sum();
            betlist1.Clear();
            Print(betlist1, betlist2, betlist3);
        }

        private void yuvarlakButon11_Click(object sender, EventArgs e)
        {
            if (bool100 == true) { betbalance(100, betlist2); }
            if (bool500 == true) { betbalance(500, betlist2); }
            if (bool1000 == true) { betbalance(1000, betlist2); }
            if (bool2500 == true) { betbalance(2500, betlist2); }
            if (bool5000 == true) { betbalance(5000, betlist2); }
            if (bool10k == true) { betbalance(10000, betlist2); }
            Print(betlist1, betlist2, betlist3);
        }

        private void yuvarlakButon10_Click(object sender, EventArgs e)
        {
            if (bool100 == true) { betbalance(100, betlist1); }
            if (bool500 == true) { betbalance(500, betlist1); }
            if (bool1000 == true) { betbalance(1000, betlist1); }
            if (bool2500 == true) { betbalance(2500, betlist1); }
            if (bool5000 == true) { betbalance(5000, betlist1); }
            if (bool10k == true) { betbalance(10000, betlist1); }
            Print(betlist1, betlist2, betlist3);
        }
    }
}
