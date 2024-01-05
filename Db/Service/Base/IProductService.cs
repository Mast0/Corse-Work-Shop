using Shop_CW.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Service.Base
{
	public interface IProductService
	{
		void Create(string name, int price);
		List<Product> GetAll();
		Product GetById(int id);
		void Update(Product product);
		void Delete(Product product);
	}
}
