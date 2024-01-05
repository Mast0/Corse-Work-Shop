using Shop_CW.Accounts;
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
	public partial class Register : Form
	{
		Form prev;
		AccountService accountService;
		ProductService productService;
		PurchaseService purchaseService;
		AccountTypes type;
		public Register(AccountService accountService, ProductService productService, PurchaseService purchaseService, Form prevForm)
		{
			InitializeComponent();
			InitComboBox();
			btn_Register.Enabled = false;
			this.prev = prevForm;
			this.accountService = accountService;
			this.productService = productService;
			this.purchaseService = purchaseService;
		}

		private void InitComboBox()
		{
			CBox_Type.Items.Add("Адмін");
			CBox_Type.Items.Add("Продавець");
			CBox_Type.Items.Add("Покупець");
		}

		private void btn_Return_Click(object sender, EventArgs e)
		{
			prev.Show();
			this.Dispose();
		}

		private void CBox_Type_SelectedIndexChanged(object sender, EventArgs e)
		{
			btn_Register.Enabled = true;
			switch (CBox_Type.Text)
			{
				case "Адмін":
					type = AccountTypes.ADMIN;
					break;
				case "Продавець":
					type = AccountTypes.VENDOR;
					break;
				case "Покупець":
					type = AccountTypes.CUSTOMER;
					break;
			}
		}

		private void btn_Register_Click(object sender, EventArgs e)
		{
			accountService.Create(TBox_Name.Text, TBox_Password.Text, type);
			Form form = new Main(accountService, productService, purchaseService, prev, TBox_Name.Text);
			form.Show();
			this.Dispose();
		}
	}
}
