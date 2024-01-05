namespace Shop_CW.Forms
{
	partial class AddCash
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
			this.btn_Exit = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.btn_AddCash = new System.Windows.Forms.Button();
			this.Cash = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Cash)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Exit.Location = new System.Drawing.Point(12, 203);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(264, 49);
			this.btn_Exit.TabIndex = 4;
			this.btn_Exit.Text = "Вихід";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl1.Location = new System.Drawing.Point(12, 40);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(251, 33);
			this.lbl1.TabIndex = 8;
			this.lbl1.Text = "Кількість коштів";
			// 
			// btn_AddCash
			// 
			this.btn_AddCash.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_AddCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_AddCash.Location = new System.Drawing.Point(12, 148);
			this.btn_AddCash.Name = "btn_AddCash";
			this.btn_AddCash.Size = new System.Drawing.Size(264, 49);
			this.btn_AddCash.TabIndex = 9;
			this.btn_AddCash.Text = "Поповнити";
			this.btn_AddCash.UseVisualStyleBackColor = false;
			this.btn_AddCash.Click += new System.EventHandler(this.btn_AddCash_Click);
			// 
			// Cash
			// 
			this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cash.Location = new System.Drawing.Point(46, 93);
			this.Cash.Name = "Cash";
			this.Cash.Size = new System.Drawing.Size(189, 35);
			this.Cash.TabIndex = 10;
			// 
			// AddCash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(287, 277);
			this.Controls.Add(this.Cash);
			this.Controls.Add(this.btn_AddCash);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btn_Exit);
			this.Name = "AddCash";
			this.Text = "AddCash";
			((System.ComponentModel.ISupportInitialize)(this.Cash)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btn_AddCash;
		private System.Windows.Forms.NumericUpDown Cash;
	}
}