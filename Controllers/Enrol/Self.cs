using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Enrol;

namespace Moodle.API.Wrapper.Controllers.Enrol
{
	public sealed class Self : BaseController
	{

		public Self() : base()
		{
		}

		public Self(string token, string url) : base(token, url)
		{
		}

		public MarkCourseSelfCompletedModel EnrolUser(EnrolUserInputModel enrolUserInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,EnrolUserInputModel>("enrol_self_enrol_user", enrolUserInputModel);
		}

		public GetInstanceInfo GetInstanceInfo(InstanceInfoInputModel instanceInfoInputModel)
		{
			return Post<GetInstanceInfo,InstanceInfoInputModel>("enrol_self_get_instance_info", instanceInfoInputModel);
		}

		//Function Placeholder

	}
}