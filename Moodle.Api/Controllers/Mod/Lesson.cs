using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Lesson : BaseController
	{

		public Lesson() : base()
		{
		}

		public Lesson(string token, string url) : base(token, url)
		{
		}

		public Task<FinishAttemptModel> FinishAttempt(FinishAttemptInputModel finishAttemptInputModel)
		{
			return Post<FinishAttemptModel,FinishAttemptInputModel>("mod_lesson_finish_attempt", finishAttemptInputModel);
		}

		public Task<AttemptsOverviewModel> GetAttemptsOverview(AttemptsOverviewInputModel attemptsOverviewInputModel)
		{
			return Post<AttemptsOverviewModel,AttemptsOverviewInputModel>("mod_lesson_get_attempts_overview", attemptsOverviewInputModel);
		}

		public Task<ContentPagesViewedModel> GetContentPagesViewed(ContentPagesViewedInputModel contentPagesViewedInputModel)
		{
			return Post<ContentPagesViewedModel,ContentPagesViewedInputModel>("mod_lesson_get_content_pages_viewed", contentPagesViewedInputModel);
		}

		public Task<LessonModel> GetLesson(LessonInputModel lessonInputModel)
		{
			return Post<LessonModel,LessonInputModel>("mod_lesson_get_lesson", lessonInputModel);
		}

		public Task<LessonAccessInformationModel> GetLessonAccessInformation(LessonAccessInformationInputModel lessonAccessInformationInputModel)
		{
			return Post<LessonAccessInformationModel,LessonAccessInformationInputModel>("mod_lesson_get_lesson_access_information", lessonAccessInformationInputModel);
		}

		public Task<LessonsByCoursesModel> GetLessonsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<LessonsByCoursesModel,DeleteCoursesInputModel>("mod_lesson_get_lessons_by_courses", deleteCoursesInputModel);
		}

		public Task<PageDataModel> GetPageData(PageDataInputModel pageDataInputModel)
		{
			return Post<PageDataModel,PageDataInputModel>("mod_lesson_get_page_data", pageDataInputModel);
		}

		public Task<PagesModel> GetPages(LessonInputModel lessonInputModel)
		{
			return Post<PagesModel,LessonInputModel>("mod_lesson_get_pages", lessonInputModel);
		}

		public Task<PagesPossibleJumpsModel> GetPagesPossibleJumps(LessonAccessInformationInputModel lessonAccessInformationInputModel)
		{
			return Post<PagesPossibleJumpsModel,LessonAccessInformationInputModel>("mod_lesson_get_pages_possible_jumps", lessonAccessInformationInputModel);
		}

		public Task<QuestionsAttemptsModel> GetQuestionsAttempts(QuestionsAttemptsInputModel questionsAttemptsInputModel)
		{
			return Post<QuestionsAttemptsModel,QuestionsAttemptsInputModel>("mod_lesson_get_questions_attempts", questionsAttemptsInputModel);
		}

		public Task<UserAttemptModel> GetUserAttempt(UserAttemptInputModel userAttemptInputModel)
		{
			return Post<UserAttemptModel,UserAttemptInputModel>("mod_lesson_get_user_attempt", userAttemptInputModel);
		}

		public Task<UserAttemptGradeModel> GetUserAttemptGrade(ContentPagesViewedInputModel contentPagesViewedInputModel)
		{
			return Post<UserAttemptGradeModel,ContentPagesViewedInputModel>("mod_lesson_get_user_attempt_grade", contentPagesViewedInputModel);
		}

		public Task<UserGradeModel> GetUserGrade(UserGradeInputModel userGradeInputModel)
		{
			return Post<UserGradeModel,UserGradeInputModel>("mod_lesson_get_user_grade", userGradeInputModel);
		}

		public Task<UserTimersModel> GetUserTimers(UserGradeInputModel userGradeInputModel)
		{
			return Post<UserTimersModel,UserGradeInputModel>("mod_lesson_get_user_timers", userGradeInputModel);
		}

		public Task<LaunchAttemptModel> LaunchAttempt(LaunchAttemptInputModel launchAttemptInputModel)
		{
			return Post<LaunchAttemptModel,LaunchAttemptInputModel>("mod_lesson_launch_attempt", launchAttemptInputModel);
		}

		public Task<ProcessPage> ProcessPage(ProcessPageInputModel processPageInputModel)
		{
			return Post<ProcessPage,ProcessPageInputModel>("mod_lesson_process_page", processPageInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewLesson(LessonInputModel lessonInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,LessonInputModel>("mod_lesson_view_lesson", lessonInputModel);
		}

		//Function Placeholder

	}
}