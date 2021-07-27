
namespace EnglishWords
{
	partial class TestForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
			this.tbQuestion = new System.Windows.Forms.TextBox();
			this.buttonA = new System.Windows.Forms.Button();
			this.buttonB = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.buttonD = new System.Windows.Forms.Button();
			this.returnHome = new System.Windows.Forms.Button();
			this.labelCorrect = new System.Windows.Forms.Label();
			this.labelWrong = new System.Windows.Forms.Label();
			this.buttonNext = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.labelTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbQuestion
			// 
			this.tbQuestion.BackColor = System.Drawing.Color.Purple;
			this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuestion.ForeColor = System.Drawing.Color.White;
			this.tbQuestion.Location = new System.Drawing.Point(12, 12);
			this.tbQuestion.Multiline = true;
			this.tbQuestion.Name = "tbQuestion";
			this.tbQuestion.Size = new System.Drawing.Size(912, 172);
			this.tbQuestion.TabIndex = 0;
			this.tbQuestion.Text = "Question";
			// 
			// buttonA
			// 
			this.buttonA.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonA.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonA.Location = new System.Drawing.Point(12, 190);
			this.buttonA.Name = "buttonA";
			this.buttonA.Size = new System.Drawing.Size(451, 132);
			this.buttonA.TabIndex = 1;
			this.buttonA.Text = "A)";
			this.buttonA.UseVisualStyleBackColor = false;
			this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
			// 
			// buttonB
			// 
			this.buttonB.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonB.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonB.Location = new System.Drawing.Point(473, 190);
			this.buttonB.Name = "buttonB";
			this.buttonB.Size = new System.Drawing.Size(451, 132);
			this.buttonB.TabIndex = 2;
			this.buttonB.Text = "B)";
			this.buttonB.UseVisualStyleBackColor = false;
			this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
			// 
			// buttonC
			// 
			this.buttonC.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonC.Location = new System.Drawing.Point(12, 328);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(451, 132);
			this.buttonC.TabIndex = 3;
			this.buttonC.Text = "C)";
			this.buttonC.UseVisualStyleBackColor = false;
			this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
			// 
			// buttonD
			// 
			this.buttonD.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.buttonD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonD.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonD.Location = new System.Drawing.Point(473, 328);
			this.buttonD.Name = "buttonD";
			this.buttonD.Size = new System.Drawing.Size(451, 132);
			this.buttonD.TabIndex = 4;
			this.buttonD.Text = "D)";
			this.buttonD.UseVisualStyleBackColor = false;
			this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
			// 
			// returnHome
			// 
			this.returnHome.BackColor = System.Drawing.Color.Yellow;
			this.returnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.returnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.returnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.returnHome.ForeColor = System.Drawing.Color.Black;
			this.returnHome.Location = new System.Drawing.Point(12, 467);
			this.returnHome.Name = "returnHome";
			this.returnHome.Size = new System.Drawing.Size(116, 71);
			this.returnHome.TabIndex = 5;
			this.returnHome.Text = "Return Home";
			this.returnHome.UseVisualStyleBackColor = false;
			this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
			// 
			// labelCorrect
			// 
			this.labelCorrect.AutoSize = true;
			this.labelCorrect.BackColor = System.Drawing.Color.White;
			this.labelCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCorrect.ForeColor = System.Drawing.Color.Green;
			this.labelCorrect.Location = new System.Drawing.Point(165, 484);
			this.labelCorrect.Name = "labelCorrect";
			this.labelCorrect.Size = new System.Drawing.Size(50, 54);
			this.labelCorrect.TabIndex = 6;
			this.labelCorrect.Text = "0";
			// 
			// labelWrong
			// 
			this.labelWrong.AutoSize = true;
			this.labelWrong.BackColor = System.Drawing.Color.White;
			this.labelWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWrong.ForeColor = System.Drawing.Color.Red;
			this.labelWrong.Location = new System.Drawing.Point(248, 484);
			this.labelWrong.Name = "labelWrong";
			this.labelWrong.Size = new System.Drawing.Size(50, 54);
			this.labelWrong.TabIndex = 7;
			this.labelWrong.Text = "0";
			// 
			// buttonNext
			// 
			this.buttonNext.BackColor = System.Drawing.Color.Blue;
			this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNext.ForeColor = System.Drawing.Color.White;
			this.buttonNext.Location = new System.Drawing.Point(695, 467);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(229, 71);
			this.buttonNext.TabIndex = 8;
			this.buttonNext.Text = "NEXT";
			this.buttonNext.UseVisualStyleBackColor = false;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.Color.White;
			this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTime.ForeColor = System.Drawing.Color.Black;
			this.labelTime.Location = new System.Drawing.Point(625, 492);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(64, 46);
			this.labelTime.TabIndex = 9;
			this.labelTime.Text = "20";
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(936, 550);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.labelWrong);
			this.Controls.Add(this.labelCorrect);
			this.Controls.Add(this.returnHome);
			this.Controls.Add(this.buttonD);
			this.Controls.Add(this.buttonC);
			this.Controls.Add(this.buttonB);
			this.Controls.Add(this.buttonA);
			this.Controls.Add(this.tbQuestion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TestForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Test";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
			this.Load += new System.EventHandler(this.TestForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbQuestion;
		private System.Windows.Forms.Button buttonA;
		private System.Windows.Forms.Button buttonB;
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button buttonD;
		private System.Windows.Forms.Button returnHome;
		private System.Windows.Forms.Label labelCorrect;
		private System.Windows.Forms.Label labelWrong;
		private System.Windows.Forms.Button buttonNext;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelTime;
	}
}