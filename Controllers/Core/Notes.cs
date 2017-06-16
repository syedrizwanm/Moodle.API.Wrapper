using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Notes : BaseController
	{

		public Notes() : base()
		{
		}

		public Notes(string token, string url) : base(token, url)
		{
		}

		public NotesModel CreateNotes(NotesInputModel notesInputModel)
		{
			return Post<NotesModel,NotesInputModel>("core_notes_create_notes", notesInputModel);
		}

		public BlockContactsModel DeleteNotes(DeleteNotesInputModel deleteNotesInputModel)
		{
			return Post<BlockContactsModel,DeleteNotesInputModel>("core_notes_delete_notes", deleteNotesInputModel);
		}

		public CourseNotesModel GetCourseNotes(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<CourseNotesModel,ActivitiesCompletionStatusInputModel>("core_notes_get_course_notes", activitiesCompletionStatusInputModel);
		}

		public GetNotes GetNotes(DeleteNotesInputModel deleteNotesInputModel)
		{
			return Post<GetNotes,DeleteNotesInputModel>("core_notes_get_notes", deleteNotesInputModel);
		}

		public BlockContactsModel UpdateNotes(NotesInputModel notesInputModel)
		{
			return Post<BlockContactsModel,NotesInputModel>("core_notes_update_notes", notesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewNotes(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ActivitiesCompletionStatusInputModel>("core_notes_view_notes", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}