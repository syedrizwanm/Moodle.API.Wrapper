using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Update : BaseController
	{

		public Update() : base()
		{
		}

		public Update(string token, string url) : base(token, url)
		{
		}

		public InplaceEditableModel InplaceEditable(InplaceEditableInputModel inplaceEditableInputModel)
		{
			return Post<InplaceEditableModel,InplaceEditableInputModel>("core_update_inplace_editable", inplaceEditableInputModel);
		}

		//Function Placeholder

	}
}