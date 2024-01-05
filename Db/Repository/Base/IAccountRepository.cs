using Shop_CW.Accounts;
using Shop_CW.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Repository.Base
{
	public interface IAccountRepository
	{
		void Create(string userName, string password, AccountTypes type);
		List<AccountEntity> GetAll();
		AccountEntity GetByName(string name);
		void Update(AccountEntity account);
		void Delete(AccountEntity account);
	}
}
