using System.Threading.Tasks;
using Moodle.Api.Models.Enrol;

namespace Moodle.Api.Controllers.Enrol
{
	public sealed class Self : BaseController
	{

		public Self() : base()
		{
		}

		public Self(string token, string url) : base(token, url)
		{
		}

		public Task<MarkCourseSelfCompletedModel> EnrolUser(EnrolUserInputModel enrolUserInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,EnrolUserInputModel>("enrol_self_enrol_user", enrolUserInputModel);
		}

		public Task<GetInstanceInfo> GetInstanceInfo(InstanceInfoInputModel instanceInfoInputModel)
		{
			return Post<GetInstanceInfo,InstanceInfoInputModel>("enrol_self_get_instance_info", instanceInfoInputModel);
		}

		//Function Placeholder

	}
}