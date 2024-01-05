namespace Shop_CW.Forms
{
	partial class ProductsForm
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
			this.ProductList = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Buy_panel = new System.Windows.Forms.Panel();
			this.btn_Buy = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.IdSelect_Buy = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.Add_panel = new System.Windows.Forms.Panel();
			this.ProdPrice_Add = new System.Windows.Forms.NumericUpDown();
			this.ProdName_Add = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Add = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Delete_panel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.IdSelect_Delete = new System.Windows.Forms.NumericUpDown();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_Balance = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.Buy_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IdSelect_Buy)).BeginInit();
			this.Add_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdPrice_Add)).BeginInit();
			this.Delete_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IdSelect_Delete)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ProductList
			// 
			this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ProdName,
            this.ProdPrice});
			this.ProductList.HideSelection = false;
			this.ProductList.Location = new System.Drawing.Point(12, 68);
			this.ProductList.Name = "ProductList";
			this.ProductList.Size = new System.Drawing.Size(305, 370);
			this.ProductList.TabIndex = 0;
			this.ProductList.UseCompatibleStateImageBehavior = false;
			this.ProductList.View = System.Windows.Forms.View.Details;
			// 
			// id
			// 
			this.id.Text = "ID";
			this.id.Width = 100;
			// 
			// ProdName
			// 
			this.ProdName.Text = "Назва товару";
			this.ProdName.Width = 100;
			// 
			// ProdPrice
			// 
			this.ProdPrice.Text = "Ціна товару";
			this.ProdPrice.Width = 100;
			// 
			// Buy_panel
			// 
			this.Buy_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Buy_panel.Controls.Add(this.btn_Buy);
			this.Buy_panel.Controls.Add(this.label6);
			this.Buy_panel.Controls.Add(this.IdSelect_Buy);
			this.Buy_panel.Controls.Add(this.label5);
			this.Buy_panel.Location = new System.Drawing.Point(323, 12);
			this.Buy_panel.Name = "Buy_panel";
			this.Buy_panel.Size = new System.Drawing.Size(465, 136);
			this.Buy_panel.TabIndex = 1;
			// 
			// btn_Buy
			// 
			this.btn_Buy.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Buy.Location = new System.Drawing.Point(235, 54);
			this.btn_Buy.Name = "btn_Buy";
			this.btn_Buy.Size = new System.Drawing.Size(217, 63);
			this.btn_Buy.TabIndex = 16;
			this.btn_Buy.Text = "Купити";
			this.btn_Buy.UseVisualStyleBackColor = false;
			this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(204, 25);
			this.label6.TabIndex = 15;
			this.label6.Text = "Введіть ID товару";
			// 
			// IdSelect_Buy
			// 
			this.IdSelect_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IdSelect_Buy.Location = new System.Drawing.Point(36, 82);
			this.IdSelect_Buy.Name = "IdSelect_Buy";
			this.IdSelect_Buy.Size = new System.Drawing.Size(133, 35);
			this.IdSelect_Buy.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(146, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 29);
			this.label5.TabIndex = 13;
			this.label5.Text = "Купити Товар";
			// 
			// Add_panel
			// 
			this.Add_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Add_panel.Controls.Add(this.ProdPrice_Add);
			this.Add_panel.Controls.Add(this.ProdName_Add);
			this.Add_panel.Controls.Add(this.label4);
			this.Add_panel.Controls.Add(this.label3);
			this.Add_panel.Controls.Add(this.btn_Add);
			this.Add_panel.Controls.Add(this.label2);
			this.Add_panel.Location = new System.Drawing.Point(323, 154);
			this.Add_panel.Name = "Add_panel";
			this.Add_panel.Size = new System.Drawing.Size(232, 229);
			this.Add_panel.TabIndex = 2;
			// 
			// ProdPrice_Add
			// 
			this.ProdPrice_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ProdPrice_Add.Location = new System.Drawing.Point(36, 146);
			this.ProdPrice_Add.Name = "ProdPrice_Add";
			this.ProdPrice_Add.Size = new System.Drawing.Size(133, 35);
			this.ProdPrice_Add.TabIndex = 18;
			// 
			// ProdName_Add
			// 
			this.ProdName_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ProdName_Add.Location = new System.Drawing.Point(36, 84);
			this.ProdName_Add.Name = "ProdName_Add";
			this.ProdName_Add.Size = new System.Drawing.Size(154, 31);
			this.ProdName_Add.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(31, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 25);
			this.label4.TabIndex = 16;
			this.label4.Text = "Ціна товару";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(31, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 25);
			this.label3.TabIndex = 15;
			this.label3.Text = "Назва товару";
			// 
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Add.Location = new System.Drawing.Point(8, 184);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(217, 38);
			this.btn_Add.TabIndex = 14;
			this.btn_Add.Text = "Додати";
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(18, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 29);
			this.label2.TabIndex = 13;
			this.label2.Text = "Додати Товар";
			// 
			// Delete_panel
			// 
			this.Delete_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Delete_panel.Controls.Add(this.label1);
			this.Delete_panel.Controls.Add(this.lbl1);
			this.Delete_panel.Controls.Add(this.IdSelect_Delete);
			this.Delete_panel.Controls.Add(this.btn_Delete);
			this.Delete_panel.Location = new System.Drawing.Point(561, 154);
			this.Delete_panel.Name = "Delete_panel";
			this.Delete_panel.Size = new System.Drawing.Size(227, 229);
			this.Delete_panel.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 29);
			this.label1.TabIndex = 12;
			this.label1.Text = "Видалити Товар";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl1.Location = new System.Drawing.Point(10, 104);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(204, 25);
			this.lbl1.TabIndex = 11;
			this.lbl1.Text = "Введіть ID товару";
			// 
			// IdSelect_Delete
			// 
			this.IdSelect_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IdSelect_Delete.Location = new System.Drawing.Point(44, 132);
			this.IdSelect_Delete.Name = "IdSelect_Delete";
			this.IdSelect_Delete.Size = new System.Drawing.Size(133, 35);
			this.IdSelect_Delete.TabIndex = 10;
			// 
			// btn_Delete
			// 
			this.btn_Delete.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Delete.Location = new System.Drawing.Point(3, 184);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(217, 38);
			this.btn_Delete.TabIndex = 9;
			this.btn_Delete.Text = "Видалити";
			this.btn_Delete.UseVisualStyleBackColor = false;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Exit.Location = new System.Drawing.Point(429, 389);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(264, 49);
			this.btn_Exit.TabIndex = 5;
			this.btn_Exit.Text = "Вихід";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.lbl_Balance);
			this.panel1.Controls.Add(this.lbl2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(305, 50);
			this.panel1.TabIndex = 6;
			// 
			// lbl_Balance
			// 
			this.lbl_Balance.AutoSize = true;
			this.lbl_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_Balance.Location = new System.Drawing.Point(138, 5);
			this.lbl_Balance.Name = "lbl_Balance";
			this.lbl_Balance.Size = new System.Drawing.Size(33, 33);
			this.lbl_Balance.TabIndex = 12;
			this.lbl_Balance.Text = "[]";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl2.Location = new System.Drawing.Point(3, 5);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(129, 33);
			this.lbl2.TabIndex = 11;
			this.lbl2.Text = "Баланс:";
			// 
			// ProductsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.Delete_panel);
			this.Controls.Add(this.Add_panel);
			this.Controls.Add(this.Buy_panel);
			this.Controls.Add(this.ProductList);
			this.Name = "ProductsForm";
			this.Text = "ProductsForm";
			this.Buy_panel.ResumeLayout(false);
			this.Buy_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IdSelect_Buy)).EndInit();
			this.Add_panel.ResumeLayout(false);
			this.Add_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProdPrice_Add)).EndInit();
			this.Delete_panel.ResumeLayout(false);
			this.Delete_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IdSelect_Delete)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView ProductList;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader ProdName;
		private System.Windows.Forms.ColumnHeader ProdPrice;
		private System.Windows.Forms.Panel Buy_panel;
		private System.Windows.Forms.Panel Add_panel;
		private System.Windows.Forms.Panel Delete_panel;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.NumericUpDown IdSelect_Delete;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ProdName_Add;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Buy;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown IdSelect_Buy;
		private System.Windows.Forms.NumericUpDown ProdPrice_Add;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_Balance;
		private System.Windows.Forms.Label lbl2;
	}
}