using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Update : BaseController
	{

		public Update() : base()
		{
		}

		public Update(string token, string url) : base(token, url)
		{
		}

		public Task<InplaceEditableModel> InplaceEditable(InplaceEditableInputModel inplaceEditableInputModel)
		{
			return Post<InplaceEditableModel,InplaceEditableInputModel>("core_update_inplace_editable", inplaceEditableInputModel);
		}

		//Function Placeholder

	}
}