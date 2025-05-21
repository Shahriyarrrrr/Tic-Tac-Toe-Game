using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        Boolean check;
        int add=0;

        void enable_false()
        {
            button1.Enabled= false;
            button2.Enabled= false;
            button3.Enabled= false;
            button4.Enabled= false;
            button5.Enabled= false;
            button6.Enabled= false;
            button7.Enabled= false;
            button8.Enabled= false;
            button9.Enabled= false;

        }
        void win()
        {

            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;


                
                add = int.Parse(textBox1.Text);
                textBox1.Text= Convert.ToString(add+1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;


                
                add = int.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;


                add = int.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;


                
                add = int.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;


                
                add = int.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;


                
                add = int.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;


                
                add = int.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;


                
                add = int.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player1...!!");
                enable_false();
            }

            //now if 'O' is inserted in the button.....
            
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;


                
                add = int.Parse(textBox2.Text);
                textBox2.Text = Convert.ToString(add + 1);
                MessageBox.Show("The Winner is Player2...!!");
                enable_false();
            }
           
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //none
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check == false)
            {
                button1.Text = "X";
                check = true;
            }
            else
            {
                button1.Text = "O";
                check = false;
            }
            win();
            button1.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button9.Text = "X";
                check = true;
            }
            else
            {
                button9.Text = "O";
                check = false;
            }
            win();
            button9.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button2.Text = "X";
                check = true;
            }
            else
            {
                button2.Text = "O";
                check = false;
            }
            win();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button3.Text = "X";
                check = true;
            }
            else
            {
                button3.Text = "O";
                check = false;
            }
            win();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button4.Text = "X";
                check = true;
            }
            else
            {
                button4.Text = "O";
                check = false;
            }
            win();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button5.Text = "X";
                check = true;
            }
            else
            {
                button5.Text = "O";
                check = false;
            }
            win();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button6.Text = "X";
                check = true;
            }
            else
            {
                button6.Text = "O";
                check = false;
            }
            win();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button7.Text = "X";
                check = true;
            }
            else
            {
                button7.Text = "O";
                check = false;
            }
            win();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button8.Text = "X";
                check = true;
            }
            else
            {
                button8.Text = "O";
                check = false;
            }
            win();
            button8.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Reset game

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            textBox1.Text = "0";
            textBox2.Text = "0";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //play again button

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //player 1 box

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //player 2 box
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
