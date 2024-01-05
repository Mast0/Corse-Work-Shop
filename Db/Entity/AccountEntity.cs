using Shop_CW.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Db.Entity
{
	public class AccountEntity
	{
		public int Id { get; set; }
		public AccountTypes Type { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int Balance { get; set; }
		public bool IsAdmin { get; set; }
		public bool IsVendor { get; set; }
	}
}
