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

		public FinishAttemptModel FinishAttempt(FinishAttemptInputModel finishAttemptInputModel)
		{
			return Post<FinishAttemptModel,FinishAttemptInputModel>("mod_lesson_finish_attempt", finishAttemptInputModel);
		}

		public AttemptsOverviewModel GetAttemptsOverview(AttemptsOverviewInputModel attemptsOverviewInputModel)
		{
			return Post<AttemptsOverviewModel,AttemptsOverviewInputModel>("mod_lesson_get_attempts_overview", attemptsOverviewInputModel);
		}

		public ContentPagesViewedModel GetContentPagesViewed(ContentPagesViewedInputModel contentPagesViewedInputModel)
		{
			return Post<ContentPagesViewedModel,ContentPagesViewedInputModel>("mod_lesson_get_content_pages_viewed", contentPagesViewedInputModel);
		}

		public LessonModel GetLesson(LessonInputModel lessonInputModel)
		{
			return Post<LessonModel,LessonInputModel>("mod_lesson_get_lesson", lessonInputModel);
		}

		public LessonAccessInformationModel GetLessonAccessInformation(LessonAccessInformationInputModel lessonAccessInformationInputModel)
		{
			return Post<LessonAccessInformationModel,LessonAccessInformationInputModel>("mod_lesson_get_lesson_access_information", lessonAccessInformationInputModel);
		}

		public LessonsByCoursesModel GetLessonsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<LessonsByCoursesModel,DeleteCoursesInputModel>("mod_lesson_get_lessons_by_courses", deleteCoursesInputModel);
		}

		public PageDataModel GetPageData(PageDataInputModel pageDataInputModel)
		{
			return Post<PageDataModel,PageDataInputModel>("mod_lesson_get_page_data", pageDataInputModel);
		}

		public PagesModel GetPages(LessonInputModel lessonInputModel)
		{
			return Post<PagesModel,LessonInputModel>("mod_lesson_get_pages", lessonInputModel);
		}

		public PagesPossibleJumpsModel GetPagesPossibleJumps(LessonAccessInformationInputModel lessonAccessInformationInputModel)
		{
			return Post<PagesPossibleJumpsModel,LessonAccessInformationInputModel>("mod_lesson_get_pages_possible_jumps", lessonAccessInformationInputModel);
		}

		public QuestionsAttemptsModel GetQuestionsAttempts(QuestionsAttemptsInputModel questionsAttemptsInputModel)
		{
			return Post<QuestionsAttemptsModel,QuestionsAttemptsInputModel>("mod_lesson_get_questions_attempts", questionsAttemptsInputModel);
		}

		public UserAttemptModel GetUserAttempt(UserAttemptInputModel userAttemptInputModel)
		{
			return Post<UserAttemptModel,UserAttemptInputModel>("mod_lesson_get_user_attempt", userAttemptInputModel);
		}

		public UserAttemptGradeModel GetUserAttemptGrade(ContentPagesViewedInputModel contentPagesViewedInputModel)
		{
			return Post<UserAttemptGradeModel,ContentPagesViewedInputModel>("mod_lesson_get_user_attempt_grade", contentPagesViewedInputModel);
		}

		public UserGradeModel GetUserGrade(UserGradeInputModel userGradeInputModel)
		{
			return Post<UserGradeModel,UserGradeInputModel>("mod_lesson_get_user_grade", userGradeInputModel);
		}

		public UserTimersModel GetUserTimers(UserGradeInputModel userGradeInputModel)
		{
			return Post<UserTimersModel,UserGradeInputModel>("mod_lesson_get_user_timers", userGradeInputModel);
		}

		public LaunchAttemptModel LaunchAttempt(LaunchAttemptInputModel launchAttemptInputModel)
		{
			return Post<LaunchAttemptModel,LaunchAttemptInputModel>("mod_lesson_launch_attempt", launchAttemptInputModel);
		}

		public ProcessPage ProcessPage(ProcessPageInputModel processPageInputModel)
		{
			return Post<ProcessPage,ProcessPageInputModel>("mod_lesson_process_page", processPageInputModel);
		}

		public MarkCourseSelfCompletedModel ViewLesson(LessonInputModel lessonInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,LessonInputModel>("mod_lesson_view_lesson", lessonInputModel);
		}

		//Function Placeholder

	}
}