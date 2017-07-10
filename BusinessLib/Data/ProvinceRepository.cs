using BusinessLib.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Data
{
	public class ProvinceRepository
	{
		public static List<String> GetProvinces()
		{
			List<String> provinces = null;

			using (SqlConnection conn = new SqlConnection(Helper.GetConnectionString()))
			{
				string provincesQuery = @"select abbreviation, name from dbo.Province";
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = provincesQuery;
					cmd.Connection = conn;

					conn.Open();
					provinces = new List<String>();
					provinces.Add("<Select PostCode>");

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						string abb, provinceName = String.Empty;

						while (dr.Read())
						{
							abb = dr["Abbreviation"] as string;
							provinceName = dr["Name"] as string;

							provinces.Add($"{abb}");
						}
					}

				}
			}

			return provinces; 
		}
	}
}
