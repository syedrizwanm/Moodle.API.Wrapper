using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Attachment : IModel 
	{

		public string filename {get;set;}
		public string filepath {get;set;}
		public int filesize {get;set;}
		public string fileurl {get;set;}
		public int isexternalfile {get;set;}
		public string mimetype {get;set;}
		public string repositorytype {get;set;}
		public int timemodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filename",prefix),filename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filepath",prefix),filepath));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filesize",prefix),filesize.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fileurl",prefix),fileurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isexternalfile",prefix),isexternalfile.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mimetype",prefix),mimetype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("repositorytype",prefix),repositorytype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			return keyValuePairs;
		}

	}
}