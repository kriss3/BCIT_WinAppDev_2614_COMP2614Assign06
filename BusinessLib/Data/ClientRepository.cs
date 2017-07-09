using System;
using System.Data;
using System.Data.SqlClient;

using BusinessLib.Common;

namespace BusinessLib.Data
{
	public class ClientRepository
	{
		public static ClientCollection GetClients()
		{
			ClientCollection clients;

			using (SqlConnection sqlConn = new SqlConnection(Helper.GetConnectionString()))
			{
				var query = @"Select ClientCode, CompanyName, Address1, City, Province,
							  PostalCode, YTDSales, CreditHold, Notes 
							  from dbo.Client013054";

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
							YTDSale = (decimal)dr["YTDSales"];
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

		public static int AddClient(Client client)
		{
			using (SqlConnection conn = new SqlConnection(Helper.GetConnectionString()))
			{
				string query = @"Insert into dbo.Client013054
								 (ClientCode, 
								 CompanyName, 
								 Address1, 
								 City, 
								 Province,
								 PostalCode, 
								 YTDSales, 
								 CreditHold, 
								 Notes)
								VALUES (@clientCode, 
										@companyName, 
										@address1, 
										@city, 
										@province, 
										@postalCode,
										@ytdSales,
										@creditHold,
										@notes)";

				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = query;
					cmd.Connection = conn;
					cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

					if (client.CompanyName != null)
					{
						cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
					}
					else
					{
						cmd.Parameters.AddWithValue("@companyName", DBNull.Value);
					}

					if (client.Address1 != null)
					{
						cmd.Parameters.AddWithValue("@address1", client.Address1);
					}
					else
					{
						cmd.Parameters.AddWithValue("@address1", DBNull.Value);
					}

					cmd.Parameters.AddWithValue("@city", client.City);
					cmd.Parameters.AddWithValue("@province", client.Province);
					cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
					cmd.Parameters.AddWithValue("@ytdSales", client.YTDSale);
					cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

					if (client.Notes != null)
					{
						cmd.Parameters.AddWithValue("@notes", client.Notes);
					}
					else
					{
						cmd.Parameters.AddWithValue("@notes", DBNull.Value);
					}

					conn.Open();

					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected;
				}
			}
		}

		public static int UpdateClient(Client client)
		{
			using (SqlConnection conn = new SqlConnection(Helper.GetConnectionString()))
			{
				string query = @"UPDATE dbo.Client013054
								 SET ClientCode = @clientCode
								   , CompanyName = @companyName
								   , Address1 = @address1
								   , City = @city
								   , Province = @province
								   , PostalCode = @postalCode
								   , YTDSales = @ytdSales
								   , CreditHold = @creditHold
								   , Notes = @notes
								 WHERE ClientCode = @clientCode";

				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = query;
					cmd.Connection = conn;

					cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

					cmd.Parameters.AddWithValue("@companyName", client.CompanyName);

					if (client.Address1 != null)
					{
						cmd.Parameters.AddWithValue("@address1", client.Address1);
					}
					else
					{
						cmd.Parameters.AddWithValue("@address1", DBNull.Value);
					}

					if (client.City != null)
					{
						cmd.Parameters.AddWithValue("@city", client.City);
					}
					else
					{
						cmd.Parameters.AddWithValue("@city", DBNull.Value);
					}

					cmd.Parameters.AddWithValue("@province", client.Province);
					cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
					cmd.Parameters.AddWithValue("@ytdSales", client.YTDSale);
					cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

					if (client.Notes != null)
					{
						cmd.Parameters.AddWithValue("@notes", client.Notes);
					}
					else
					{
						cmd.Parameters.AddWithValue("@notes", DBNull.Value);
					}

					conn.Open();

					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected;
				}
			}
		}

		public static int DeleteProduct(Client client)
		{
			using (SqlConnection conn = new SqlConnection(Helper.GetConnectionString()))
			{
				string query = @"DELETE dbo.Client013054
								 WHERE ClientCode = @clientCode";

				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = query;
					cmd.Connection = conn;
					cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

					conn.Open();

					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected;
				}
			}
		}

	}
}

