using Shop_CW.Db.Entity;
using Shop_CW.Db.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Repository
{
	public class PurchaseRepository : IPurchaseRepository
	{
		DbContext context;
		public PurchaseRepository(DbContext context)
		{
			this.context = context;
		}

		public void Create(string prodName, int prodPrice, string custName, int custBalance)
		{
			context.purchases.Add(new PurchaseEntity
			{
				Id = context.purchases.Count,
				ProductName = prodName,
				ProductPrice = prodPrice,
				CustomerName = custName,
				Balance = custBalance,
			});
		}
		public List<PurchaseEntity> GetAll()
		{
			return context.purchases;
		}
		public PurchaseEntity GetById(int id)
		{
			return context.purchases[id];
		}
		public void Update(PurchaseEntity purchase)
		{
			context.purchases.RemoveAt(purchase.Id);
			context.purchases.Insert(purchase.Id, purchase);
		}
		public void Delete(PurchaseEntity purchase)
		{
			context.purchases.RemoveAt(purchase.Id);
			int ID = 0;
			foreach (var purchase1 in context.purchases)
			{
				purchase1.Id = ID;
				ID++;
			}
		}
	}
}
