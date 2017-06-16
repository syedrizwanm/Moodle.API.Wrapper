using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Chat : BaseController
	{

		public Chat() : base()
		{
		}

		public Chat(string token, string url) : base(token, url)
		{
		}

		public ChatLatestMessagesModel GetChatLatestMessages(ChatLatestMessagesInputModel chatLatestMessagesInputModel)
		{
			return Post<ChatLatestMessagesModel,ChatLatestMessagesInputModel>("mod_chat_get_chat_latest_messages", chatLatestMessagesInputModel);
		}

		public ChatsByCoursesModel GetChatsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ChatsByCoursesModel,DeleteCoursesInputModel>("mod_chat_get_chats_by_courses", deleteCoursesInputModel);
		}

		public BlockedUsersModel GetChatUsers(ChatUsersInputModel chatUsersInputModel)
		{
			return Post<BlockedUsersModel,ChatUsersInputModel>("mod_chat_get_chat_users", chatUsersInputModel);
		}

		public LoginUserModel LoginUser(LoginUserInputModel loginUserInputModel)
		{
			return Post<LoginUserModel,LoginUserInputModel>("mod_chat_login_user", loginUserInputModel);
		}

		public MarkMessageReadModel SendChatMessage(SendChatMessageInputModel sendChatMessageInputModel)
		{
			return Post<MarkMessageReadModel,SendChatMessageInputModel>("mod_chat_send_chat_message", sendChatMessageInputModel);
		}

		public MarkCourseSelfCompletedModel ViewChat(ViewChatInputModel viewChatInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewChatInputModel>("mod_chat_view_chat", viewChatInputModel);
		}

		//Function Placeholder

	}
}