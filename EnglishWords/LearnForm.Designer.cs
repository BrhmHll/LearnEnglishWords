
namespace EnglishWords
{
	partial class LearnForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnForm));
			this.buttonGetWord = new System.Windows.Forms.Button();
			this.tbEnglishWord = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTurkishWord = new System.Windows.Forms.TextBox();
			this.tbEnglishSentence = new System.Windows.Forms.TextBox();
			this.tbTurkishSentence = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonLearned = new System.Windows.Forms.Button();
			this.labelKalan = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.returnHome = new System.Windows.Forms.Button();
			this.labelCount = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonGetWord
			// 
			this.buttonGetWord.BackColor = System.Drawing.Color.Yellow;
			this.buttonGetWord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGetWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGetWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGetWord.Location = new System.Drawing.Point(679, 370);
			this.buttonGetWord.Name = "buttonGetWord";
			this.buttonGetWord.Size = new System.Drawing.Size(225, 110);
			this.buttonGetWord.TabIndex = 2;
			this.buttonGetWord.Text = "GET WORD";
			this.buttonGetWord.UseVisualStyleBackColor = false;
			this.buttonGetWord.Click += new System.EventHandler(this.buttonGetWord_Click);
			// 
			// tbEnglishWord
			// 
			this.tbEnglishWord.BackColor = System.Drawing.Color.Purple;
			this.tbEnglishWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEnglishWord.ForeColor = System.Drawing.SystemColors.Window;
			this.tbEnglishWord.Location = new System.Drawing.Point(428, 42);
			this.tbEnglishWord.Multiline = true;
			this.tbEnglishWord.Name = "tbEnglishWord";
			this.tbEnglishWord.Size = new System.Drawing.Size(476, 138);
			this.tbEnglishWord.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Location = new System.Drawing.Point(423, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "English Word";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Location = new System.Drawing.Point(430, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Turkish Word";
			// 
			// tbTurkishWord
			// 
			this.tbTurkishWord.BackColor = System.Drawing.Color.Purple;
			this.tbTurkishWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbTurkishWord.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbTurkishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTurkishWord.ForeColor = System.Drawing.SystemColors.Window;
			this.tbTurkishWord.Location = new System.Drawing.Point(428, 226);
			this.tbTurkishWord.Multiline = true;
			this.tbTurkishWord.Name = "tbTurkishWord";
			this.tbTurkishWord.Size = new System.Drawing.Size(476, 138);
			this.tbTurkishWord.TabIndex = 5;
			// 
			// tbEnglishSentence
			// 
			this.tbEnglishSentence.BackColor = System.Drawing.Color.Violet;
			this.tbEnglishSentence.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbEnglishSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEnglishSentence.ForeColor = System.Drawing.Color.Black;
			this.tbEnglishSentence.Location = new System.Drawing.Point(15, 42);
			this.tbEnglishSentence.Multiline = true;
			this.tbEnglishSentence.Name = "tbEnglishSentence";
			this.tbEnglishSentence.Size = new System.Drawing.Size(391, 138);
			this.tbEnglishSentence.TabIndex = 7;
			// 
			// tbTurkishSentence
			// 
			this.tbTurkishSentence.BackColor = System.Drawing.Color.Violet;
			this.tbTurkishSentence.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbTurkishSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTurkishSentence.ForeColor = System.Drawing.Color.Black;
			this.tbTurkishSentence.Location = new System.Drawing.Point(12, 226);
			this.tbTurkishSentence.Multiline = true;
			this.tbTurkishSentence.Name = "tbTurkishSentence";
			this.tbTurkishSentence.Size = new System.Drawing.Size(391, 138);
			this.tbTurkishSentence.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label3.Location = new System.Drawing.Point(16, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "English Sentence";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label4.Location = new System.Drawing.Point(12, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 25);
			this.label4.TabIndex = 10;
			this.label4.Text = "Turkish Sentence";
			// 
			// buttonLearned
			// 
			this.buttonLearned.BackColor = System.Drawing.Color.Yellow;
			this.buttonLearned.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLearned.Enabled = false;
			this.buttonLearned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLearned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLearned.Location = new System.Drawing.Point(428, 370);
			this.buttonLearned.Name = "buttonLearned";
			this.buttonLearned.Size = new System.Drawing.Size(225, 110);
			this.buttonLearned.TabIndex = 12;
			this.buttonLearned.Text = "I LEARNED THAT";
			this.buttonLearned.UseVisualStyleBackColor = false;
			this.buttonLearned.Click += new System.EventHandler(this.buttonLearned_Click);
			// 
			// labelKalan
			// 
			this.labelKalan.AutoSize = true;
			this.labelKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelKalan.Location = new System.Drawing.Point(511, 483);
			this.labelKalan.Name = "labelKalan";
			this.labelKalan.Size = new System.Drawing.Size(300, 20);
			this.labelKalan.TabIndex = 11;
			this.labelKalan.Text = "You have to work for at least 30 seconds!";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 30000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// returnHome
			// 
			this.returnHome.BackColor = System.Drawing.Color.Yellow;
			this.returnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.returnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.returnHome.Location = new System.Drawing.Point(12, 370);
			this.returnHome.Name = "returnHome";
			this.returnHome.Size = new System.Drawing.Size(115, 110);
			this.returnHome.TabIndex = 14;
			this.returnHome.Text = "Return Home";
			this.returnHome.UseVisualStyleBackColor = false;
			this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCount.Location = new System.Drawing.Point(16, 483);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(106, 25);
			this.labelCount.TabIndex = 16;
			this.labelCount.Text = "2996/2996";
			// 
			// LearnForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(949, 509);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.returnHome);
			this.Controls.Add(this.labelKalan);
			this.Controls.Add(this.buttonLearned);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbTurkishSentence);
			this.Controls.Add(this.tbEnglishSentence);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTurkishWord);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbEnglishWord);
			this.Controls.Add(this.buttonGetWord);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LearnForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "English Words 3000+";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordLearn_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonGetWord;
		private System.Windows.Forms.TextBox tbEnglishWord;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTurkishWord;
		private System.Windows.Forms.TextBox tbEnglishSentence;
		private System.Windows.Forms.TextBox tbTurkishSentence;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonLearned;
		private System.Windows.Forms.Label labelKalan;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button returnHome;
		private System.Windows.Forms.Label labelCount;
	}
}

