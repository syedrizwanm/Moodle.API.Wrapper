using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseBlocksModel : IModel 
	{
		public List<Block> blocks {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var blocksIndex = 0; blocksIndex<blocks.Count;blocksIndex++) 
			{
				var blocksItem = blocks[blocksIndex];
				var blocksItems = blocksItem.ToKeyValuePairs("blocks[" + blocksIndex + "]");
				keyValuePairs.AddRange(blocksItems);
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