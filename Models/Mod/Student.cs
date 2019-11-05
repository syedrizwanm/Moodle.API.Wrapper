using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Student : IModel 
	{

		public List<Attempt> attempts {get;set;}
		public double bestgrade {get;set;}
		public string fullname {get;set;}
		public int id {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var attemptsIndex = 0; attemptsIndex<attempts.Count;attemptsIndex++) 
			{
				var attemptsItem = attempts[attemptsIndex];
				var attemptsItems = attemptsItem.ToKeyValuePairs("attempts[" + attemptsIndex + "]");
				keyValuePairs.AddRange(attemptsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("bestgrade",prefix),bestgrade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			return keyValuePairs;
		}

	}
}