using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Output : BaseController
	{

		public Output() : base()
		{
		}

		public Output(string token, string url) : base(token, url)
		{
		}

		public LoadFontawesomeIconMapModel LoadFontawesomeIconMap( )
		{
			return Post<LoadFontawesomeIconMapModel>("core_output_load_fontawesome_icon_map");
		}

		public string LoadTemplate(LoadTemplateInputModel loadTemplateInputModel)
		{
			return Post<string,LoadTemplateInputModel>("core_output_load_template", loadTemplateInputModel);
		}

		//Function Placeholder

	}
}