using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class FragmentInputModel : IModel 
	{
		public List<ArgInputModel> args {get;set;}
		public string callback {get;set;}
		public string component {get;set;}
		public int contextid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var argsIndex = 0; argsIndex<args.Count;argsIndex++) 
			{
				var argsItem = args[argsIndex];
				var argsItems = argsItem.ToKeyValuePairs("args[" + argsIndex + "]");
				keyValuePairs.AddRange(argsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("callback",prefix),callback));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			return keyValuePairs;
		}

	}
}