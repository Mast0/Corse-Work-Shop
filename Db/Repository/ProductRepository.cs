using Shop_CW.Db.Entity;
using Shop_CW.Db.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Repository
{
	public class ProductRepository : IProductRepository
	{
		DbContext context;
		public ProductRepository(DbContext context)
		{
			this.context = context;
		}

		public void Create(string name, int price)
		{
			context.goods.Add(new ProductEntity
			{
				Id = context.goods.Count,
				ProductName = name,
				ProductPrice = price,
			});
		}
		public List<ProductEntity> GetAll()
		{
			return context.goods;
		}
		public ProductEntity GetById(int id)
		{
			return context.goods[id];
		}
		public void Update(ProductEntity product)
		{
			context.goods.RemoveAt(product.Id);
			context.goods.Insert(product.Id, product);
		}
		public void Delete(ProductEntity product)
		{
			context.goods.RemoveAt(product.Id);
			int ID = 0;
			foreach (var prod in context.goods)
			{
				prod.Id = ID;
				ID++;
			}
		}
	}
}
