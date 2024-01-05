namespace Shop_CW.Forms
{
	partial class PurchasesForm
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
			this.PurchasesList = new System.Windows.Forms.ListView();
			this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.reminder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_DeletePurchase = new System.Windows.Forms.Button();
			this.IdSelect = new System.Windows.Forms.NumericUpDown();
			this.lbl1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.IdSelect)).BeginInit();
			this.SuspendLayout();
			// 
			// PurchasesList
			// 
			this.PurchasesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.name,
            this.reminder,
            this.ProductName,
            this.ProductPrice});
			this.PurchasesList.HideSelection = false;
			this.PurchasesList.Location = new System.Drawing.Point(27, 12);
			this.PurchasesList.Name = "PurchasesList";
			this.PurchasesList.Size = new System.Drawing.Size(742, 293);
			this.PurchasesList.TabIndex = 0;
			this.PurchasesList.UseCompatibleStateImageBehavior = false;
			this.PurchasesList.View = System.Windows.Forms.View.Details;
			// 
			// Id
			// 
			this.Id.Text = "ID";
			this.Id.Width = 130;
			// 
			// name
			// 
			this.name.Text = "Ім\'я";
			this.name.Width = 130;
			// 
			// reminder
			// 
			this.reminder.Text = "Залишок";
			this.reminder.Width = 130;
			// 
			// ProductName
			// 
			this.ProductName.Text = "Назва товару";
			this.ProductName.Width = 130;
			// 
			// ProductPrice
			// 
			this.ProductPrice.Text = "Ціна товару";
			this.ProductPrice.Width = 130;
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Exit.Location = new System.Drawing.Point(524, 389);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(264, 49);
			this.btn_Exit.TabIndex = 4;
			this.btn_Exit.Text = "Вихід";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_DeletePurchase
			// 
			this.btn_DeletePurchase.BackColor = System.Drawing.Color.FloralWhite;
			this.btn_DeletePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_DeletePurchase.Location = new System.Drawing.Point(69, 389);
			this.btn_DeletePurchase.Name = "btn_DeletePurchase";
			this.btn_DeletePurchase.Size = new System.Drawing.Size(264, 49);
			this.btn_DeletePurchase.TabIndex = 5;
			this.btn_DeletePurchase.Text = "Видалити покупку";
			this.btn_DeletePurchase.UseVisualStyleBackColor = false;
			this.btn_DeletePurchase.Click += new System.EventHandler(this.btn_DeletePurchase_Click);
			// 
			// IdSelect
			// 
			this.IdSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IdSelect.Location = new System.Drawing.Point(111, 348);
			this.IdSelect.Name = "IdSelect";
			this.IdSelect.Size = new System.Drawing.Size(180, 35);
			this.IdSelect.TabIndex = 6;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl1.Location = new System.Drawing.Point(12, 316);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(387, 29);
			this.lbl1.TabIndex = 8;
			this.lbl1.Text = "Id товару що хочете видалити";
			// 
			// Purchases
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.IdSelect);
			this.Controls.Add(this.btn_DeletePurchase);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.PurchasesList);
			this.Name = "Purchases";
			this.Text = "Purchases";
			((System.ComponentModel.ISupportInitialize)(this.IdSelect)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView PurchasesList;
		private System.Windows.Forms.ColumnHeader Id;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader reminder;
		private System.Windows.Forms.ColumnHeader ProductName;
		private System.Windows.Forms.ColumnHeader ProductPrice;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_DeletePurchase;
		private System.Windows.Forms.NumericUpDown IdSelect;
		private System.Windows.Forms.Label lbl1;
	}
}