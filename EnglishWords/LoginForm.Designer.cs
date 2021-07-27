
namespace EnglishWords
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonLearn = new System.Windows.Forms.Button();
			this.buttonTest = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(368, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "ENGLISH WORD LEARN AND TEST";
			// 
			// buttonLearn
			// 
			this.buttonLearn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLearn.Location = new System.Drawing.Point(247, 46);
			this.buttonLearn.Name = "buttonLearn";
			this.buttonLearn.Size = new System.Drawing.Size(230, 109);
			this.buttonLearn.TabIndex = 1;
			this.buttonLearn.Text = "LEARN WORD";
			this.buttonLearn.UseVisualStyleBackColor = true;
			this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
			// 
			// buttonTest
			// 
			this.buttonTest.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTest.Location = new System.Drawing.Point(11, 46);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.Size = new System.Drawing.Size(230, 109);
			this.buttonTest.TabIndex = 2;
			this.buttonTest.Text = "TEST";
			this.buttonTest.UseVisualStyleBackColor = true;
			this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReset.Location = new System.Drawing.Point(11, 161);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(230, 48);
			this.buttonReset.TabIndex = 3;
			this.buttonReset.Text = "RESET";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label2.Location = new System.Drawing.Point(258, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "English Academy TR";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label3.Location = new System.Drawing.Point(321, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "İbrahim Halil SAKAR";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Purple;
			this.ClientSize = new System.Drawing.Size(490, 220);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonTest);
			this.Controls.Add(this.buttonLearn);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Screen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonLearn;
		private System.Windows.Forms.Button buttonTest;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}