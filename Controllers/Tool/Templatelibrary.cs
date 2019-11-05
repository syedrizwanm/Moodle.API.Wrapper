using System.Threading.Tasks;
using Moodle.Api.Models.Tool;

namespace Moodle.Api.Controllers.Tool
{
	public sealed class Templatelibrary : BaseController
	{

		public Templatelibrary() : base()
		{
		}

		public Templatelibrary(string token, string url) : base(token, url)
		{
		}

		public Task<TemplatesModel> ListTemplates(TemplatesInputModel templatesInputModel)
		{
			return Post<TemplatesModel,TemplatesInputModel>("tool_templatelibrary_list_templates", templatesInputModel);
		}

		public Task<string> LoadCanonicalTemplate(LoadCanonicalTemplateInputModel loadCanonicalTemplateInputModel)
		{
			return Post<string,LoadCanonicalTemplateInputModel>("tool_templatelibrary_load_canonical_template", loadCanonicalTemplateInputModel);
		}

		//Function Placeholder

	}
}