using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {

        public static Player player1,player2;
        public static VsComputer cp;
        public static bool vsPc;
        public static string rdb;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   groupBox1.Visible = true;
            groupBox2.Visible = false;
           
        }

        private void username1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username1.Clear();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            Form2.computer = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οδηγίες παιχνιδιού: Σχημάτισε οριζοντία ή κάθετη ή διγώνια σειρά που να αποτελείται από 5 συνεχόμενα Χ ή Ο ανάλογα με την επιλογή του γραμματός σου!!!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {   player1 = new Player(); //analoga me tis epiloges tou xrhsth pername mesw twn classewn to onoma xrhsth pou epelekse kai to ti 
            if (username1.Text != "")   // tha paizei o ypologisths stis kinhseis tou kai ti o xrhsths (x h o)
            {
                player1.setUser(username1.Text.ToString());
            }
            else
            {
                if (radioButton1.Checked == true)
                    player1.setUser("X");
                else if (radioButton2.Checked == true)
                    player1.setUser("O");
            }
            if (radioButton1.Checked == true)
                rdb = radioButton1.Text.ToString();
            else if (radioButton2.Checked == true)
                rdb = radioButton2.Text.ToString();
         //
            cp = new VsComputer();
            if (radioButton1.Checked == true)
                cp.setPl("O");
            else if (radioButton2.Checked == true)
                cp.setPl("X");
            ///

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {   Form2.computer = false; //paixnidi 1vs1 mesw ths klasshs pername ta onomata pou dialeksan oi xrhstes h ta defautl an den epeleksan kapoia onoma
            player1 = new Player();
            if (username1.Text != "" )
            {
                player1.setUser(username1.Text.ToString());
            }
           else
            {
                 player1.setUser("X");
            }
            player2 = new Player();
            if (username2.Text != "")
            {
                player2.setUser(username2.Text.ToString());
            }
            else
            {
                player2.setUser("O");
            }
            
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
