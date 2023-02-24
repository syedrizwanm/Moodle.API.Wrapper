using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Completion : BaseController
	{

		public Completion() : base()
		{
		}

		public Completion(string token, string url) : base(token, url)
		{
		}

		public Task<ActivitiesCompletionStatusModel> GetActivitiesCompletionStatus(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<ActivitiesCompletionStatusModel,ActivitiesCompletionStatusInputModel>("core_completion_get_activities_completion_status", activitiesCompletionStatusInputModel);
		}

		public Task<CourseCompletionStatusModel> GetCourseCompletionStatus(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<CourseCompletionStatusModel,ActivitiesCompletionStatusInputModel>("core_completion_get_course_completion_status", activitiesCompletionStatusInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> MarkCourseSelfCompleted(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,CourseBlocksInputModel>("core_completion_mark_course_self_completed", courseBlocksInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> UpdateActivityCompletionStatusManually(ActivityCompletionStatusManuallyInputModel activityCompletionStatusManuallyInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ActivityCompletionStatusManuallyInputModel>("core_completion_update_activity_completion_status_manually", activityCompletionStatusManuallyInputModel);
		}

		//Function Placeholder

	}
}