using BusinessLib.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLib.Data
{
	/// <summary>
	/// @Author: Krzysztof Szczurowski
	/// @Repo: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// @Date: June 2017
	/// </summary>
	public class ProvinceRepository
	{
		public static IList<Province> GetProvinces()
		{
			List<Province> provinces = null;

			using (SqlConnection conn = new SqlConnection(Helper.GetConnectionString()))
			{
				string provincesQuery = @"select ProvinceId, Abbreviation, Name from dbo.Province";
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = provincesQuery;
					cmd.Connection = conn;

					conn.Open();
					provinces = new List<Province> { new Province { Abbreviation = "Select", ProvinceDisplay = "<Select Province>" } };
					
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						string abb, provinceName, provinceDisplay = String.Empty;
						int id;

						while (dr.Read())
						{
							id = Convert.ToInt32(dr["ProvinceId"]);
							abb = dr["Abbreviation"] as string;
							provinceName = dr["Name"] as string;
							provinceDisplay = $"{abb} - {provinceName}";

							provinces.Add(new Province { Id = id, Abbreviation = abb, Name = provinceName, ProvinceDisplay = provinceDisplay });
						}
					}

				}
			}

			return provinces; 
		}
	}
}
