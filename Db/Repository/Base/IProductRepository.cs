using Shop_CW.Accounts;
using Shop_CW.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Repository.Base
{
	public interface IProductRepository
	{
		void Create(string name, int price);
		List<ProductEntity> GetAll();
		ProductEntity GetById(int id);
		void Update(ProductEntity product);
		void Delete(ProductEntity product);
	}
}
