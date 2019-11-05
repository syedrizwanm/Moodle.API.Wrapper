using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Assign : BaseController
	{

		public Assign() : base()
		{
		}

		public Assign(string token, string url) : base(token, url)
		{
		}

		public Task<BlockContactsModel> CopyPreviousAttempt(CopyPreviousAttemptInputModel copyPreviousAttemptInputModel)
		{
			return Post<BlockContactsModel,CopyPreviousAttemptInputModel>("mod_assign_copy_previous_attempt", copyPreviousAttemptInputModel);
		}

		public Task<AssignmentsModel> GetAssignments(AssignmentsInputModel assignmentsInputModel)
		{
			return Post<AssignmentsModel,AssignmentsInputModel>("mod_assign_get_assignments", assignmentsInputModel);
		}

		public Task<GradesModel> GetGrades(GradesInputModel gradesInputModel)
		{
			return Post<GradesModel,GradesInputModel>("mod_assign_get_grades", gradesInputModel);
		}

		public Task<ParticipantModel> GetParticipant(ParticipantInputModel participantInputModel)
		{
			return Post<ParticipantModel,ParticipantInputModel>("mod_assign_get_participant", participantInputModel);
		}

		public Task<SubmissionsModel> GetSubmissions(SubmissionsInputModel submissionsInputModel)
		{
			return Post<SubmissionsModel,SubmissionsInputModel>("mod_assign_get_submissions", submissionsInputModel);
		}

		public Task<SubmissionStatusModel> GetSubmissionStatus(SubmissionStatusInputModel submissionStatusInputModel)
		{
			return Post<SubmissionStatusModel,SubmissionStatusInputModel>("mod_assign_get_submission_status", submissionStatusInputModel);
		}

		public Task<UserFlagsModel> GetUserFlags(UserFlagsInputModel userFlagsInputModel)
		{
			return Post<UserFlagsModel,UserFlagsInputModel>("mod_assign_get_user_flags", userFlagsInputModel);
		}

		public Task<UserMappingsModel> GetUserMappings(UserFlagsInputModel userFlagsInputModel)
		{
			return Post<UserMappingsModel,UserFlagsInputModel>("mod_assign_get_user_mappings", userFlagsInputModel);
		}

		public Task<ParticipantsModel> ListParticipants(ParticipantsInputModel participantsInputModel)
		{
			return Post<ParticipantsModel,ParticipantsInputModel>("mod_assign_list_participants", participantsInputModel);
		}

		public Task<BlockContactsModel> LockSubmissions(LockSubmissionsInputModel lockSubmissionsInputModel)
		{
			return Post<BlockContactsModel,LockSubmissionsInputModel>("mod_assign_lock_submissions", lockSubmissionsInputModel);
		}

		public Task<BlockContactsModel> RevealIdentities(CopyPreviousAttemptInputModel copyPreviousAttemptInputModel)
		{
			return Post<BlockContactsModel,CopyPreviousAttemptInputModel>("mod_assign_reveal_identities", copyPreviousAttemptInputModel);
		}

		public Task<BlockContactsModel> RevertSubmissionsToDraft(LockSubmissionsInputModel lockSubmissionsInputModel)
		{
			return Post<BlockContactsModel,LockSubmissionsInputModel>("mod_assign_revert_submissions_to_draft", lockSubmissionsInputModel);
		}

		public Task SaveGrade(SaveGradeInputModel saveGradeInputModel)
		{
			return Post<SaveGradeInputModel>("mod_assign_save_grade", saveGradeInputModel);
		}

		public Task SaveGrades(SaveGradesInputModel saveGradesInputModel)
		{
			return Post<SaveGradesInputModel>("mod_assign_save_grades", saveGradesInputModel);
		}

		public Task<BlockContactsModel> SaveSubmission(SaveSubmissionInputModel saveSubmissionInputModel)
		{
			return Post<BlockContactsModel,SaveSubmissionInputModel>("mod_assign_save_submission", saveSubmissionInputModel);
		}

		public Task<BlockContactsModel> SaveUserExtensions(SaveUserExtensionsInputModel saveUserExtensionsInputModel)
		{
			return Post<BlockContactsModel,SaveUserExtensionsInputModel>("mod_assign_save_user_extensions", saveUserExtensionsInputModel);
		}

		public Task<SetUserFlagsModel> SetUserFlags(SetUserFlagsInputModel setUserFlagsInputModel)
		{
			return Post<SetUserFlagsModel,SetUserFlagsInputModel>("mod_assign_set_user_flags", setUserFlagsInputModel);
		}

		public Task<BlockContactsModel> SubmitForGrading(SubmitForGradingInputModel submitForGradingInputModel)
		{
			return Post<BlockContactsModel,SubmitForGradingInputModel>("mod_assign_submit_for_grading", submitForGradingInputModel);
		}

		public Task<BlockContactsModel> SubmitGradingForm(SubmitGradingFormInputModel submitGradingFormInputModel)
		{
			return Post<BlockContactsModel,SubmitGradingFormInputModel>("mod_assign_submit_grading_form", submitGradingFormInputModel);
		}

		public Task<BlockContactsModel> UnlockSubmissions(LockSubmissionsInputModel lockSubmissionsInputModel)
		{
			return Post<BlockContactsModel,LockSubmissionsInputModel>("mod_assign_unlock_submissions", lockSubmissionsInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewAssign(ViewAssignInputModel viewAssignInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewAssignInputModel>("mod_assign_view_assign", viewAssignInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewGradingTable(ViewAssignInputModel viewAssignInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewAssignInputModel>("mod_assign_view_grading_table", viewAssignInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewSubmissionStatus(ViewAssignInputModel viewAssignInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewAssignInputModel>("mod_assign_view_submission_status", viewAssignInputModel);
		}

		//Function Placeholder

	}
}