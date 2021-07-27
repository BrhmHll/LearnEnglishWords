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
	public partial class LoginForm : Form
	{
		string unlearned = "Words\\unlearnedWords.txt";
		string learned = "Words\\learnedWords.txt";
		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonLearn_Click(object sender, EventArgs e)
		{
			LearnForm wordLearn = new LearnForm();
			wordLearn.Visible = true;
			wordLearn.loginScreen = this;
			this.Visible = false;
		}

		private void buttonTest_Click(object sender, EventArgs e)
		{
			if (File.ReadAllLines(learned).Length >= 10)
			{
				TestForm testForm = new TestForm();
				testForm.Visible = true;
				testForm.loginScreen = this;
				this.Visible = false;
			}
			else
			{
				MessageBox.Show("You need to know at least 10 words to take the test....");
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to reset your progress?", "ATTENTION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				File.Delete(learned);
				File.Delete(unlearned);
				File.Create(learned);
				File.Copy("Words\\AllWords.txt", unlearned);
				
				MessageBox.Show("Progress Reset Completed!");
			}

			
		}
	}
}
