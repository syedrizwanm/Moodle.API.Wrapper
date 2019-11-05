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

		public void EnrolUsers(EnrolUsersInputModel enrolUsersInputModel)
		{
			Post<EnrolUsersInputModel>("enrol_manual_enrol_users", enrolUsersInputModel);
		}

		public void UnenrolUsers(UnenrolUsersInputModel unenrolUsersInputModel)
		{
			Post<UnenrolUsersInputModel>("enrol_manual_unenrol_users", unenrolUsersInputModel);
		}

		//Function Placeholder

	}
}