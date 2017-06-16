using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class User : BaseController
	{

		public User() : base()
		{
		}

		public User(string token, string url) : base(token, url)
		{
		}

		public UserDeviceModel AddUserDevice(UserDeviceInputModel userDeviceInputModel)
		{
			return Post<UserDeviceModel,UserDeviceInputModel>("core_user_add_user_device", userDeviceInputModel);
		}

		public void AddUserPrivateFiles(UserPrivateFilesInputModel userPrivateFilesInputModel)
		{
			Post<UserPrivateFilesInputModel>("core_user_add_user_private_files", userPrivateFilesInputModel);
		}

		public MarkCourseSelfCompletedModel AgreeSitePolicy( )
		{
			return Post<MarkCourseSelfCompletedModel>("core_user_agree_site_policy");
		}

		public UsersModel CreateUsers(UsersInputModel usersInputModel)
		{
			return Post<UsersModel,UsersInputModel>("core_user_create_users", usersInputModel);
		}

		public void DeleteUsers(DeleteUsersInputModel deleteUsersInputModel)
		{
			Post<DeleteUsersInputModel>("core_user_delete_users", deleteUsersInputModel);
		}

		public CourseUserProfilesModel GetCourseUserProfiles(CourseUserProfilesInputModel courseUserProfilesInputModel)
		{
			return Post<CourseUserProfilesModel,CourseUserProfilesInputModel>("core_user_get_course_user_profiles", courseUserProfilesInputModel);
		}

		public UserPreferencesModel GetUserPreferences(UserPreferencesInputModel userPreferencesInputModel)
		{
			return Post<UserPreferencesModel,UserPreferencesInputModel>("core_user_get_user_preferences", userPreferencesInputModel);
		}

		public GetUsers GetUsers(GetUsersInputModel getUsersInputModel)
		{
			return Post<GetUsers,GetUsersInputModel>("core_user_get_users", getUsersInputModel);
		}

		public UsersByFieldModel GetUsersByField(UsersByFieldInputModel usersByFieldInputModel)
		{
			return Post<UsersByFieldModel,UsersByFieldInputModel>("core_user_get_users_by_field", usersByFieldInputModel);
		}

		public RemoveUserDeviceModel RemoveUserDevice(RemoveUserDeviceInputModel removeUserDeviceInputModel)
		{
			return Post<RemoveUserDeviceModel,RemoveUserDeviceInputModel>("core_user_remove_user_device", removeUserDeviceInputModel);
		}

		public SetUserPreferencesModel SetUserPreferences(SetUserPreferencesInputModel setUserPreferencesInputModel)
		{
			return Post<SetUserPreferencesModel,SetUserPreferencesInputModel>("core_user_set_user_preferences", setUserPreferencesInputModel);
		}

		public PictureModel UpdatePicture(PictureInputModel pictureInputModel)
		{
			return Post<PictureModel,PictureInputModel>("core_user_update_picture", pictureInputModel);
		}

		public void UpdateUserPreferences(UpdateUserPreferencesInputModel updateUserPreferencesInputModel)
		{
			Post<UpdateUserPreferencesInputModel>("core_user_update_user_preferences", updateUserPreferencesInputModel);
		}

		public void UpdateUsers(UpdateUsersInputModel updateUsersInputModel)
		{
			Post<UpdateUsersInputModel>("core_user_update_users", updateUsersInputModel);
		}

		public MarkCourseSelfCompletedModel ViewUserList(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,CourseBlocksInputModel>("core_user_view_user_list", courseBlocksInputModel);
		}

		public MarkCourseSelfCompletedModel ViewUserProfile(ViewUserProfileInputModel viewUserProfileInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewUserProfileInputModel>("core_user_view_user_profile", viewUserProfileInputModel);
		}

		//Function Placeholder

	}
}