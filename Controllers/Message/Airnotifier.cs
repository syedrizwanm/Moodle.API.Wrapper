using Moodle.Api.Models.Message;

namespace Moodle.Api.Controllers.Message
{
	public sealed class Airnotifier : BaseController
	{

		public Airnotifier() : base()
		{
		}

		public Airnotifier(string token, string url) : base(token, url)
		{
		}

		public AreNotificationPreferencesConfiguredModel AreNotificationPreferencesConfigured(DeleteUsersInputModel deleteUsersInputModel)
		{
			return Post<AreNotificationPreferencesConfiguredModel,DeleteUsersInputModel>("message_airnotifier_are_notification_preferences_configured", deleteUsersInputModel);
		}

		public SignupUserModel EnableDevice(EnableDeviceInputModel enableDeviceInputModel)
		{
			return Post<SignupUserModel,EnableDeviceInputModel>("message_airnotifier_enable_device", enableDeviceInputModel);
		}

		public UserDevicesModel GetUserDevices(UserDevicesInputModel userDevicesInputModel)
		{
			return Post<UserDevicesModel,UserDevicesInputModel>("message_airnotifier_get_user_devices", userDevicesInputModel);
		}

		public int IsSystemConfigured( )
		{
			return Post<int>("message_airnotifier_is_system_configured");
		}

		//Function Placeholder

	}
}