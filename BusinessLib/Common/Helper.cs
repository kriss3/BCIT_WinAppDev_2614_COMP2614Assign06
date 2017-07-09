using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using BusinessLib.Data;

namespace BusinessLib.Common
{
	public class Helper
	{
		public static string GetConnectionString()
		{
			return ConfigurationManager.AppSettings["connString"];
		}

		public static ClientCollection GetData()
		{
			return ClientRepository.GetClients();
		}

		public static string GetTitle()
		{
			return Environment.UserName;
		}
	}
}
