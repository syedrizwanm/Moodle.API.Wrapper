using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Get : BaseController
	{

		public Get() : base()
		{
		}

		public Get(string token, string url) : base(token, url)
		{
		}

		public ComponentStringsModel ComponentStrings(ComponentStringsInputModel componentStringsInputModel)
		{
			return Post<ComponentStringsModel,ComponentStringsInputModel>("core_get_component_strings", componentStringsInputModel);
		}

		public FragmentModel Fragment(FragmentInputModel fragmentInputModel)
		{
			return Post<FragmentModel,FragmentInputModel>("core_get_fragment", fragmentInputModel);
		}

		public string String(StringInputModel stringInputModel)
		{
			return Post<string,StringInputModel>("core_get_string", stringInputModel);
		}

		public StringsModel Strings(StringsInputModel stringsInputModel)
		{
			return Post<StringsModel,StringsInputModel>("core_get_strings", stringsInputModel);
		}

		public UserDatesModel UserDates(UserDatesInputModel userDatesInputModel)
		{
			return Post<UserDatesModel,UserDatesInputModel>("core_get_user_dates", userDatesInputModel);
		}

		//Function Placeholder

	}
}