using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class MessageProcessorConfigFormInputModel : IModel 
	{
		public List<FormvalueInputModel> formvalues {get;set;}
		public string name {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var formvaluesIndex = 0; formvaluesIndex<formvalues.Count;formvaluesIndex++) 
			{
				var formvaluesItem = formvalues[formvaluesIndex];
				var formvaluesItems = formvaluesItem.ToKeyValuePairs("formvalues[" + formvaluesIndex + "]");
				keyValuePairs.AddRange(formvaluesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}