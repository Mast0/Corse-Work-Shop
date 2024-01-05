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
	public partial class LogIn : Form
	{
		Form prev;
		AccountService accountService;
		ProductService productService;
		PurchaseService purchaseService;
		public LogIn(AccountService accountService, ProductService productService, PurchaseService purchaseService, Form prevForm)
		{
			InitializeComponent();
			this.accountService = accountService;
			this.productService = productService;
			this.purchaseService = purchaseService;
			prev = prevForm;
		}

		private void btn_Return_Click(object sender, EventArgs e)
		{
			prev.Show();
			this.Dispose();
		}

		private void btn_LogIn_Click(object sender, EventArgs e)
		{
			var acc = accountService.GetByName(TBox_Name.Text);
			if (acc != null)
			{
				if (acc.Password == TBox_Password.Text)
				{
					Form form = new Main(accountService, productService, purchaseService, prev, TBox_Name.Text);
					form.Show();
					this.Dispose();
				}
				else
				{
					MessageBox.Show("Мій Магазин", "Невірний пароль", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Мій Магазин", "Невірне ім'я", MessageBoxButtons.OK);
			}
		}
	}
}
