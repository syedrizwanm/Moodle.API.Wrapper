using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
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