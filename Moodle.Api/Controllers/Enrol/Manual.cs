using System.Threading.Tasks;
using Moodle.Api.Models.Enrol;

namespace Moodle.Api.Controllers.Enrol
{
	public sealed class Manual : BaseController
	{

		public Manual() : base()
		{
		}

		public Manual(string token, string url) : base(token, url)
		{
		}

		public Task EnrolUsers(EnrolUsersInputModel enrolUsersInputModel)
		{
			return Post<EnrolUsersInputModel>("enrol_manual_enrol_users", enrolUsersInputModel);
		}

		public Task UnenrolUsers(UnenrolUsersInputModel unenrolUsersInputModel)
		{
			return Post<UnenrolUsersInputModel>("enrol_manual_unenrol_users", unenrolUsersInputModel);
		}

		//Function Placeholder

	}
}