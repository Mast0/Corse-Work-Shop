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
	public partial class PurchasesForm : Form
	{
		AccountService accountService;
		PurchaseService purchaseService;
		Form prev;
		string AccountName;
		public PurchasesForm(AccountService accountService, PurchaseService purchaseService, Form prevForm, string accName)
		{
			InitializeComponent();
			this.accountService = accountService;
			this.purchaseService = purchaseService;
			this.prev = prevForm;
			this.AccountName = accName;
			Init();
		}
		private void Init()
		{
			var acc = accountService.GetByName(AccountName);
			ListInit();
			if (!acc.IsAdmin)
			{
				lbl1.Visible = false;
				lbl1.Enabled = false;

				IdSelect.Visible = false;
				IdSelect.Enabled = false;

				btn_DeletePurchase.Visible = false;
				btn_DeletePurchase.Enabled = false;
			}
		}
		private void ListInit()
		{
			var acc = accountService.GetByName(AccountName);
			PurchasesList.Items.Clear();
			if (acc.IsAdmin)
			{
				foreach (var purchase in purchaseService.GetAll())
				{
					string[] temp = { purchase.Id.ToString(), purchase.CustomerName, purchase.Balance.ToString(), purchase.ProductName, purchase.ProductPrice.ToString() };
					PurchasesList.Items.Add(new ListViewItem(temp));
				}
			}
			else
			{
				foreach (var purchase in purchaseService.GetAll())
				{
					if (acc.UserName == purchase.CustomerName)
					{
						string[] temp = { purchase.Id.ToString(), purchase.CustomerName, purchase.Balance.ToString(), purchase.ProductName, purchase.ProductPrice.ToString() };
						PurchasesList.Items.Add(new ListViewItem(temp));
					}
				}
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			prev.Show();
			this.Dispose();
		}

		private void btn_DeletePurchase_Click(object sender, EventArgs e)
		{
			if(IdSelect.Value < purchaseService.GetAll().Count) 
			{
				purchaseService.Delete(purchaseService.GetById(Convert.ToInt32(IdSelect.Value)));
				MessageBox.Show("Видалено успішно", "Мій Магазин", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("Невірний ID", "Мій Магазин", MessageBoxButtons.OK);
			}
			IdSelect.Value = 0;
		}
	}
}
