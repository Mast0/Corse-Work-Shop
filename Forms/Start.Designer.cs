namespace Shop_CW
{
	partial class Start
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_LogIn = new System.Windows.Forms.Button();
			this.btn_Register = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_LogIn
			// 
			this.btn_LogIn.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_LogIn.Location = new System.Drawing.Point(12, 37);
			this.btn_LogIn.Name = "btn_LogIn";
			this.btn_LogIn.Size = new System.Drawing.Size(237, 51);
			this.btn_LogIn.TabIndex = 0;
			this.btn_LogIn.Text = "Увійти";
			this.btn_LogIn.UseVisualStyleBackColor = false;
			this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
			// 
			// btn_Register
			// 
			this.btn_Register.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Register.Location = new System.Drawing.Point(12, 94);
			this.btn_Register.Name = "btn_Register";
			this.btn_Register.Size = new System.Drawing.Size(237, 51);
			this.btn_Register.TabIndex = 1;
			this.btn_Register.Text = "Зареєструватися";
			this.btn_Register.UseVisualStyleBackColor = false;
			this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Exit.Location = new System.Drawing.Point(12, 151);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(237, 51);
			this.btn_Exit.TabIndex = 2;
			this.btn_Exit.Text = "Вихід";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(275, 261);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Register);
			this.Controls.Add(this.btn_LogIn);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Name = "Start";
			this.Text = "Мій Магазин";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_LogIn;
		private System.Windows.Forms.Button btn_Register;
		private System.Windows.Forms.Button btn_Exit;
	}
}

