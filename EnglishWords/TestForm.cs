using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWords
{
	public partial class TestForm : Form
	{
		string[] words;
		Random rnd = new Random();
		int randomNumber;

		string correctAnswer;
		string wrongAnswer1;
		string wrongAnswer2;
		string wrongAnswer3;

		char correctChoice;

		int count = 10;
		int countCorrect = 0;
		int countWrong = 0;
		int time = 20;

		public Form loginScreen;

		string unlearned = "Words\\unlearnedWords.txt";
		string learned = "Words\\learnedWords.txt";

		public TestForm()
		{
			InitializeComponent();
		}

		private void returnHome_Click(object sender, EventArgs e)
		{
			loginScreen.Visible = true;
			this.Close();
		}

		private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			loginScreen.Visible = true;
		}

		private void getQuestion()
		{
			labelCorrect.Text = countCorrect.ToString();
			labelWrong.Text = countWrong.ToString();
			if(count > 0)
			{
				randomNumber = rnd.Next(0, words.Length);
				int x = rnd.Next(0,2);
				
				//question english answer turkish
				if (x == 0)
				{
					// y for word question or sentence question
					int y = rnd.Next(0, 2);
					if (y == 1)
						y = 3;

					prepareChoices(y, y+1);
				}
				//question turkish answer english
				else
				{
					// y for word question or sentence question
					int y = rnd.Next(1, 3);
					if (y == 2)
						y = 4;

					prepareChoices(y, y-1);
				}

				count--;
			}
			else
			{
				//****
				timer1.Stop();
				MessageBox.Show("Result: \n" + countCorrect + " Correct Answer\n" + countWrong + " Wrong Answer");
				loginScreen.Visible = true;
				this.Close();
			}
		}

		private void prepareChoices(int no1, int no2)
		{ 
			tbQuestion.Text = words[randomNumber].Split('|')[no1];
			correctAnswer = words[randomNumber].Split('|')[no2];

			do
			{
				wrongAnswer1 = words[rnd.Next(0, words.Length)].Split('|')[no2];
				wrongAnswer2 = words[rnd.Next(0, words.Length)].Split('|')[no2];
				wrongAnswer3 = words[rnd.Next(0, words.Length)].Split('|')[no2];
			} while (wrongAnswer1 == correctAnswer
			|| wrongAnswer2 == correctAnswer
			|| wrongAnswer3 == correctAnswer
			|| wrongAnswer1 == wrongAnswer2
			|| wrongAnswer1 == wrongAnswer3
			|| wrongAnswer2 == wrongAnswer3);

			//z for choice random
			int z = rnd.Next(0, 4);
			switch (z)
			{
				case 0:
					correctChoice = 'A';
					buttonA.Text = "A) " + correctAnswer;
					buttonB.Text = "B) " + wrongAnswer1;
					buttonC.Text = "C) " + wrongAnswer2;
					buttonD.Text = "D) " + wrongAnswer3;
					break;
				case 1:
					correctChoice = 'B';
					buttonA.Text = "A) " + wrongAnswer1;
					buttonB.Text = "B) " + correctAnswer;
					buttonC.Text = "C) " + wrongAnswer2;
					buttonD.Text = "D) " + wrongAnswer3;
					break;
				case 2:
					correctChoice = 'C';
					buttonA.Text = "A) " + wrongAnswer1;
					buttonB.Text = "B) " + wrongAnswer2;
					buttonC.Text = "C) " + correctAnswer;
					buttonD.Text = "D) " + wrongAnswer3;
					break;
				case 3:
					correctChoice = 'D';
					buttonA.Text = "A) " + wrongAnswer1;
					buttonB.Text = "B) " + wrongAnswer2;
					buttonC.Text = "C) " + wrongAnswer3;
					buttonD.Text = "D) " + correctAnswer;
					break;
			}
		}



		private void TestForm_Load(object sender, EventArgs e)
		{
			words = File.ReadAllLines(learned);
			getQuestion();
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			timer1.Start();
			time = 20;
			labelTime.ForeColor = Color.Black;
			labelTime.Text = time.ToString();
			buttonA.BackColor = Color.MediumSlateBlue;
			buttonB.BackColor = Color.MediumSlateBlue;
			buttonC.BackColor = Color.MediumSlateBlue;
			buttonD.BackColor = Color.MediumSlateBlue;
			setButtons(true);
			getQuestion();
		}

		private void buttonA_Click(object sender, EventArgs e)
		{
			isTrue('A', buttonA);
		}

		private void buttonB_Click(object sender, EventArgs e)
		{
			isTrue('B', buttonB);
		}

		private void buttonC_Click(object sender, EventArgs e)
		{
			isTrue('C', buttonC);
		}

		private void buttonD_Click(object sender, EventArgs e)
		{
			isTrue('D', buttonD);
		}

		private void isTrue(char selectedChoice, Button clickedButton)
		{
			setButtons(false);
			if (this.correctChoice == selectedChoice)
			{
				countCorrect++;
				clickedButton.BackColor = Color.Green;
			}
			else
			{
				countWrong++;
				clickedButton.BackColor = Color.Red;
				learnedToUnlearned();
			}
		}

		private void setButtons(bool active)
		{
			if (!active)
				timer1.Stop();
			buttonA.Enabled = active;
			buttonB.Enabled = active;
			buttonC.Enabled = active;
			buttonD.Enabled = active;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			time--;
			if (time == 0)
			{
				setButtons(false);
				learnedToUnlearned();
			}
			else if (time <= 5)
			{
				labelTime.ForeColor = Color.Red;
			}
			labelTime.Text = time.ToString();
		}

		private void learnedToUnlearned()
		{
			var tempSentence = words[randomNumber];
			words[randomNumber] = "";
			FileStream fs = new FileStream(unlearned, FileMode.Append);
			StreamWriter sw = new StreamWriter(fs);
			sw.WriteLine(tempSentence);
			sw.Close();
			fs.Close();

			fs = new FileStream(learned, FileMode.Create);
			sw = new StreamWriter(fs);
			foreach (var item in words)
			{
				if (item != "")
				{
					sw.WriteLine(item);
				}
			}
			sw.Close();
			fs.Close();
			words = File.ReadAllLines(learned);
		}
	}
}
