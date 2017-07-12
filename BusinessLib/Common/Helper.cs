using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

using BusinessLib.Data;

namespace BusinessLib.Common
{
	/// <summary>
	/// Helper class, storage for static methods used as a general pupose;
	/// @see: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// </summary>
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

		public static IList<KeyValuePair<string, string>> GetProvinces()
		{
			return ProvinceRepository.GetProvinces().Select(x => new KeyValuePair<string, string>(x.Abbreviation, x.ProvinceDisplay)).ToList();
		}
	}
}