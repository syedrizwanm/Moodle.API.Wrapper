using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Scoe : IModel 
	{

		public List<Extradata> extradata {get;set;}
		public int id {get;set;}
		public string identifier {get;set;}
		public string launch {get;set;}
		public string manifest {get;set;}
		public string organization {get;set;}
		public string parent {get;set;}
		public int scorm {get;set;}
		public string scormtype {get;set;}
		public int sortorder {get;set;}
		public string title {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var extradataIndex = 0; extradataIndex<extradata.Count;extradataIndex++) 
			{
				var extradataItem = extradata[extradataIndex];
				var extradataItems = extradataItem.ToKeyValuePairs("extradata[" + extradataIndex + "]");
				keyValuePairs.AddRange(extradataItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("identifier",prefix),identifier));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("launch",prefix),launch));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("manifest",prefix),manifest));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("organization",prefix),organization));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("parent",prefix),parent));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scorm",prefix),scorm.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scormtype",prefix),scormtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortorder",prefix),sortorder.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("title",prefix),title));
			return keyValuePairs;
		}

	}
}