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
	public partial class Main : Form
	{
		Form prev;
		AccountService accountService;
		ProductService productService;
		PurchaseService purchaseService;
		string AccountName;
		public Main(AccountService accountService, ProductService productService, PurchaseService purchaseService, Form prevForm, string accName)
		{
			InitializeComponent();
			prev = prevForm;
			this.accountService = accountService;
			this.productService = productService;
			this.purchaseService = purchaseService;
			AccountName = accName;
			lblInit();
		}

		public void lblInit()
		{
			var acc = accountService.GetByName(AccountName);
			lbl_Name.Text = acc.UserName;
			lbl_Balance.Text = acc.Balance.ToString();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			prev.Show();
			this.Dispose();
		}

		private void btn_AddCash_Click(object sender, EventArgs e)
		{
			Form form = new AddCash(accountService, this, AccountName);
			form.Show();
			this.Visible = false;
		}

		private void btn_Purchases_Click(object sender, EventArgs e)
		{
			Form form = new PurchasesForm(accountService, purchaseService, this, AccountName);
			form.Show();
			this.Visible = false;
		}

		private void btn_Goods_Click(object sender, EventArgs e)
		{
			Form form = new ProductsForm(accountService, productService, purchaseService, this, AccountName);
			form.Show();
			this.Visible = false;
		}
	}
}
