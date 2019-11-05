using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Enrol : BaseController
	{

		public Enrol() : base()
		{
		}

		public Enrol(string token, string url) : base(token, url)
		{
		}

		public Task<CourseEnrolmentMethodsModel> GetCourseEnrolmentMethods(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<CourseEnrolmentMethodsModel,CourseBlocksInputModel>("core_enrol_get_course_enrolment_methods", courseBlocksInputModel);
		}

		public Task<EnrolledUsersModel> GetEnrolledUsers(ContentsInputModel contentsInputModel)
		{
			return Post<EnrolledUsersModel,ContentsInputModel>("core_enrol_get_enrolled_users", contentsInputModel);
		}

		public Task<EnrolledUsersWithCapabilityModel> GetEnrolledUsersWithCapability(EnrolledUsersWithCapabilityInputModel enrolledUsersWithCapabilityInputModel)
		{
			return Post<EnrolledUsersWithCapabilityModel,EnrolledUsersWithCapabilityInputModel>("core_enrol_get_enrolled_users_with_capability", enrolledUsersWithCapabilityInputModel);
		}

		public Task<UsersCoursesModel> GetUsersCourses(UserPlansInputModel userPlansInputModel)
		{
			return Post<UsersCoursesModel,UserPlansInputModel>("core_enrol_get_users_courses", userPlansInputModel);
		}

		//Function Placeholder

	}
}