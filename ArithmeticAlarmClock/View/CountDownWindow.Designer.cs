﻿namespace ArithmeticAlarmClock
{
	partial class CountDownWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.CountDownLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "起床時間まで、残り";
			// 
			// CountDownLabel
			// 
			this.CountDownLabel.AutoSize = true;
			this.CountDownLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CountDownLabel.Location = new System.Drawing.Point(24, 55);
			this.CountDownLabel.Margin = new System.Windows.Forms.Padding(3);
			this.CountDownLabel.Name = "CountDownLabel";
			this.CountDownLabel.Size = new System.Drawing.Size(178, 24);
			this.CountDownLabel.TabIndex = 1;
			this.CountDownLabel.Text = "12時間12分12秒";
			// 
			// CountDownWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(226, 103);
			this.Controls.Add(this.CountDownLabel);
			this.Controls.Add(this.label1);
			this.Name = "CountDownWindow";
			this.Text = "CountDownWindow";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label CountDownLabel;
	}
}