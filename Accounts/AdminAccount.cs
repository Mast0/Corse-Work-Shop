using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Accounts
{
	public class AdminAccount : BaseAcc
	{
		public AdminAccount(string name, string password) : base(name, password) 
		{
			IsAdmin = true;
		}
	}
}
