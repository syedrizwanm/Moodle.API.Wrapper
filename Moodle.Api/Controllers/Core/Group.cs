using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Group : BaseController
	{

		public Group() : base()
		{
		}

		public Group(string token, string url) : base(token, url)
		{
		}

		public Task AddGroupMembers(GroupMembersInputModel groupMembersInputModel)
		{
			return Post<GroupMembersInputModel>("core_group_add_group_members", groupMembersInputModel);
		}

		public Task AssignGrouping(AssignGroupingInputModel assignGroupingInputModel)
		{
			return Post<AssignGroupingInputModel>("core_group_assign_grouping", assignGroupingInputModel);
		}

		public Task<GroupingsModel> CreateGroupings(GroupingsInputModel groupingsInputModel)
		{
			return Post<GroupingsModel,GroupingsInputModel>("core_group_create_groupings", groupingsInputModel);
		}

		public Task<GroupsModel> CreateGroups(GroupsInputModel groupsInputModel)
		{
			return Post<GroupsModel,GroupsInputModel>("core_group_create_groups", groupsInputModel);
		}

		public Task DeleteGroupings(DeleteGroupingsInputModel deleteGroupingsInputModel)
		{
			return Post<DeleteGroupingsInputModel>("core_group_delete_groupings", deleteGroupingsInputModel);
		}

		public Task DeleteGroupMembers(GroupMembersInputModel groupMembersInputModel)
		{
			return Post<GroupMembersInputModel>("core_group_delete_group_members", groupMembersInputModel);
		}

		public Task DeleteGroups(DeleteGroupsInputModel deleteGroupsInputModel)
		{
			return Post<DeleteGroupsInputModel>("core_group_delete_groups", deleteGroupsInputModel);
		}

		public Task<ActivityAllowedGroupsModel> GetActivityAllowedGroups(ActivityAllowedGroupsInputModel activityAllowedGroupsInputModel)
		{
			return Post<ActivityAllowedGroupsModel,ActivityAllowedGroupsInputModel>("core_group_get_activity_allowed_groups", activityAllowedGroupsInputModel);
		}

		public Task<ActivityGroupmodeModel> GetActivityGroupmode(CourseModuleInputModel courseModuleInputModel)
		{
			return Post<ActivityGroupmodeModel,CourseModuleInputModel>("core_group_get_activity_groupmode", courseModuleInputModel);
		}

		public Task<GroupingsModel> GetCourseGroupings(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<GroupingsModel,CourseBlocksInputModel>("core_group_get_course_groupings", courseBlocksInputModel);
		}

		public Task<GroupsModel> GetCourseGroups(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<GroupsModel,CourseBlocksInputModel>("core_group_get_course_groups", courseBlocksInputModel);
		}

		public Task<ActivityAllowedGroupsModel> GetCourseUserGroups(CourseUserGroupsInputModel courseUserGroupsInputModel)
		{
			return Post<ActivityAllowedGroupsModel,CourseUserGroupsInputModel>("core_group_get_course_user_groups", courseUserGroupsInputModel);
		}

		public Task<GetGroupings> GetGroupings(GetGroupingsInputModel getGroupingsInputModel)
		{
			return Post<GetGroupings,GetGroupingsInputModel>("core_group_get_groupings", getGroupingsInputModel);
		}

		public Task<GroupMembersModel> GetGroupMembers(DeleteGroupsInputModel deleteGroupsInputModel)
		{
			return Post<GroupMembersModel,DeleteGroupsInputModel>("core_group_get_group_members", deleteGroupsInputModel);
		}

		public Task<GroupsModel> GetGroups(DeleteGroupsInputModel deleteGroupsInputModel)
		{
			return Post<GroupsModel,DeleteGroupsInputModel>("core_group_get_groups", deleteGroupsInputModel);
		}

		public Task UnassignGrouping(UnassignGroupingInputModel unassignGroupingInputModel)
		{
			return Post<UnassignGroupingInputModel>("core_group_unassign_grouping", unassignGroupingInputModel);
		}

		public Task UpdateGroupings(UpdateGroupingsInputModel updateGroupingsInputModel)
		{
			return Post<UpdateGroupingsInputModel>("core_group_update_groupings", updateGroupingsInputModel);
		}

		//Function Placeholder

	}
}