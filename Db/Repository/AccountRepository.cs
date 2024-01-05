using Shop_CW.Accounts;
using Shop_CW.Db.Entity;
using Shop_CW.Db.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Repository
{
	public class AccountRepository : IAccountRepository
	{
		DbContext context;
		public AccountRepository(DbContext context)
		{
			this.context = context;
		}
		public void Create(string userName, string password, AccountTypes type)
		{
			context.accounts.Add(new AccountEntity
			{
				Id = context.accounts.Count,
				Type = type,
				UserName = userName,
				Password = password,
				Balance = 50,
				IsAdmin = false,
				IsVendor = false,
			});
		}
		public List<AccountEntity> GetAll()
		{
			return context.accounts;
		}
		public AccountEntity GetByName(string name)
		{
			return context.accounts.FirstOrDefault(x => x.UserName == name);
		}
		public void Update(AccountEntity account)
		{
			context.accounts.RemoveAt(account.Id);
			context.accounts.Insert(account.Id, account);
		}
		public void Delete(AccountEntity account)
		{
			context.accounts.RemoveAt(account.Id);
			int ID = 0;
			foreach (var acc in context.accounts)
			{
				acc.Id = ID;
				ID++;
			}
		}
	}
}
