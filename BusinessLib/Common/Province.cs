namespace BusinessLib.Common
{
	/// <summary>
	/// Data class represenging Province objects;
	/// @see Repo location: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign06.git
	/// @Date: July 2017;
	/// @Author: Krzysztof Szczurowski;
	/// </summary>
	public class Province
	{
		public int Id { get; set; }
		public string Abbreviation { get; set; }
		public string Name { get; set; }
		public string ProvinceDisplay { get; set; }
	}
}
