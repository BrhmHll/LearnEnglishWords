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

					tbQuestion.Text = words[randomNumber].Split('|')[y];
					correctAnswer = words[randomNumber].Split('|')[y+1];
					//z for choice random
					int z = rnd.Next(0, 4);
					switch (z)
					{
						case 0:
							correctChoice = 'A';
							buttonA.Text = "A) " + correctAnswer;
							buttonB.Text = "B) " + words[rnd.Next(0,words.Length)].Split('|')[y+1];
							buttonC.Text = "C) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonD.Text = "D) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							break;
						case 1:
							correctChoice = 'B';
							buttonA.Text = "A) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonB.Text = "B) " + correctAnswer;
							buttonC.Text = "C) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonD.Text = "D) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							break;
						case 2:
							correctChoice = 'C';
							buttonA.Text = "A) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonB.Text = "B) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonC.Text = "C) " + correctAnswer;
							buttonD.Text = "D) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							break;
						case 3:
							correctChoice = 'D';
							buttonA.Text = "A) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonB.Text = "B) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonC.Text = "C) " + words[rnd.Next(0, words.Length)].Split('|')[y + 1];
							buttonD.Text = "D) " + correctAnswer;
							break;
					}


				}
				//question turkish answer english
				else
				{
					// y for word question or sentence question
					int y = rnd.Next(1, 3);
					if (y == 2)
						y = 4;

					tbQuestion.Text = words[randomNumber].Split('|')[y];
					correctAnswer = words[randomNumber].Split('|')[y - 1];


					do
					{
						wrongAnswer1 = words[rnd.Next(0, words.Length)].Split('|')[y - 1];
						wrongAnswer2 = words[rnd.Next(0, words.Length)].Split('|')[y - 1];
						wrongAnswer3 = words[rnd.Next(0, words.Length)].Split('|')[y - 1];
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

				count--;
			}
			else
			{
				timer1.Stop();
				MessageBox.Show("Result: " + countCorrect + " Correct Answer  -  " + countWrong + " Wrong Answer");
				loginScreen.Visible = true;
				this.Close();
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
			setButtons(false);
			if (correctChoice == 'A')
			{
				countCorrect++;
				buttonA.BackColor = Color.Green;
			}
			else
			{
				countWrong++;
				buttonA.BackColor = Color.Red;
				learnedToUnlearned();
			}
		}

		private void buttonB_Click(object sender, EventArgs e)
		{
			setButtons(false);
			if (correctChoice == 'B')
			{
				countCorrect++;
				buttonB.BackColor = Color.Green;
			}
			else
			{
				countWrong++;
				buttonB.BackColor = Color.Red;
				learnedToUnlearned();
			}
		}

		private void buttonC_Click(object sender, EventArgs e)
		{
			setButtons(false);
			if (correctChoice == 'C')
			{
				countCorrect++;
				buttonC.BackColor = Color.Green;
			}
			else
			{
				countWrong++;
				buttonC.BackColor = Color.Red;
				learnedToUnlearned();
			}
		}

		private void buttonD_Click(object sender, EventArgs e)
		{
			setButtons(false);
			if (correctChoice == 'D')
			{
				countCorrect++;
				buttonD.BackColor = Color.Green;
			}
			else
			{
				countWrong++;
				buttonD.BackColor = Color.Red;
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
