using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Data : IModel 
	{

		public List<Defaultdata> defaultdata {get;set;}
		public int scoid {get;set;}
		public List<Userdata> userdata {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var defaultdataIndex = 0; defaultdataIndex<defaultdata.Count;defaultdataIndex++) 
			{
				var defaultdataItem = defaultdata[defaultdataIndex];
				var defaultdataItems = defaultdataItem.ToKeyValuePairs("defaultdata[" + defaultdataIndex + "]");
				keyValuePairs.AddRange(defaultdataItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scoid",prefix),scoid.ToString()));

			for(var userdataIndex = 0; userdataIndex<userdata.Count;userdataIndex++) 
			{
				var userdataItem = userdata[userdataIndex];
				var userdataItems = userdataItem.ToKeyValuePairs("userdata[" + userdataIndex + "]");
				keyValuePairs.AddRange(userdataItems);
			}

			return keyValuePairs;
		}

	}
}