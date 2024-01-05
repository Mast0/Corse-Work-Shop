using Shop_CW.Db.Entity;
using Shop_CW.Db.Repository;
using Shop_CW.Db.Service.Base;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Service
{
	public class PurchaseService : IPurchaseService
	{
		PurchaseRepository repository;
		public PurchaseService(DbContext context)
		{
			repository = new PurchaseRepository(context);
		}

		public void Create(string prodName, int prodPrice, string custName, int custBalance)
		{
			repository.Create(prodName, prodPrice, custName, custBalance);
		}
		public List<Purchase> GetAll()
		{
			return repository.GetAll().Select(x => Map(x)).ToList();
		}
		public Purchase GetById(int id)
		{
			return Map(repository.GetById(id));
		}
		public void Update(Purchase purchase)
		{
			repository.Update(Map(purchase));
		}
		public void Delete(Purchase purchase)
		{
			repository.Delete(Map(purchase));
		}

		private Purchase Map(PurchaseEntity purchase)
		{
			return new Purchase
			{
				Id = purchase.Id,
				ProductName = purchase.ProductName,
				ProductPrice = purchase.ProductPrice,
				CustomerName = purchase.CustomerName,
				Balance = purchase.Balance,
			};
		}
		private PurchaseEntity Map(Purchase purchase)
		{
			return new PurchaseEntity
			{
				Id = purchase.Id,
				ProductName = purchase.ProductName,
				ProductPrice = purchase.ProductPrice,
				CustomerName = purchase.CustomerName,
				Balance = purchase.Balance,
			};
		}
	}
}
