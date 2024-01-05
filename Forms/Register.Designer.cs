namespace Shop_CW.Forms
{
	partial class Register
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Return = new System.Windows.Forms.Button();
			this.TBox_Name = new System.Windows.Forms.TextBox();
			this.TBox_Password = new System.Windows.Forms.TextBox();
			this.btn_Register = new System.Windows.Forms.Button();
			this.CBox_Type = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(65, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 37);
			this.label2.TabIndex = 11;
			this.label2.Text = "Пароль";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(91, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 37);
			this.label1.TabIndex = 10;
			this.label1.Text = "Ім\'я";
			// 
			// btn_Return
			// 
			this.btn_Return.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Return.Location = new System.Drawing.Point(41, 328);
			this.btn_Return.Name = "btn_Return";
			this.btn_Return.Size = new System.Drawing.Size(193, 40);
			this.btn_Return.TabIndex = 9;
			this.btn_Return.Text = "Повернутись";
			this.btn_Return.UseVisualStyleBackColor = false;
			this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
			// 
			// TBox_Name
			// 
			this.TBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBox_Name.Location = new System.Drawing.Point(63, 46);
			this.TBox_Name.Name = "TBox_Name";
			this.TBox_Name.Size = new System.Drawing.Size(142, 35);
			this.TBox_Name.TabIndex = 8;
			// 
			// TBox_Password
			// 
			this.TBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBox_Password.Location = new System.Drawing.Point(63, 126);
			this.TBox_Password.Name = "TBox_Password";
			this.TBox_Password.Size = new System.Drawing.Size(142, 35);
			this.TBox_Password.TabIndex = 7;
			// 
			// btn_Register
			// 
			this.btn_Register.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Register.Location = new System.Drawing.Point(12, 282);
			this.btn_Register.Name = "btn_Register";
			this.btn_Register.Size = new System.Drawing.Size(251, 40);
			this.btn_Register.TabIndex = 6;
			this.btn_Register.Text = "Зареєструватися";
			this.btn_Register.UseVisualStyleBackColor = false;
			this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
			// 
			// CBox_Type
			// 
			this.CBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CBox_Type.FormattingEnabled = true;
			this.CBox_Type.Location = new System.Drawing.Point(63, 215);
			this.CBox_Type.Name = "CBox_Type";
			this.CBox_Type.Size = new System.Drawing.Size(142, 37);
			this.CBox_Type.TabIndex = 12;
			this.CBox_Type.SelectedIndexChanged += new System.EventHandler(this.CBox_Type_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(35, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 37);
			this.label3.TabIndex = 13;
			this.label3.Text = "Тип акаунту";
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(275, 380);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CBox_Type);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Return);
			this.Controls.Add(this.TBox_Name);
			this.Controls.Add(this.TBox_Password);
			this.Controls.Add(this.btn_Register);
			this.Name = "Register";
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Return;
		private System.Windows.Forms.TextBox TBox_Name;
		private System.Windows.Forms.TextBox TBox_Password;
		private System.Windows.Forms.Button btn_Register;
		private System.Windows.Forms.ComboBox CBox_Type;
		private System.Windows.Forms.Label label3;
	}
}