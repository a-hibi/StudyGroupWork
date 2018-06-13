namespace ArithmeticAlarmClock.View
{
	partial class StartView
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
			this.components = new System.ComponentModel.Container();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.startViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.startViewModelBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// timePicker
			// 
			this.timePicker.CustomFormat = "HH時 mm分 ss秒";
			this.timePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.timePicker.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timePicker.Location = new System.Drawing.Point(12, 73);
			this.timePicker.MaxDate = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
			this.timePicker.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowUpDown = true;
			this.timePicker.Size = new System.Drawing.Size(386, 55);
			this.timePicker.TabIndex = 1;
			this.timePicker.Value = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
			// 
			// datePicker
			// 
			this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.datePicker.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.datePicker.Location = new System.Drawing.Point(12, 12);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(386, 55);
			this.datePicker.TabIndex = 2;
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
			// startViewModelBindingSource
			// 
			this.startViewModelBindingSource.DataSource = typeof(ArithmeticAlarmClock.ViewModel.StartViewModel);
			// 
			// StartView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 242);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.timePicker);
			this.Name = "StartView";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.StartView_Load);
			((System.ComponentModel.ISupportInitialize)(this.startViewModelBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource startViewModelBindingSource;
	}
}

