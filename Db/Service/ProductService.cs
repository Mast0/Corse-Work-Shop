using Shop_CW.Db.Entity;
using Shop_CW.Db.Repository;
using Shop_CW.Db.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Service
{
	public class ProductService : IProductService
	{
		ProductRepository repository;
		public ProductService(DbContext context)
		{
			repository = new ProductRepository(context);
		}

		public void Create(string name, int price)
		{
			repository.Create(name, price);
		}
		public List<Product> GetAll()
		{
			return repository.GetAll().Select(x => Map(x)).ToList();
		}
		public Product GetById(int id)
		{
			return Map(repository.GetById(id));
		}
		public void Update(Product product)
		{
			repository.Update(Map(product));
		}
		public void Delete(Product product)
		{
			repository.Delete(Map(product));
		}

		private Product Map(ProductEntity product)
		{
			return new Product
			{
				Id = product.Id,
				ProductName = product.ProductName,
				ProductPrice = product.ProductPrice,
			};
		}
		private ProductEntity Map(Product product)
		{
			return new ProductEntity
			{
				Id = product.Id,
				ProductName = product.ProductName,
				ProductPrice = product.ProductPrice,
			};
		}
	}
}
