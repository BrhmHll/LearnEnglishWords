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
	public partial class LearnForm : Form
	{
		string[] words;
		Random rnd = new Random();
		int randomNumber;
		int total;
		public Form loginScreen;

		string unlearned = "Words\\unlearnedWords.txt";
		string learned = "Words\\learnedWords.txt";

		public LearnForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			total = File.ReadAllLines("Words\\AllWords.txt").Length;
			words = File.ReadAllLines(unlearned);
			getWord();
		}

		private void buttonGetWord_Click(object sender, EventArgs e)
		{
			buttonLearned.Enabled = false;
			labelKalan.Visible = true;
			timer1.Start();
			getWord();
		}

		private void buttonLearned_Click(object sender, EventArgs e)
		{
			var tempSentence = words[randomNumber];
			words[randomNumber] = "";
			FileStream fs = new FileStream(learned, FileMode.Append);
			StreamWriter sw = new StreamWriter(fs);
			sw.WriteLine(tempSentence);
			sw.Close();
			fs.Close();

			fs = new FileStream(unlearned, FileMode.Create);
			sw = new StreamWriter(fs);
			foreach (var item in words)
			{
				if(item != "")
				{
					sw.WriteLine(item);
				}
			}
			sw.Close();
			fs.Close();
			words = File.ReadAllLines(unlearned);
			getWord();

			buttonLearned.Enabled = false;
			labelKalan.Visible = true;
			timer1.Start(); 

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			buttonLearned.Enabled = true;
			labelKalan.Visible = false;
			timer1.Stop();
		}
		private void getWord()
		{
			randomNumber = rnd.Next(0, words.Length);
			string cümle = words[randomNumber];
			tbEnglishWord.Text = cümle.Split('|')[0] + "\r\n" + cümle.Split('|')[2];
			tbTurkishWord.Text = cümle.Split('|')[1];
			tbEnglishSentence.Text = cümle.Split('|')[3];
			tbTurkishSentence.Text = cümle.Split('|')[4];

			labelCount.Text = words.Length + "/"+ total;
		}

		private void WordLearn_FormClosed(object sender, FormClosedEventArgs e)
		{
			loginScreen.Visible = true;
		}

		private void returnHome_Click(object sender, EventArgs e)
		{
			loginScreen.Visible = true;
			this.Close();
		}
	}
}
