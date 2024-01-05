namespace Shop_CW.Forms
{
	partial class LogIn
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
			this.btn_LogIn = new System.Windows.Forms.Button();
			this.TBox_Password = new System.Windows.Forms.TextBox();
			this.TBox_Name = new System.Windows.Forms.TextBox();
			this.btn_Return = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_LogIn
			// 
			this.btn_LogIn.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_LogIn.Location = new System.Drawing.Point(70, 187);
			this.btn_LogIn.Name = "btn_LogIn";
			this.btn_LogIn.Size = new System.Drawing.Size(142, 40);
			this.btn_LogIn.TabIndex = 0;
			this.btn_LogIn.Text = "Увійти";
			this.btn_LogIn.UseVisualStyleBackColor = false;
			this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
			// 
			// TBox_Password
			// 
			this.TBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBox_Password.Location = new System.Drawing.Point(70, 129);
			this.TBox_Password.Name = "TBox_Password";
			this.TBox_Password.Size = new System.Drawing.Size(142, 35);
			this.TBox_Password.TabIndex = 1;
			// 
			// TBox_Name
			// 
			this.TBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBox_Name.Location = new System.Drawing.Point(70, 49);
			this.TBox_Name.Name = "TBox_Name";
			this.TBox_Name.Size = new System.Drawing.Size(142, 35);
			this.TBox_Name.TabIndex = 2;
			// 
			// btn_Return
			// 
			this.btn_Return.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Return.Location = new System.Drawing.Point(48, 233);
			this.btn_Return.Name = "btn_Return";
			this.btn_Return.Size = new System.Drawing.Size(193, 40);
			this.btn_Return.TabIndex = 3;
			this.btn_Return.Text = "Повернутись";
			this.btn_Return.UseVisualStyleBackColor = false;
			this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(98, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ім\'я";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(72, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "Пароль";
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(275, 277);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Return);
			this.Controls.Add(this.TBox_Name);
			this.Controls.Add(this.TBox_Password);
			this.Controls.Add(this.btn_LogIn);
			this.Name = "LogIn";
			this.Text = "LogIn";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_LogIn;
		private System.Windows.Forms.TextBox TBox_Password;
		private System.Windows.Forms.TextBox TBox_Name;
		private System.Windows.Forms.Button btn_Return;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}