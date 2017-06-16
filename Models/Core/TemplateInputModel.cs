using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class TemplateInputModel : IModel 
	{
		public TemplateInputModelClass template {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var templateItems = template.ToKeyValuePairs("template");
			keyValuePairs.AddRange(templateItems);
			return keyValuePairs;
		}

	}
}