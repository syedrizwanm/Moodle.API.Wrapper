using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
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