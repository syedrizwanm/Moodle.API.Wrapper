using System.Threading.Tasks;
using Moodle.Api.Models.Enrol;

namespace Moodle.Api.Controllers.Enrol
{
	public sealed class Guest : BaseController
	{

		public Guest() : base()
		{
		}

		public Guest(string token, string url) : base(token, url)
		{
		}

		public Task<InstanceInfoModel> GetInstanceInfo(InstanceInfoInputModel instanceInfoInputModel)
		{
			return Post<InstanceInfoModel,InstanceInfoInputModel>("enrol_guest_get_instance_info", instanceInfoInputModel);
		}

		//Function Placeholder

	}
}