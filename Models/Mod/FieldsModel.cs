using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class FieldsModel : IModel 
	{
		public List<Field> fields {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var fieldsIndex = 0; fieldsIndex<fields.Count;fieldsIndex++) 
			{
				var fieldsItem = fields[fieldsIndex];
				var fieldsItems = fieldsItem.ToKeyValuePairs("fields[" + fieldsIndex + "]");
				keyValuePairs.AddRange(fieldsItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}