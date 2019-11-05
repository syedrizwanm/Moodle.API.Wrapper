using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class CategoriesModel : IModel 
	{
		public List<Categorie> categories {get;set;}
		public int count {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var categoriesIndex = 0; categoriesIndex<categories.Count;categoriesIndex++) 
			{
				var categoriesItem = categories[categoriesIndex];
				var categoriesItems = categoriesItem.ToKeyValuePairs("categories[" + categoriesIndex + "]");
				keyValuePairs.AddRange(categoriesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("count",prefix),count.ToString()));

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