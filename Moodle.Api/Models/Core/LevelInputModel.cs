using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class LevelInputModel : IModel 
	{

		public string definition {get;set;}
		public int definitionformat {get;set;}
		public int id {get;set;}
		public double score {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("definition",prefix),definition));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("definitionformat",prefix),definitionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("score",prefix),score.ToString()));
			return keyValuePairs;
		}

	}
}