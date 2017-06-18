using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06
{
	class ClientRepository
	{
		public static ClientCollection GetClients()
		{
			ClientCollection clients;

			using (SqlConnection sqlConn = new SqlConnection(Helper.GetConnectionString()))
			{
				var query = @"Select ClientCode, CompanyName, Address1, City, Province,
							  PostalCode, YTDSale, CreditHold, Notes from dbo.Client";

				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = query;
					cmd.Connection = sqlConn;

					sqlConn.Open();

					clients = new ClientCollection();

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						string ClientCode, CompanyName, Address1, City, Province, PostalCode, Notes = String.Empty;
						decimal YTDSale;
						bool CreditHold = false;

						while (dr.Read())
						{
							ClientCode = dr["ClientCode"] as string;
							CompanyName = dr["CompanyName"] as string;
							Address1 = dr["Address1"] as string;
							City = dr["City"] as string;
							Province = dr["Province"] as string;
							PostalCode = dr["PostalCode"] as string;
							YTDSale = (decimal)dr["YTDSale"];
							CreditHold = (bool)dr["CreditHold"];
							Notes = dr["Notes"] as string;

							clients.Add(new Client(ClientCode, CompanyName, Address1, City, Province,
													PostalCode, YTDSale, CreditHold, Notes));
						}
					}
				}
			}
			return clients;
		}
	}
}
