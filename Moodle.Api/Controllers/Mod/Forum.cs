using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Forum : BaseController
	{

		public Forum() : base()
		{
		}

		public Forum(string token, string url) : base(token, url)
		{
		}

		public Task<DiscussionModel> AddDiscussion(DiscussionInputModel discussionInputModel)
		{
			return Post<DiscussionModel,DiscussionInputModel>("mod_forum_add_discussion", discussionInputModel);
		}

		public Task<DiscussionPostModel> AddDiscussionPost(DiscussionPostInputModel discussionPostInputModel)
		{
			return Post<DiscussionPostModel,DiscussionPostInputModel>("mod_forum_add_discussion_post", discussionPostInputModel);
		}

		public Task<CanDiscussionModel> CanAddDiscussion(CanDiscussionInputModel canDiscussionInputModel)
		{
			return Post<CanDiscussionModel,CanDiscussionInputModel>("mod_forum_can_add_discussion", canDiscussionInputModel);
		}

		public Task<ForumDiscussionPostsModel> GetForumDiscussionPosts(ForumDiscussionPostsInputModel forumDiscussionPostsInputModel)
		{
			return Post<ForumDiscussionPostsModel,ForumDiscussionPostsInputModel>("mod_forum_get_forum_discussion_posts", forumDiscussionPostsInputModel);
		}

		public Task<ForumDiscussionsPaginatedModel> GetForumDiscussionsPaginated(ForumDiscussionsPaginatedInputModel forumDiscussionsPaginatedInputModel)
		{
			return Post<ForumDiscussionsPaginatedModel,ForumDiscussionsPaginatedInputModel>("mod_forum_get_forum_discussions_paginated", forumDiscussionsPaginatedInputModel);
		}

		public Task<ForumsByCoursesModel> GetForumsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ForumsByCoursesModel,DeleteCoursesInputModel>("mod_forum_get_forums_by_courses", deleteCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewForum(ViewForumInputModel viewForumInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewForumInputModel>("mod_forum_view_forum", viewForumInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewForumDiscussion(ViewForumDiscussionInputModel viewForumDiscussionInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewForumDiscussionInputModel>("mod_forum_view_forum_discussion", viewForumDiscussionInputModel);
		}

		//Function Placeholder

	}
}