﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_CW
{
	public class Purchase
	{
		public int Id {  get; set; }
		public string ProductName {  get; set; }
		public int ProductPrice {  get; set; }
		public string CustomerName {  get; set; }
		public int Balance {  get; set; }
	}
}
