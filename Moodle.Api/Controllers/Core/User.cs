using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class User : BaseController
	{

		public User() : base()
		{
		}

		public User(string token, string url) : base(token, url)
		{
		}

		public Task<UserDeviceModel> AddUserDevice(UserDeviceInputModel userDeviceInputModel)
		{
			return Post<UserDeviceModel,UserDeviceInputModel>("core_user_add_user_device", userDeviceInputModel);
		}

		public Task AddUserPrivateFiles(UserPrivateFilesInputModel userPrivateFilesInputModel)
		{
			return Post<UserPrivateFilesInputModel>("core_user_add_user_private_files", userPrivateFilesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> AgreeSitePolicy( )
		{
			return Post<MarkCourseSelfCompletedModel>("core_user_agree_site_policy");
		}

		public Task<UsersModel> CreateUsers(UsersInputModel usersInputModel)
		{
			return Post<UsersModel,UsersInputModel>("core_user_create_users", usersInputModel);
		}

		public Task DeleteUsers(DeleteUsersInputModel deleteUsersInputModel)
		{
			return Post<DeleteUsersInputModel>("core_user_delete_users", deleteUsersInputModel);
		}

		public Task<CourseUserProfilesModel> GetCourseUserProfiles(CourseUserProfilesInputModel courseUserProfilesInputModel)
		{
			return Post<CourseUserProfilesModel,CourseUserProfilesInputModel>("core_user_get_course_user_profiles", courseUserProfilesInputModel);
		}

		public Task<UserPreferencesModel> GetUserPreferences(UserPreferencesInputModel userPreferencesInputModel)
		{
			return Post<UserPreferencesModel,UserPreferencesInputModel>("core_user_get_user_preferences", userPreferencesInputModel);
		}

		public Task<GetUsers> GetUsers(GetUsersInputModel getUsersInputModel)
		{
			return Post<GetUsers,GetUsersInputModel>("core_user_get_users", getUsersInputModel);
		}

		public Task<UsersByFieldModel> GetUsersByField(UsersByFieldInputModel usersByFieldInputModel)
		{
			return Post<UsersByFieldModel,UsersByFieldInputModel>("core_user_get_users_by_field", usersByFieldInputModel);
		}

		public Task<RemoveUserDeviceModel> RemoveUserDevice(RemoveUserDeviceInputModel removeUserDeviceInputModel)
		{
			return Post<RemoveUserDeviceModel,RemoveUserDeviceInputModel>("core_user_remove_user_device", removeUserDeviceInputModel);
		}

		public Task<SetUserPreferencesModel> SetUserPreferences(SetUserPreferencesInputModel setUserPreferencesInputModel)
		{
			return Post<SetUserPreferencesModel,SetUserPreferencesInputModel>("core_user_set_user_preferences", setUserPreferencesInputModel);
		}

		public Task<PictureModel> UpdatePicture(PictureInputModel pictureInputModel)
		{
			return Post<PictureModel,PictureInputModel>("core_user_update_picture", pictureInputModel);
		}

		public Task UpdateUserPreferences(UpdateUserPreferencesInputModel updateUserPreferencesInputModel)
		{
			return Post<UpdateUserPreferencesInputModel>("core_user_update_user_preferences", updateUserPreferencesInputModel);
		}

		public Task UpdateUsers(UpdateUsersInputModel updateUsersInputModel)
		{
			return Post<UpdateUsersInputModel>("core_user_update_users", updateUsersInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewUserList(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,CourseBlocksInputModel>("core_user_view_user_list", courseBlocksInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewUserProfile(ViewUserProfileInputModel viewUserProfileInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewUserProfileInputModel>("core_user_view_user_profile", viewUserProfileInputModel);
		}

		//Function Placeholder

	}
}