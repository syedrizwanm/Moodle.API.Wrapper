using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Notes : BaseController
	{

		public Notes() : base()
		{
		}

		public Notes(string token, string url) : base(token, url)
		{
		}

		public Task<NotesModel> CreateNotes(NotesInputModel notesInputModel)
		{
			return Post<NotesModel,NotesInputModel>("core_notes_create_notes", notesInputModel);
		}

		public Task<BlockContactsModel> DeleteNotes(DeleteNotesInputModel deleteNotesInputModel)
		{
			return Post<BlockContactsModel,DeleteNotesInputModel>("core_notes_delete_notes", deleteNotesInputModel);
		}

		public Task<CourseNotesModel> GetCourseNotes(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<CourseNotesModel,ActivitiesCompletionStatusInputModel>("core_notes_get_course_notes", activitiesCompletionStatusInputModel);
		}

		public Task<GetNotes> GetNotes(DeleteNotesInputModel deleteNotesInputModel)
		{
			return Post<GetNotes,DeleteNotesInputModel>("core_notes_get_notes", deleteNotesInputModel);
		}

		public Task<BlockContactsModel> UpdateNotes(NotesInputModel notesInputModel)
		{
			return Post<BlockContactsModel,NotesInputModel>("core_notes_update_notes", notesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewNotes(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ActivitiesCompletionStatusInputModel>("core_notes_view_notes", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}