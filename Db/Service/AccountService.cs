using Shop_CW.Accounts;
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
	public class AccountService : IAccountService
	{
		AccountRepository repository;
		public AccountService(DbContext context)
		{
			repository = new AccountRepository(context);
		}

		public void Create(string userName, string password, AccountTypes type)
		{
			repository.Create(userName, password, type);
		}
		public List<BaseAcc> GetAll()
		{
			return repository.GetAll().Select(x => Map(x)).ToList();
		}
		public BaseAcc GetByName(string name)
		{
			return Map(repository.GetByName(name));
		}
		public void Update(BaseAcc acc)
		{
			repository.Update(Map(acc));
		}
		public void Delete(BaseAcc acc)
		{
			repository.Delete(Map(acc));
		}

		private BaseAcc Map(AccountEntity entity)
		{
			switch (entity.Type)
			{
				case AccountTypes.ADMIN:
					return new AdminAccount(entity.UserName, entity.Password)
					{
						Id = entity.Id,
						Type = entity.Type,
						Balance = entity.Balance,
					};
				case AccountTypes.VENDOR:
					return new VendorAccount(entity.UserName, entity.Password)
					{
						Id = entity.Id,
						Type = entity.Type,
						Balance = entity.Balance,
					};
				default:
					return new CustomerAccount(entity.UserName, entity.Password)
					{
						Id = entity.Id,
						Type = entity.Type,
						Balance = entity.Balance,
					};
			}
		}
		private AccountEntity Map(BaseAcc acc)
		{
			return new AccountEntity
			{
				Id = acc.Id,
				Type = acc.Type,
				UserName = acc.UserName,
				Password = acc.Password,
				Balance = acc.Balance,
				IsAdmin = acc.IsAdmin,
				IsVendor = acc.IsVendor,
			};
		}
	}
}
