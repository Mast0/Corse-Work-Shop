using Shop_CW.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_CW.Db
{
	public class DbContext
	{
		public List<AccountEntity> accounts;
		public List<ProductEntity> goods;
		public List<PurchaseEntity> purchases;
		Json<AccountEntity> AccountsJson;
		Json<ProductEntity> GoodsJson;
		Json<PurchaseEntity> PurchasesJson;
		public DbContext() 
		{
			accounts = new List<AccountEntity>();
			goods = new List<ProductEntity>();
			purchases = new List<PurchaseEntity>();

			AccountsJson = new Json<AccountEntity>("D:\\trash\\OOP\\Shop_CW\\Db\\Json\\accounts.json");
			GoodsJson = new Json<ProductEntity>("D:\\trash\\OOP\\Shop_CW\\Db\\Json\\goods.json");
			PurchasesJson = new Json<PurchaseEntity>("D:\\trash\\OOP\\Shop_CW\\Db\\Json\\purchases.json");

			InitDb();
		}
		~DbContext()
		{
			AccountsJson.Write(accounts);
			GoodsJson.Write(goods);
			PurchasesJson.Write(purchases);
		}

		private void InitDb()
		{
			var _accountsJson = AccountsJson.Read();
			if(_accountsJson != null)
			{
				accounts = _accountsJson;
			}

			var _goodsJson = GoodsJson.Read();
			if(_goodsJson != null)
			{
				goods = _goodsJson;
			}

			var _purchasesJson = PurchasesJson.Read();
			if(_purchasesJson != null)
			{
				purchases = _purchasesJson;
			}
		}
	}
}
