using Shop_CW.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Service.Base
{
	public interface IPurchaseService
	{
		void Create(string prodName, int prodPrice, string custName, int custBalance);
		List<Purchase> GetAll();
		Purchase GetById(int id);
		void Update(Purchase purchase);
		void Delete(Purchase purchase);
	}
}
