using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Tool;

namespace Moodle.API.Wrapper.Controllers.Tool
{
	public sealed class Templatelibrary : BaseController
	{

		public Templatelibrary() : base()
		{
		}

		public Templatelibrary(string token, string url) : base(token, url)
		{
		}

		public TemplatesModel ListTemplates(TemplatesInputModel templatesInputModel)
		{
			return Post<TemplatesModel,TemplatesInputModel>("tool_templatelibrary_list_templates", templatesInputModel);
		}

		public string LoadCanonicalTemplate(LoadCanonicalTemplateInputModel loadCanonicalTemplateInputModel)
		{
			return Post<string,LoadCanonicalTemplateInputModel>("tool_templatelibrary_load_canonical_template", loadCanonicalTemplateInputModel);
		}

		//Function Placeholder

	}
}