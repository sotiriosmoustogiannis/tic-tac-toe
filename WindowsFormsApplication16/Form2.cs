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
    public partial class Form2 : Form
    {   public static bool computer ;
        bool who,player;
        int Xsc, Osc,buts;
        Player p;
        public Form2()
        {
            InitializeComponent();
            p = new Player();
           
        }
       
        private void ChechForWinner()
        {
            bool winner = false;
            // elegxos gia nikhth stis orizonties steiles
            if (button1.Text == button23.Text && button23.Text == button22.Text && button22.Text == button21.Text && button21.Text == button20.Text && button1.Enabled == false)
                winner = true;
            if (button19.Text == button15.Text && button15.Text == button11.Text && button11.Text == button9.Text && button9.Text == button8.Text && button19.Enabled == false)
                winner = true;
            if (button18.Text == button14.Text && button14.Text == button10.Text && button10.Text == button7.Text && button7.Text == button6.Text && button18.Enabled == false)
                winner = true;
            if (button17.Text == button13.Text && button13.Text == button5.Text && button5.Text == button3.Text && button3.Text == button4.Text && button17.Enabled == false)
                winner = true;
            if (button16.Text == button12.Text && button12.Text == button2.Text && button2.Text == button24.Text && button24.Text == button25.Text && button16.Enabled == false)
                winner = true;
            //elegoxos gia nikhth stis kathetes steiles
            if (button1.Text == button19.Text && button19.Text == button18.Text && button18.Text == button17.Text && button17.Text == button16.Text && button1.Enabled == false)
                winner = true;
            if (button23.Text == button15.Text && button15.Text == button14.Text && button14.Text == button13.Text && button13.Text == button12.Text && button23.Enabled == false)
                winner = true;
            if (button22.Text == button11.Text && button11.Text == button10.Text && button10.Text == button5.Text && button5.Text == button2.Text && button22.Enabled == false)
                winner = true;
            if (button21.Text == button9.Text && button9.Text == button7.Text && button7.Text == button3.Text && button3.Text == button24.Text && button21.Enabled == false)
                winner = true;
            if (button20.Text == button8.Text && button8.Text == button6.Text && button6.Text == button4.Text && button4.Text == button25.Text && button20.Enabled == false)
                winner = true;
            //elegxos gia nikhth stis 2 diagwnious
            if (button1.Text == button15.Text && button15.Text == button10.Text && button10.Text == button3.Text && button3.Text == button25.Text && button1.Enabled == false)
                winner = true;
            if (button20.Text == button9.Text && button9.Text == button10.Text && button10.Text == button13.Text && button13.Text == button16.Text && button20.Enabled == false)
                winner = true;
        
            who = !who; //metavlhth gia na gnwrizoume poios paixths epaikse telytaios ara kerdise
            if (computer)
                player = !player;
            if (winner) // elegxos an yparxei nikhths 
            {
                if (!player) //elegxos poios kerdise wste na perastei to score
                {
                    MessageBox.Show("O wins");
                    Osc++;
                    O_sc.Text = null;
                    O_sc.AppendText(Osc.ToString());
                    NewGame();
                }
                else
                {
                    Xsc++;
                    X_sc.Text = null;
                    X_sc.AppendText(Xsc.ToString());
                    NewGame();
                    MessageBox.Show("X wins");
                }

            }

        }
        private void NewGame() //synarthsh gia katharismo twnw koumpiwn kai enarksh neou pexnidiou
        { foreach (Control button in this.Controls)
            {
                Control b = button;    //gia kathe control ths formas pou einai buuton to energopoihmou kai to katharizoume
                if (b is Button)
                {
                    b.Enabled = true;
                    b.Text = null;
                }
            }
        }
        public void VsComputer() //synarthsh gia paixnidi enadiwn tou ypologisth me random epilogh koumpiwn otan paizei o ypologisths
        {
            string RndB = null;
            Random x = new Random();
            int X = x.Next(1, 25);
            bool flag = false;
            Console.WriteLine("to x einai: " + X);
            RndB = "button" + X.ToString(); //string apothikeys tous random button pou dhmiourghsame
           
            foreach (Control button in this.Controls) //loopa h opoia gia kathe koumpi ths formas an einai energopoihmeno kai an einai ayto 
            { 
                Control b = button;
                if (b is Button )                     // pou dialkese o ypoloigths paizei X h O analoga thn epilogh tou paixth kata thn eisodo sto paixnidi
                {
                    
                    if (!b.Enabled) continue;


                    if (b.Name == RndB)
                    {
                        b.Enabled = false;
                        
                        if (player)
                        {
                            b.Text = Form1.cp.getPl();
                            flag = true;
                        }
                        else
                        {
                            b.Text = Form1.cp.getPl();
                            flag = true;
                        }
                        player = !player;
                        ChechForWinner(); //elegxos gia an yparxei nikhths meta apo kathe kinhsh tou ypologisth
                        
                    }
                }
            }
            if (!flag)
            {
                VsComputer(); //an to koumpi pou dhmiourgithike eixe idh kinhsh ksanatrexoume thn synarthsh apo thn arxh gia na elegxthoun ek neou ola ta koumpia
            }
            RndB = null;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (computer)      //perasma onomatwn analoga thn epilogh tou xrhsth stho menou
            {
               label1.Text = Form1.player1.getUser();
                VsComputer();
            }
           else
            {
                label2.Text = Form1.player2.getUser();
                label1.Text = Form1.player1.getUser();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
            if (computer)         //analoga to ti kinhsh exei epileksei o paixths sinete h katalhlh edolh gia x h O kata thn kinhsh tou
                p.Play2(button1, player, Form1.rdb.ToString());
            else
                p.Play(button1, player);

            ChechForWinner(); //elegxos gia nikhth meta apo kathe kinhsh
            player = !player;
            if (computer) // meta apo kathe pathma tou koumpiou an h epilogh einai vsComputer trexoume thn synarthsh gia na kanei kinhsh o ypologisths
            {
                VsComputer();
               
            }
        }

        

        private void button23_Click_1(object sender, EventArgs e)
        {
            button23.Enabled = false;
           
            if (computer)
                p.Play2(button23, player, Form1.rdb.ToString());
            else
                p.Play(button23, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            button15.Enabled = false;
            
            if (computer)
                p.Play2(button15, player, Form1.rdb.ToString());
            else
                p.Play(button15, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            button22.Enabled = false;
            
            if (computer)
                p.Play2(button22, player, Form1.rdb.ToString());
            else
                p.Play(button22, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            button21.Enabled = false;
           
            if (computer)
                p.Play2(button21, player, Form1.rdb.ToString());
            else
                p.Play(button21, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            button20.Enabled = false;
           
            if (computer)
                p.Play2(button20, player, Form1.rdb.ToString());
            else
                p.Play(button20, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
               
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            button19.Enabled = false;
            
            if (computer)
                p.Play2(button19, player, Form1.rdb.ToString());
            else
                p.Play(button19, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            button11.Enabled = false;
            
            if (computer)
                p.Play2(button11, player, Form1.rdb.ToString());
            else
                p.Play(button11, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
               
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button9.Enabled = false;
            
            if (computer)
                p.Play2(button9, player, Form1.rdb.ToString());
            else
                p.Play(button9, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
               
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button8.Enabled = false;
            
            if (computer)
                p.Play2(button8, player, Form1.rdb.ToString());
            else
                p.Play(button8, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            button18.Enabled = false;
            
            if (computer)
                p.Play2(button18, player, Form1.rdb.ToString());
            else
                p.Play(button18, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
               
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            button14.Enabled = false;
            
            if (computer)
                p.Play2(button14, player, Form1.rdb.ToString());
            else
                p.Play(button14, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button10.Enabled = false;
            
            if (computer)
                p.Play2(button10, player, Form1.rdb.ToString());
            else
                p.Play(button10, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.Enabled = false;
            
            if (computer)
                p.Play2(button7, player, Form1.rdb.ToString());
            else
                p.Play(button7, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.Enabled = false;
            
            if (computer)
                p.Play2(button6, player, Form1.rdb.ToString());
            else
                p.Play(button6, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            button17.Enabled = false;
            
            if (computer)
                p.Play2(button17, player, Form1.rdb.ToString());
            else
                p.Play(button17, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            button13.Enabled = false;
          
            if (computer)
                p.Play2(button13, player, Form1.rdb.ToString());
            else
                p.Play(button13, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
               
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Enabled = false;
            
            if (computer)
                p.Play2(button5, player, Form1.rdb.ToString());
            else
                p.Play(button5, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = false;
            
            if (computer)
                p.Play2(button3, player, Form1.rdb.ToString());
            else
                p.Play(button3, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
               
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Enabled = false;
           
            if (computer)
                p.Play2(button4, player, Form1.rdb.ToString());
            else
                p.Play(button4, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
               
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            button16.Enabled = false;
            
            if (computer)
                p.Play2(button16, player, Form1.rdb.ToString());
            else
                p.Play(button16, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            button12.Enabled = false;
            
            if (computer)
                p.Play2(button12, player, Form1.rdb.ToString());
            else
                p.Play(button12, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
            if (computer)
                p.Play2(button2, player, Form1.rdb.ToString());
            else
                p.Play(button2, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

       

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

      

        private void button24_Click_1(object sender, EventArgs e)
        {
            button24.Enabled = false;
            
            if (computer)
                p.Play2(button24, player, Form1.rdb.ToString());
            else
                p.Play(button24, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
              
            }
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            button25.Enabled = false;
            
            if (computer)
                p.Play2(button25, player, Form1.rdb.ToString());
            else
                p.Play(button25, player);

            ChechForWinner();
            player = !player;
            if (computer)
            {
                VsComputer();
             
            }
        }

    }
    
    
}

