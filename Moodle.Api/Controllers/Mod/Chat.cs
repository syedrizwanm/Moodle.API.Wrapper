using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Chat : BaseController
	{

		public Chat() : base()
		{
		}

		public Chat(string token, string url) : base(token, url)
		{
		}

		public Task<ChatLatestMessagesModel> GetChatLatestMessages(ChatLatestMessagesInputModel chatLatestMessagesInputModel)
		{
			return Post<ChatLatestMessagesModel,ChatLatestMessagesInputModel>("mod_chat_get_chat_latest_messages", chatLatestMessagesInputModel);
		}

		public Task<ChatsByCoursesModel> GetChatsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ChatsByCoursesModel,DeleteCoursesInputModel>("mod_chat_get_chats_by_courses", deleteCoursesInputModel);
		}

		public Task<BlockedUsersModel> GetChatUsers(ChatUsersInputModel chatUsersInputModel)
		{
			return Post<BlockedUsersModel,ChatUsersInputModel>("mod_chat_get_chat_users", chatUsersInputModel);
		}

		public Task<LoginUserModel> LoginUser(LoginUserInputModel loginUserInputModel)
		{
			return Post<LoginUserModel,LoginUserInputModel>("mod_chat_login_user", loginUserInputModel);
		}

		public Task<MarkMessageReadModel> SendChatMessage(SendChatMessageInputModel sendChatMessageInputModel)
		{
			return Post<MarkMessageReadModel,SendChatMessageInputModel>("mod_chat_send_chat_message", sendChatMessageInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewChat(ViewChatInputModel viewChatInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewChatInputModel>("mod_chat_view_chat", viewChatInputModel);
		}

		//Function Placeholder

	}
}