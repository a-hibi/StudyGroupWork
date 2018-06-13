namespace ArithmeticAlarmClock.View
{
	partial class ArithmeticQuestionView
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
			this.Answer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Question = new System.Windows.Forms.Label();
			this.StopButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Answer
			// 
			this.Answer.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Answer.Location = new System.Drawing.Point(588, 146);
			this.Answer.Name = "Answer";
			this.Answer.Size = new System.Drawing.Size(302, 103);
			this.Answer.TabIndex = 0;
			this.Answer.Text = "999999";
			this.Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(878, 128);
			this.label1.TabIndex = 1;
			this.label1.Text = "アラームを止めるには\r\nこの問題を解きなさい！！";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Question
			// 
			this.Question.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Question.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Question.Location = new System.Drawing.Point(12, 146);
			this.Question.Margin = new System.Windows.Forms.Padding(3);
			this.Question.Name = "Question";
			this.Question.Size = new System.Drawing.Size(570, 103);
			this.Question.TabIndex = 2;
			this.Question.Text = "120 × 120 =";
			// 
			// StopButton
			// 
			this.StopButton.Location = new System.Drawing.Point(6, 18);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(75, 23);
			this.StopButton.TabIndex = 3;
			this.StopButton.Text = "止める";
			this.StopButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.StopButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 255);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(878, 166);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// ArithmeticQuestionWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 433);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Question);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Answer);
			this.Name = "ArithmeticQuestionWindow";
			this.Text = "ArithmeticQuestionWindow";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Answer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Question;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}