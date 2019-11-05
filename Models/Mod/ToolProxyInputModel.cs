using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolProxyInputModel : IModel 
	{
		public List<string> capabilityoffered {get;set;}
		public string name {get;set;}
		public string regurl {get;set;}
		public List<string> serviceoffered {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var capabilityofferedIndex = 0; capabilityofferedIndex<capabilityoffered.Count;capabilityofferedIndex++) 
			{
				var capabilityofferedItem = capabilityoffered[capabilityofferedIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("capabilityoffered[" + capabilityofferedIndex + "]",prefix), capabilityofferedItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("regurl",prefix),regurl));

			for(var serviceofferedIndex = 0; serviceofferedIndex<serviceoffered.Count;serviceofferedIndex++) 
			{
				var serviceofferedItem = serviceoffered[serviceofferedIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("serviceoffered[" + serviceofferedIndex + "]",prefix), serviceofferedItem));
			}

			return keyValuePairs;
		}

	}
}