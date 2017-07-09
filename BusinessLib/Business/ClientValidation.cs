﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BusinessLib.Common;
using BusinessLib.Data;
using System.Text.RegularExpressions;

namespace BusinessLib.Business
{
	public class ClientValidation
	{
		private static List<string> errors;

		static ClientValidation()
		{
			errors = new List<string>();
		}


		public static string ErrorMessage
		{
			get
			{
				string message = "";

				foreach (string line in errors)
				{
					message += line + "\r\n";
				}

				return message;
			}
		}


		public static ClientCollection GetClients() => ClientRepository.GetClients();

		public static int AddClient(Client client)
		{
			if (validate(client))
			{
				return ClientRepository.AddClient(client);
			}
			else
			{
				return -1;
			}
		}

		public static int UpdateClient(Client client)
		{
			
			if (validate(client))
			{
				return ClientRepository.UpdateClient(client);
			}
			else
			{
				return -1;
			}
		}

		public static int DeleteClient(Client client) => ClientRepository.DeleteProduct(client);

		/*	Rules:
		 *	CompanyName cannot be empty
		 *	Address1 cannot be empty
		 *	Province cannot by empty
		 *	YTDSales cannot be negative 
		 */
		private static bool validate(Client client)
		{
			bool success = true;
			errors.Clear();

			var clientCodePattern = @"[A-Z]{5}$";
			if (!Regex.IsMatch(client.ClientCode, clientCodePattern))
			{
				errors.Add("Client Code value must be 5 characters long!");
				success = false;
			}

			if (String.IsNullOrEmpty(client.CompanyName))
			{
				errors.Add("Company nama cannot be empty!");
				success = false;
			}

			if (String.IsNullOrEmpty(client.Address1))
			{
				errors.Add("Address field cannot be empty!");
				success = false;
			}

			if (String.IsNullOrEmpty(client.Province))
			{
				errors.Add("Province cannot be empty!");
				success = false;
			}

			if (client.YTDSale <= 0.0m)
			{
				errors.Add("Year to Date Sale cannot cannot be negative!");
				success = false;
			}
			return success;
		}
	}
}