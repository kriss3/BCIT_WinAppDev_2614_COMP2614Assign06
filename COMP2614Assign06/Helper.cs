﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace COMP2614Assign06
{
	class Helper
	{
		public static string GetConnectionString()
		{
			return ConfigurationManager.AppSettings["connString"];
		}

		public static void GetData()
		{
			ClientRepository.GetClients();
		}
	}
}