using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Feedbackplugin : IModel 
	{

		public List<Editorfield> editorfields {get;set;}
		public List<Filearea> fileareas {get;set;}
		public string name {get;set;}
		public string type {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var editorfieldsIndex = 0; editorfieldsIndex<editorfields.Count;editorfieldsIndex++) 
			{
				var editorfieldsItem = editorfields[editorfieldsIndex];
				var editorfieldsItems = editorfieldsItem.ToKeyValuePairs("editorfields[" + editorfieldsIndex + "]");
				keyValuePairs.AddRange(editorfieldsItems);
			}


			for(var fileareasIndex = 0; fileareasIndex<fileareas.Count;fileareasIndex++) 
			{
				var fileareasItem = fileareas[fileareasIndex];
				var fileareasItems = fileareasItem.ToKeyValuePairs("fileareas[" + fileareasIndex + "]");
				keyValuePairs.AddRange(fileareasItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			return keyValuePairs;
		}

	}
}