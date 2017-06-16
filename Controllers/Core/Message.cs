using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Message : BaseController
	{

		public Message() : base()
		{
		}

		public Message(string token, string url) : base(token, url)
		{
		}

		public BlockContactsModel BlockContacts(BlockContactsInputModel blockContactsInputModel)
		{
			return Post<BlockContactsModel,BlockContactsInputModel>("core_message_block_contacts", blockContactsInputModel);
		}

		public BlockContactsModel CreateContacts(BlockContactsInputModel blockContactsInputModel)
		{
			return Post<BlockContactsModel,BlockContactsInputModel>("core_message_create_contacts", blockContactsInputModel);
		}

		public DataForMessageareaContactsModel DataForMessageareaContacts(DataForMessageareaContactsInputModel dataForMessageareaContactsInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaContactsInputModel>("core_message_data_for_messagearea_contacts", dataForMessageareaContactsInputModel);
		}

		public DataForMessageareaContactsModel DataForMessageareaConversations(DataForMessageareaContactsInputModel dataForMessageareaContactsInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaContactsInputModel>("core_message_data_for_messagearea_conversations", dataForMessageareaContactsInputModel);
		}

		public DataForMessageareaMostRecentMessageModel DataForMessageareaGetMostRecentMessage(DataForMessageareaMostRecentMessageInputModel dataForMessageareaMostRecentMessageInputModel)
		{
			return Post<DataForMessageareaMostRecentMessageModel,DataForMessageareaMostRecentMessageInputModel>("core_message_data_for_messagearea_get_most_recent_message", dataForMessageareaMostRecentMessageInputModel);
		}

		public DataForMessageareaProfileModel DataForMessageareaGetProfile(DataForMessageareaMostRecentMessageInputModel dataForMessageareaMostRecentMessageInputModel)
		{
			return Post<DataForMessageareaProfileModel,DataForMessageareaMostRecentMessageInputModel>("core_message_data_for_messagearea_get_profile", dataForMessageareaMostRecentMessageInputModel);
		}

		public DataForMessageareaMessagesModel DataForMessageareaMessages(DataForMessageareaMessagesInputModel dataForMessageareaMessagesInputModel)
		{
			return Post<DataForMessageareaMessagesModel,DataForMessageareaMessagesInputModel>("core_message_data_for_messagearea_messages", dataForMessageareaMessagesInputModel);
		}

		public DataForMessageareaContactsModel DataForMessageareaSearchMessages(DataForMessageareaSearchMessagesInputModel dataForMessageareaSearchMessagesInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaSearchMessagesInputModel>("core_message_data_for_messagearea_search_messages", dataForMessageareaSearchMessagesInputModel);
		}

		public DataForMessageareaSearchUsersModel DataForMessageareaSearchUsers(DataForMessageareaSearchUsersInputModel dataForMessageareaSearchUsersInputModel)
		{
			return Post<DataForMessageareaSearchUsersModel,DataForMessageareaSearchUsersInputModel>("core_message_data_for_messagearea_search_users", dataForMessageareaSearchUsersInputModel);
		}

		public DataForMessageareaContactsModel DataForMessageareaSearchUsersInCourse(DataForMessageareaSearchUsersInCourseInputModel dataForMessageareaSearchUsersInCourseInputModel)
		{
			return Post<DataForMessageareaContactsModel,DataForMessageareaSearchUsersInCourseInputModel>("core_message_data_for_messagearea_search_users_in_course", dataForMessageareaSearchUsersInCourseInputModel);
		}

		public void DeleteContacts(BlockContactsInputModel blockContactsInputModel)
		{
			Post<BlockContactsInputModel>("core_message_delete_contacts", blockContactsInputModel);
		}

		public MarkCourseSelfCompletedModel DeleteConversation(DeleteConversationInputModel deleteConversationInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,DeleteConversationInputModel>("core_message_delete_conversation", deleteConversationInputModel);
		}

		public MarkCourseSelfCompletedModel DeleteMessage(DeleteMessageInputModel deleteMessageInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,DeleteMessageInputModel>("core_message_delete_message", deleteMessageInputModel);
		}

		public BlockedUsersModel GetBlockedUsers(UserPlansInputModel userPlansInputModel)
		{
			return Post<BlockedUsersModel,UserPlansInputModel>("core_message_get_blocked_users", userPlansInputModel);
		}

		public ContactsModel GetContacts( )
		{
			return Post<ContactsModel>("core_message_get_contacts");
		}

		public MessageProcessorModel GetMessageProcessor(MessageProcessorInputModel messageProcessorInputModel)
		{
			return Post<MessageProcessorModel,MessageProcessorInputModel>("core_message_get_message_processor", messageProcessorInputModel);
		}

		public MessagesModel GetMessages(MessagesInputModel messagesInputModel)
		{
			return Post<MessagesModel,MessagesInputModel>("core_message_get_messages", messagesInputModel);
		}

		public int GetUnreadConversationsCount(UnreadConversationsCountInputModel unreadConversationsCountInputModel)
		{
			return Post<int,UnreadConversationsCountInputModel>("core_message_get_unread_conversations_count", unreadConversationsCountInputModel);
		}

		public UserMessagePreferencesModel GetUserMessagePreferences(UserPlansInputModel userPlansInputModel)
		{
			return Post<UserMessagePreferencesModel,UserPlansInputModel>("core_message_get_user_message_preferences", userPlansInputModel);
		}

		public UserNotificationPreferencesModel GetUserNotificationPreferences(UserPlansInputModel userPlansInputModel)
		{
			return Post<UserNotificationPreferencesModel,UserPlansInputModel>("core_message_get_user_notification_preferences", userPlansInputModel);
		}

		public int MarkAllMessagesAsRead(MarkAllMessagesAsReadInputModel markAllMessagesAsReadInputModel)
		{
			return Post<int,MarkAllMessagesAsReadInputModel>("core_message_mark_all_messages_as_read", markAllMessagesAsReadInputModel);
		}

		public int MarkAllNotificationsAsRead(MarkAllMessagesAsReadInputModel markAllMessagesAsReadInputModel)
		{
			return Post<int,MarkAllMessagesAsReadInputModel>("core_message_mark_all_notifications_as_read", markAllMessagesAsReadInputModel);
		}

		public MarkMessageReadModel MarkMessageRead(MarkMessageReadInputModel markMessageReadInputModel)
		{
			return Post<MarkMessageReadModel,MarkMessageReadInputModel>("core_message_mark_message_read", markMessageReadInputModel);
		}

		public void MessageProcessorConfigForm(MessageProcessorConfigFormInputModel messageProcessorConfigFormInputModel)
		{
			Post<MessageProcessorConfigFormInputModel>("core_message_message_processor_config_form", messageProcessorConfigFormInputModel);
		}

		public SearchContactsModel SearchContacts(SearchContactsInputModel searchContactsInputModel)
		{
			return Post<SearchContactsModel,SearchContactsInputModel>("core_message_search_contacts", searchContactsInputModel);
		}

		public SendInstantMessagesModel SendInstantMessages(SendInstantMessagesInputModel sendInstantMessagesInputModel)
		{
			return Post<SendInstantMessagesModel,SendInstantMessagesInputModel>("core_message_send_instant_messages", sendInstantMessagesInputModel);
		}

		public void UnblockContacts(BlockContactsInputModel blockContactsInputModel)
		{
			Post<BlockContactsInputModel>("core_message_unblock_contacts", blockContactsInputModel);
		}

		//Function Placeholder

	}
}