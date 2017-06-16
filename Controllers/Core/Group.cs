using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Group : BaseController
	{

		public Group() : base()
		{
		}

		public Group(string token, string url) : base(token, url)
		{
		}

		public void AddGroupMembers(GroupMembersInputModel groupMembersInputModel)
		{
			Post<GroupMembersInputModel>("core_group_add_group_members", groupMembersInputModel);
		}

		public void AssignGrouping(AssignGroupingInputModel assignGroupingInputModel)
		{
			Post<AssignGroupingInputModel>("core_group_assign_grouping", assignGroupingInputModel);
		}

		public GroupingsModel CreateGroupings(GroupingsInputModel groupingsInputModel)
		{
			return Post<GroupingsModel,GroupingsInputModel>("core_group_create_groupings", groupingsInputModel);
		}

		public GroupsModel CreateGroups(GroupsInputModel groupsInputModel)
		{
			return Post<GroupsModel,GroupsInputModel>("core_group_create_groups", groupsInputModel);
		}

		public void DeleteGroupings(DeleteGroupingsInputModel deleteGroupingsInputModel)
		{
			Post<DeleteGroupingsInputModel>("core_group_delete_groupings", deleteGroupingsInputModel);
		}

		public void DeleteGroupMembers(GroupMembersInputModel groupMembersInputModel)
		{
			Post<GroupMembersInputModel>("core_group_delete_group_members", groupMembersInputModel);
		}

		public void DeleteGroups(DeleteGroupsInputModel deleteGroupsInputModel)
		{
			Post<DeleteGroupsInputModel>("core_group_delete_groups", deleteGroupsInputModel);
		}

		public ActivityAllowedGroupsModel GetActivityAllowedGroups(ActivityAllowedGroupsInputModel activityAllowedGroupsInputModel)
		{
			return Post<ActivityAllowedGroupsModel,ActivityAllowedGroupsInputModel>("core_group_get_activity_allowed_groups", activityAllowedGroupsInputModel);
		}

		public ActivityGroupmodeModel GetActivityGroupmode(CourseModuleInputModel courseModuleInputModel)
		{
			return Post<ActivityGroupmodeModel,CourseModuleInputModel>("core_group_get_activity_groupmode", courseModuleInputModel);
		}

		public GroupingsModel GetCourseGroupings(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<GroupingsModel,CourseBlocksInputModel>("core_group_get_course_groupings", courseBlocksInputModel);
		}

		public GroupsModel GetCourseGroups(CourseBlocksInputModel courseBlocksInputModel)
		{
			return Post<GroupsModel,CourseBlocksInputModel>("core_group_get_course_groups", courseBlocksInputModel);
		}

		public ActivityAllowedGroupsModel GetCourseUserGroups(CourseUserGroupsInputModel courseUserGroupsInputModel)
		{
			return Post<ActivityAllowedGroupsModel,CourseUserGroupsInputModel>("core_group_get_course_user_groups", courseUserGroupsInputModel);
		}

		public GetGroupings GetGroupings(GetGroupingsInputModel getGroupingsInputModel)
		{
			return Post<GetGroupings,GetGroupingsInputModel>("core_group_get_groupings", getGroupingsInputModel);
		}

		public GroupMembersModel GetGroupMembers(DeleteGroupsInputModel deleteGroupsInputModel)
		{
			return Post<GroupMembersModel,DeleteGroupsInputModel>("core_group_get_group_members", deleteGroupsInputModel);
		}

		public GroupsModel GetGroups(DeleteGroupsInputModel deleteGroupsInputModel)
		{
			return Post<GroupsModel,DeleteGroupsInputModel>("core_group_get_groups", deleteGroupsInputModel);
		}

		public void UnassignGrouping(UnassignGroupingInputModel unassignGroupingInputModel)
		{
			Post<UnassignGroupingInputModel>("core_group_unassign_grouping", unassignGroupingInputModel);
		}

		public void UpdateGroupings(UpdateGroupingsInputModel updateGroupingsInputModel)
		{
			Post<UpdateGroupingsInputModel>("core_group_update_groupings", updateGroupingsInputModel);
		}

		//Function Placeholder

	}
}