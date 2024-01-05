using Shop_CW.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Service.Base
{
	public interface IAccountService
	{
		void Create(string userName, string password, AccountTypes type);
		List<BaseAcc> GetAll();
		BaseAcc GetByName(string name);
		void Update(BaseAcc account);
		void Delete(BaseAcc account);
	}
}
