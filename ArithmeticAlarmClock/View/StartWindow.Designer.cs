namespace ArithmeticAlarmClock
{
	partial class StartWindow
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "HH時 mm分 ss秒";
			this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimePicker1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 73);
			this.dateTimePicker1.MaxDate = new System.DateTime(2018, 6, 12, 0, 0, 0, 0);
			this.dateTimePicker1.MinDate = new System.DateTime(2018, 6, 12, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(386, 55);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.Value = new System.DateTime(2018, 6, 12, 0, 0, 0, 0);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimePicker2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.dateTimePicker2.Location = new System.Drawing.Point(12, 12);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(386, 55);
			this.dateTimePicker2.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button1.Location = new System.Drawing.Point(12, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(386, 96);
			this.button1.TabIndex = 3;
			this.button1.Text = "！起動！";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// StartWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 242);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "StartWindow";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button button1;
	}
}

