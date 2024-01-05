using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW.Accounts
{
	abstract public class BaseAcc
	{
		public int Id { get; set; }
		public AccountTypes Type { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int Balance { get; set; }
		public bool IsAdmin { get; set; }
		public bool IsVendor { get; set; }

		public BaseAcc(string name, string password) 
		{
			UserName = name;
			Password = password;
			Balance = 50;
			IsAdmin = false;
			IsVendor = false;
		}

		public void AddCash(int cash)
		{
			Balance += cash;
		}
		public bool Buy(int price)
		{
			if (Balance-price < 0)
			{
				return false;
			}
			Balance -= price;
			return true;
		}
	}
}
