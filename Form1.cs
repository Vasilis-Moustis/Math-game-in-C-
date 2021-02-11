using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_2
{

    public partial class MathForm : Form
    {
		int number1 = 1;
		int number2 = 1;
		int number3 = 1;
		int number4 = 1;
		int number5 = 1;
		int number6 = 1;
		int number7 = 1;
		int number8 = 1;

		Timer t = new Timer();

		Boolean Start;

        Random random_number = new Random();
         
        public MathForm()
        {
            InitializeComponent();
			button2.Visible = false;    //play again button
			Start = false;
			t.timeInGame = 0;
			t.timeLeft = 0;
        }

        
        private void StartButton_Click(object sender, EventArgs e)
        {
			
            StartButton.Visible = false;
            number1 = random_number.Next(50)+1;
            labelnumber1.Text = number1.ToString();

            number2 = random_number.Next(50)+1;
            labelnumber2.Text = number2.ToString();

            number3 = random_number.Next(1,100)+1;
            labelnumber3.Text = number3.ToString();

            number4 = random_number.Next(1,number3)+1;  
            labelnumber4.Text = number4.ToString();

            number5 = random_number.Next(10)+1;
            labelnumber5.Text = number5.ToString();

            number6 = random_number.Next(10)+1;
            labelnumber6.Text = number6.ToString();

            number8 = random_number.Next(1, 10)+1;
            labelnumber8.Text = number8.ToString();
            int divnumber = random_number.Next(1, 10);
            number7 = number8 * divnumber; 
            labelnumber7.Text = number7.ToString();

            t.timeLeft = 80;
            textBoxTimeleft.Text = "80 seconds";
            timer1.Start();
			Start = true;
			button2.Visible = false;
        }

        private void goCalculatorbutton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t.timeLeft > 0)
            {
                t.timeLeft--;
                textBoxTimeleft.Text = t.timeLeft + " seconds ";
            }
            else
            {
                textBoxTimeleft.Text = "Time end!";
                StartButton.Visible = true;
            }
                


            if (t.timeLeft >= 60)
                this.BackColor = Color.Green;
            else if (t.timeLeft >= 30)
                this.BackColor = Color.Orange;
            else
                this.BackColor = Color.Red;


			t.timeInGame++;

			if (t.timeInGame > 80)
			{
				this.BackColor = Color.LightSeaGreen;
				button2.Visible = true;
			}

		}

		private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)    
        {

            

        }

        private void answersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void MathForm_Load(object sender, EventArgs e)
        {
            plus_numericUpDown.Value = 0;
            subtraction_numericUpDown.Value = 0;
            multiplication_numericUpDown.Value = 0;
            division_numericUpDown.Value = 0;
        }

		private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Player p = new Player();
			p.correctAnswers = 0;
			if (Start)
			{
				
				if(plus_numericUpDown.Value == number1 + number2)
				{
					p.correctAnswers++;
                    p.playerRatio = p.playerRatio + 25;
				}
				else
				{
					plus_numericUpDown.Value = number1 + number2;
				}
				if (subtraction_numericUpDown.Value == number3 - number4)
				{
					p.correctAnswers++;
                    p.playerRatio = p.playerRatio + 25;
				}
				else
				{
					subtraction_numericUpDown.Value = number3 - number4;
				}
				if (multiplication_numericUpDown.Value == number5 * number6)
				{
					p.correctAnswers++;
                    p.playerRatio = p.playerRatio + 25;
				}
				else
				{
					multiplication_numericUpDown.Value = number5 * number6;
				}
				if (division_numericUpDown.Value == number7 / number8)
				{
					p.correctAnswers++;
                    p.playerRatio = p.playerRatio + 25;
				}
				else
				{
					division_numericUpDown.Value = number7 / number8;
				}

			}
			
			
			if (t.timeInGame > 80)
			{
				MessageBox.Show("You have exceeded 80 seconds", "Time");
				Start = false;
			}
			p.score = p.correctAnswers * t.timeLeft;  
			timer1.Stop();
          
			
			
			if (t.timeInGame <= 80)
			{
                MessageBox.Show("POINTS:" + p.score.ToString() + "\n" + "ANSWERS:" + p.correctAnswers.ToString() + "\n" + "RATIO:" + p.playerRatio + "%\n" + "YOUR TIME: " + t.timeInGame + " seconds"); 
			}
			else
			{
                MessageBox.Show("POINTS:" + p.score.ToString() + "\n" + "ANSWERS:" + p.correctAnswers.ToString() + "\n" + "RATIO:" + p.playerRatio + "%\n" + "Entered overtime!\n" +  "YOUR TIME: " + t.timeInGame + " seconds"); 

			}
			button2.Visible = true;
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			StartButton.Visible = true;
			this.BackColor = Color.LightSeaGreen;
            plus_numericUpDown.Value = 0;
            subtraction_numericUpDown.Value = 0;
            multiplication_numericUpDown.Value = 0;
            division_numericUpDown.Value = 0;
            t.timeInGame = 0;
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Calculator form2 = new Calculator();
			form2.Close();
            Ηelp form3 = new Ηelp();
            form3.Close();
            Ηelp2 form4 = new Ηelp2();
            form4.Close();
			this.Close();
		}

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plus_numericUpDown.Value = 0;
            subtraction_numericUpDown.Value = 0;
            multiplication_numericUpDown.Value = 0;
            division_numericUpDown.Value = 0;
           
            
        }

        private void showTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ηelp form3 = new Ηelp();
            form3.Show();
        }

        private void showRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ηelp2 form4 = new Ηelp2();
            form4.Show();
        }
    }
}
