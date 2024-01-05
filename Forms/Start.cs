using Shop_CW.Db.Service;
using Shop_CW.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_CW
{
	public partial class Start : Form
	{
		AccountService accountService;
		ProductService productService;
		PurchaseService purchaseService;
		public Start(AccountService accountService, ProductService productService, PurchaseService purchaseService)
		{
			InitializeComponent();
			this.accountService = accountService;
			this.productService = productService;
			this.purchaseService = purchaseService;
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_LogIn_Click(object sender, EventArgs e)
		{
			Form form = new LogIn(accountService, productService, purchaseService, this);
			form.Show();
			this.Visible = false;
		}

		private void btn_Register_Click(object sender, EventArgs e)
		{
			Form form = new Register(accountService, productService, purchaseService, this);
			form.Show();
			this.Visible = false;
		}
	}
}
