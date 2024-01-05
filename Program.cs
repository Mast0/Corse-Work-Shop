using Shop_CW.Db;
using Shop_CW.Db.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_CW
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			DbContext db = new DbContext();

			AccountService accountService = new AccountService(db);
			ProductService productService = new ProductService(db);
			PurchaseService purchaseService = new PurchaseService(db);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Start(accountService, productService, purchaseService));
		}
	}
}
