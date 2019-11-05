using System.Collections.Generic;

namespace Moodle.Api.Models.Message
{
	public sealed class UserDevicesModel : IModel 
	{
		public List<Device> devices {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var devicesIndex = 0; devicesIndex<devices.Count;devicesIndex++) 
			{
				var devicesItem = devices[devicesIndex];
				var devicesItems = devicesItem.ToKeyValuePairs("devices[" + devicesIndex + "]");
				keyValuePairs.AddRange(devicesItems);
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