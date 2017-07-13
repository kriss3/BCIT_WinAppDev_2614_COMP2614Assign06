using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

using BusinessLib.Data;

namespace BusinessLib.Common
{
	/// <summary>
	/// Helper class, storage for static methods used as a general pupose;
	/// @Author: Krzysztof Szczurowski
	/// @see: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// </summary>
	public class Helper
	{
		/// <summary>
		/// Static method to retun ConnectionString form app.config file;
		/// </summary>
		/// <returns>string with connectionString details</returns>
		public static string GetConnectionString()
		{
			return ConfigurationManager.AppSettings["connString"];
		}
		/// <summary>
		/// Returns string representing currently logged on user;
		/// </summary>
		/// <returns>Currently logged on User as String</returns>
		public static string GetTitle()
		{
			return Environment.UserName;
		}
		/// <summary>
		/// Method to build generic list of keyValue pair represinging Priovince Abbreviation and
		/// full name for display purpose;
		/// </summary>
		/// <returns>Returns interface of KeyValuePair required for Province comboBox</returns>
		public static IList<KeyValuePair<string, string>> GetProvinces()
		{
			return ProvinceRepository.GetProvinces()
				.Select(x => new KeyValuePair<string, string>(x.Abbreviation, x.ProvinceDisplay))
				.ToList();
		}
	}
}