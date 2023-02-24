using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ItemdetailInputModel : IModel 
	{

		public int deleted {get;set;}
		public double grademax {get;set;}
		public double grademin {get;set;}
		public int gradetype {get;set;}
		public int hidden {get;set;}
		public int idnumber {get;set;}
		public string itemname {get;set;}
		public double multfactor {get;set;}
		public double plusfactor {get;set;}
		public int scaleid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("deleted",prefix),deleted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grademax",prefix),grademax.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grademin",prefix),grademin.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradetype",prefix),gradetype.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hidden",prefix),hidden.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemname",prefix),itemname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("multfactor",prefix),multfactor.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("plusfactor",prefix),plusfactor.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			return keyValuePairs;
		}

	}
}