namespace Shop_CW.Forms
{
	partial class Main
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
			this.btn_AddCash = new System.Windows.Forms.Button();
			this.btn_Purchases = new System.Windows.Forms.Button();
			this.btn_Goods = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_Balance = new System.Windows.Forms.Label();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Exit.Location = new System.Drawing.Point(12, 193);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(264, 49);
			this.btn_Exit.TabIndex = 3;
			this.btn_Exit.Text = "Вихід";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_AddCash
			// 
			this.btn_AddCash.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_AddCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_AddCash.Location = new System.Drawing.Point(12, 138);
			this.btn_AddCash.Name = "btn_AddCash";
			this.btn_AddCash.Size = new System.Drawing.Size(264, 49);
			this.btn_AddCash.TabIndex = 4;
			this.btn_AddCash.Text = "Поповнити рахунок";
			this.btn_AddCash.UseVisualStyleBackColor = false;
			this.btn_AddCash.Click += new System.EventHandler(this.btn_AddCash_Click);
			// 
			// btn_Purchases
			// 
			this.btn_Purchases.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Purchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Purchases.Location = new System.Drawing.Point(12, 83);
			this.btn_Purchases.Name = "btn_Purchases";
			this.btn_Purchases.Size = new System.Drawing.Size(264, 49);
			this.btn_Purchases.TabIndex = 5;
			this.btn_Purchases.Text = "Історія покупок";
			this.btn_Purchases.UseVisualStyleBackColor = false;
			this.btn_Purchases.Click += new System.EventHandler(this.btn_Purchases_Click);
			// 
			// btn_Goods
			// 
			this.btn_Goods.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Goods.Location = new System.Drawing.Point(12, 28);
			this.btn_Goods.Name = "btn_Goods";
			this.btn_Goods.Size = new System.Drawing.Size(264, 49);
			this.btn_Goods.TabIndex = 6;
			this.btn_Goods.Text = "Товари";
			this.btn_Goods.UseVisualStyleBackColor = false;
			this.btn_Goods.Click += new System.EventHandler(this.btn_Goods_Click);
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl1.Location = new System.Drawing.Point(70, 47);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(95, 42);
			this.lbl1.TabIndex = 7;
			this.lbl1.Text = "Ім\'я:";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl2.Location = new System.Drawing.Point(3, 111);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(162, 42);
			this.lbl2.TabIndex = 8;
			this.lbl2.Text = "Баланс:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.lbl_Balance);
			this.panel1.Controls.Add(this.lbl_Name);
			this.panel1.Controls.Add(this.lbl2);
			this.panel1.Controls.Add(this.lbl1);
			this.panel1.Location = new System.Drawing.Point(282, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(453, 207);
			this.panel1.TabIndex = 9;
			// 
			// lbl_Balance
			// 
			this.lbl_Balance.AutoSize = true;
			this.lbl_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_Balance.Location = new System.Drawing.Point(171, 111);
			this.lbl_Balance.Name = "lbl_Balance";
			this.lbl_Balance.Size = new System.Drawing.Size(40, 42);
			this.lbl_Balance.TabIndex = 10;
			this.lbl_Balance.Text = "[]";
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_Name.Location = new System.Drawing.Point(171, 47);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(40, 42);
			this.lbl_Name.TabIndex = 9;
			this.lbl_Name.Text = "[]";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(747, 251);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_Goods);
			this.Controls.Add(this.btn_Purchases);
			this.Controls.Add(this.btn_AddCash);
			this.Controls.Add(this.btn_Exit);
			this.Name = "Main";
			this.Text = "Main";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_AddCash;
		private System.Windows.Forms.Button btn_Purchases;
		private System.Windows.Forms.Button btn_Goods;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_Balance;
		private System.Windows.Forms.Label lbl_Name;
	}
}