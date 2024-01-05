using Shop_CW.Db.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_CW.Forms
{
	public partial class ProductsForm : Form
	{
		AccountService accountService;
		ProductService productService;
		PurchaseService purchaseService;
		Main prev;
		string AccountName;
		public ProductsForm(AccountService accountService, ProductService productService, PurchaseService purchaseService, Main prev, string accountName)
		{
			InitializeComponent();
			this.accountService = accountService;
			this.productService = productService;
			this.purchaseService = purchaseService;
			this.prev = prev;
			AccountName = accountName;
			Init();
		}
		private void Init()
		{
			var acc = accountService.GetByName(AccountName);
			ListInit();
			BalanceInit();
			Add_panel.Enabled = false;
			Add_panel.Visible = false;

			Delete_panel.Enabled = false;
			Delete_panel.Visible = false;

			if (acc.IsVendor)
			{
				Add_panel.Enabled = true;
				Add_panel.Visible = true;
			}
			if (acc.IsAdmin)
			{
				Add_panel.Enabled = true;
				Add_panel.Visible = true;

				Delete_panel.Enabled = true;
				Delete_panel.Visible = true;
			}
		}

		private void ListInit()
		{
			ProductList.Items.Clear();
			if (productService.GetAll() == null) return;
			foreach (var prod in productService.GetAll())
			{
				string[] temp = { prod.Id.ToString(), prod.ProductName, prod.ProductPrice.ToString() };
				ProductList.Items.Add(new ListViewItem(temp));
			}
		}

		private void BalanceInit()
		{
			lbl_Balance.Text = accountService.GetByName(AccountName).Balance.ToString();
			prev.lblInit();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			prev.Show();
			this.Dispose();
		}

		private void btn_Buy_Click(object sender, EventArgs e)
		{
			var acc = accountService.GetByName(AccountName);
			if(IdSelect_Buy.Value < productService.GetAll().Count)
			{
				var prod = productService.GetById(Convert.ToInt32(IdSelect_Buy.Value));
				if (acc.Buy(prod.ProductPrice))
				{
					accountService.Update(acc);
					purchaseService.Create(prod.ProductName, prod.ProductPrice, acc.UserName, acc.Balance);
					productService.Delete(prod);
					ListInit();
					BalanceInit();
					MessageBox.Show("Товар успішно придбаний", "Мій Магазин", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("Замало коштів на рахунку", "Мій Магазин", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Введено не існуюче ID", "Мій Магазин", MessageBoxButtons.OK);
			}
			IdSelect_Buy.Value = 0;
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			productService.Create(ProdName_Add.Text, Convert.ToInt32(ProdPrice_Add.Value));
			ProdName_Add.Text = "";
			ProdPrice_Add.Value = 0;
			ListInit();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (IdSelect_Delete.Value < productService.GetAll().Count)
			{
				productService.Delete(productService.GetById(Convert.ToInt32(IdSelect_Delete.Value)));
				ListInit();
			}
			else
			{
				MessageBox.Show("Введено не існуюче ID", "Мій Магазин", MessageBoxButtons.OK);
			}
			IdSelect_Buy.Value = 0;
		}
	}
}
