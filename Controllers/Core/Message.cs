using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Message : BaseController
	{

		public Message() : base()
		{
		}

		public Message(string token, string url) : base(token, url)
		{
		}

		public Task<BlockContactsModel> BlockContacts(BlockContactsInputModel blockContactsInputModel)
		{
			return Post<BlockContactsModel,BlockContactsInputModel>("core_message_block_contacts", blockContactsInputModel);
		}

		public Task<BlockContactsModel> CreateContacts(BlockContactsInputModel blockContactsInputModel)
		{
			return Post<BlockContactsModel,BlockContactsInputModel>("core_message_create_contacts", blockContactsInputModel);
		}

		public Task<DataForMessageareaContactsModel> DataForMessageareaContacts(DataForMessageareaContactsInputModel dataForMessageareaContactsInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaContactsInputModel>("core_message_data_for_messagearea_contacts", dataForMessageareaContactsInputModel);
		}

		public Task<DataForMessageareaContactsModel> DataForMessageareaConversations(DataForMessageareaContactsInputModel dataForMessageareaContactsInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaContactsInputModel>("core_message_data_for_messagearea_conversations", dataForMessageareaContactsInputModel);
		}

		public Task<DataForMessageareaMostRecentMessageModel> DataForMessageareaGetMostRecentMessage(DataForMessageareaMostRecentMessageInputModel dataForMessageareaMostRecentMessageInputModel)
		{
			return Post<DataForMessageareaMostRecentMessageModel,DataForMessageareaMostRecentMessageInputModel>("core_message_data_for_messagearea_get_most_recent_message", dataForMessageareaMostRecentMessageInputModel);
		}

		public Task<DataForMessageareaProfileModel> DataForMessageareaGetProfile(DataForMessageareaMostRecentMessageInputModel dataForMessageareaMostRecentMessageInputModel)
		{
			return Post<DataForMessageareaProfileModel,DataForMessageareaMostRecentMessageInputModel>("core_message_data_for_messagearea_get_profile", dataForMessageareaMostRecentMessageInputModel);
		}

		public Task<DataForMessageareaMessagesModel> DataForMessageareaMessages(DataForMessageareaMessagesInputModel dataForMessageareaMessagesInputModel)
		{
			return Post<DataForMessageareaMessagesModel,DataForMessageareaMessagesInputModel>("core_message_data_for_messagearea_messages", dataForMessageareaMessagesInputModel);
		}

		public Task<DataForMessageareaContactsModel> DataForMessageareaSearchMessages(DataForMessageareaSearchMessagesInputModel dataForMessageareaSearchMessagesInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaSearchMessagesInputModel>("core_message_data_for_messagearea_search_messages", dataForMessageareaSearchMessagesInputModel);
		}

		public Task<DataForMessageareaSearchUsersModel> DataForMessageareaSearchUsers(DataForMessageareaSearchUsersInputModel dataForMessageareaSearchUsersInputModel)
		{
			return Post<DataForMessageareaSearchUsersModel,DataForMessageareaSearchUsersInputModel>("core_message_data_for_messagearea_search_users", dataForMessageareaSearchUsersInputModel);
		}

		public Task<DataForMessageareaContactsModel> DataForMessageareaSearchUsersInCourse(DataForMessageareaSearchUsersInCourseInputModel dataForMessageareaSearchUsersInCourseInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaSearchUsersInCourseInputModel>("core_message_data_for_messagearea_search_users_in_course", dataForMessageareaSearchUsersInCourseInputModel);
		}

		public Task DeleteContacts(BlockContactsInputModel blockContactsInputModel)
		{
			return Post<BlockContactsInputModel>("core_message_delete_contacts", blockContactsInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> DeleteConversation(DeleteConversationInputModel deleteConversationInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,DeleteConversationInputModel>("core_message_delete_conversation", deleteConversationInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> DeleteMessage(DeleteMessageInputModel deleteMessageInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,DeleteMessageInputModel>("core_message_delete_message", deleteMessageInputModel);
		}

		public Task<BlockedUsersModel> GetBlockedUsers(UserPlansInputModel userPlansInputModel)
		{
			return Post<BlockedUsersModel,UserPlansInputModel>("core_message_get_blocked_users", userPlansInputModel);
		}

		public Task<ContactsModel> GetContacts( )
		{
			return Post<ContactsModel>("core_message_get_contacts");
		}

		public Task<MessageProcessorModel> GetMessageProcessor(MessageProcessorInputModel messageProcessorInputModel)
		{
			return Post<MessageProcessorModel,MessageProcessorInputModel>("core_message_get_message_processor", messageProcessorInputModel);
		}

		public Task<MessagesModel> GetMessages(MessagesInputModel messagesInputModel)
		{
			return Post<MessagesModel,MessagesInputModel>("core_message_get_messages", messagesInputModel);
		}

		public Task<int> GetUnreadConversationsCount(UnreadConversationsCountInputModel unreadConversationsCountInputModel)
		{
			return Post<int,UnreadConversationsCountInputModel>("core_message_get_unread_conversations_count", unreadConversationsCountInputModel);
		}

		public Task<UserMessagePreferencesModel> GetUserMessagePreferences(UserPlansInputModel userPlansInputModel)
		{
			return Post<UserMessagePreferencesModel,UserPlansInputModel>("core_message_get_user_message_preferences", userPlansInputModel);
		}

		public Task<UserNotificationPreferencesModel> GetUserNotificationPreferences(UserPlansInputModel userPlansInputModel)
		{
			return Post<UserNotificationPreferencesModel,UserPlansInputModel>("core_message_get_user_notification_preferences", userPlansInputModel);
		}

		public Task<int> MarkAllMessagesAsRead(MarkAllMessagesAsReadInputModel markAllMessagesAsReadInputModel)
		{
			return Post<int,MarkAllMessagesAsReadInputModel>("core_message_mark_all_messages_as_read", markAllMessagesAsReadInputModel);
		}

		public Task<int> MarkAllNotificationsAsRead(MarkAllMessagesAsReadInputModel markAllMessagesAsReadInputModel)
		{
			return Post<int,MarkAllMessagesAsReadInputModel>("core_message_mark_all_notifications_as_read", markAllMessagesAsReadInputModel);
		}

		public Task<MarkMessageReadModel> MarkMessageRead(MarkMessageReadInputModel markMessageReadInputModel)
		{
			return Post<MarkMessageReadModel,MarkMessageReadInputModel>("core_message_mark_message_read", markMessageReadInputModel);
		}

		public Task MessageProcessorConfigForm(MessageProcessorConfigFormInputModel messageProcessorConfigFormInputModel)
		{
			return Post<MessageProcessorConfigFormInputModel>("core_message_message_processor_config_form", messageProcessorConfigFormInputModel);
		}

		public Task<SearchContactsModel> SearchContacts(SearchContactsInputModel searchContactsInputModel)
		{
			return Post<SearchContactsModel,SearchContactsInputModel>("core_message_search_contacts", searchContactsInputModel);
		}

		public Task<SendInstantMessagesModel> SendInstantMessages(SendInstantMessagesInputModel sendInstantMessagesInputModel)
		{
			return Post<SendInstantMessagesModel,SendInstantMessagesInputModel>("core_message_send_instant_messages", sendInstantMessagesInputModel);
		}

		public Task UnblockContacts(BlockContactsInputModel blockContactsInputModel)
		{
			return Post<BlockContactsInputModel>("core_message_unblock_contacts", blockContactsInputModel);
		}

		//Function Placeholder

	}
}