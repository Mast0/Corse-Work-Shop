using Shop_CW.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Repository.Base
{
	public interface IPurchaseRepository
	{
		void Create(string prodName, int prodPrice, string custName, int custBalance);
		List<PurchaseEntity> GetAll();
		PurchaseEntity GetById(int id);
		void Update(PurchaseEntity purchase);
		void Delete(PurchaseEntity purchase);
	}
}
