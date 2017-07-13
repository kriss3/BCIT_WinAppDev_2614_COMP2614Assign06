using System;
using System.Collections.Generic;

using BusinessLib.Common;
using BusinessLib.Data;
using System.Text.RegularExpressions;

namespace BusinessLib.Business
{
	/// <summary>
	/// @Author: Krzysztof Szczurowski
	/// @see Repo Location: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// @Date: June 2017
	/// </summary>
	public class ClientValidation
	{
		private static string PROVINCE_INDEX = "Select";
		private static List<string> errors;
		private static bool editMode;

		static ClientValidation()
		{
			errors = new List<string>();
		}
		/// <summary>
		/// Property to collect all error messages from different validation methos;
		/// </summary>
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
		/// <summary>
		/// Gets Client Data from Database;
		/// </summary>
		/// <returns></returns>
		public static ClientCollection GetClients() => ClientRepository.GetClients();
		public static int AddClient(Client client)
		{
			editMode = false;
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
			editMode = true;	
			if (validate(client))
			{
				return ClientRepository.UpdateClient(client);
			}
			else
			{
				return -1;
			}
		}
		public static int DeleteClient(Client client) => ClientRepository.DeleteClient(client);
		/*	Business Rules Requirements:
		 *	CompanyName cannot be empty
		 *	Address1 cannot be empty
		 *	Province cannot by empty
		 *	YTDSales cannot be negative 
		 *	Force the ClientCode to upper case and validate for pattern AAAAA.
		 *	PostCode in format: <A9A 9A9>
		 *	Check for duplicate ClientCode (see more details below)
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

			//Check if duplicate record exists. Check is based on ClienCode value;
			//This check is done on Insert New record only (to make sure app will not throw duplicate record error);
		    //On Edit record  User cannot change ClientCode as it is a primary key;
			if (!editMode)
			{
				if (ClientRepository.IsDuplicateRecord(client.ClientCode))
				{
					errors.Add($"Record with Id: {client.ClientCode} already exists in the Database!");
					success = false;
				}
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
			
			//Preventing from selecting Province's default value;
			if (client.Province.Contains(PROVINCE_INDEX) || String.IsNullOrEmpty(client.Province))
			{
				errors.Add("Please select a province!");
				success = false;
			}

			var postCodePattern = @"^[A-Z]\d[A-Z] \d[A-Z]\d$"; // Generic and does not validate against letters NOT USED in Canadian Postal Codes;
			if (!Regex.IsMatch(client.PostalCode, postCodePattern))
			{
				errors.Add("Invlid Postal Code format! => Please, use format: <A9A 9A9>");
				success = false;
			}


			if (client.YTDSale <= 0.0m)
			{
				errors.Add("Year to Date Sale cannot be negative!");
				success = false;
			}
			return success;
		}
	}
}
