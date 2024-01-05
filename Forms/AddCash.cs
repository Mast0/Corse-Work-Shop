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
	public partial class AddCash : Form
	{
		AccountService accountService;
		Main prev;
		string AccountName;
		public AddCash(AccountService accountService, Main prevForm, string accName)
		{
			InitializeComponent();
			this.prev = prevForm;
			this.accountService = accountService;
			AccountName = accName;
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			prev.Show();
			prev.lblInit();
			this.Dispose();
		}

		private void btn_AddCash_Click(object sender, EventArgs e)
		{
			var acc = accountService.GetByName(AccountName);
			acc.AddCash(Convert.ToInt32(Cash.Value));
			accountService.Update(acc);
			Cash.Value = 0;
			MessageBox.Show("Рахунок успішно поповнено", "Мій Магазин", MessageBoxButtons.OK);
		}
	}
}
