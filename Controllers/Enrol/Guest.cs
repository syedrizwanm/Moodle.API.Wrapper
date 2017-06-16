using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Enrol;

namespace Moodle.API.Wrapper.Controllers.Enrol
{
	public sealed class Guest : BaseController
	{

		public Guest() : base()
		{
		}

		public Guest(string token, string url) : base(token, url)
		{
		}

		public InstanceInfoModel GetInstanceInfo(InstanceInfoInputModel instanceInfoInputModel)
		{
			return Post<InstanceInfoModel,InstanceInfoInputModel>("enrol_guest_get_instance_info", instanceInfoInputModel);
		}

		//Function Placeholder

	}
}