using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Files : BaseController
	{

		public Files() : base()
		{
		}

		public Files(string token, string url) : base(token, url)
		{
		}

		public FilesModel GetFiles(FilesInputModel filesInputModel)
		{
			return Post<FilesModel,FilesInputModel>("core_files_get_files", filesInputModel);
		}

		public UploadModel Upload(UploadInputModel uploadInputModel)
		{
			return Post<UploadModel,UploadInputModel>("core_files_upload", uploadInputModel);
		}

		//Function Placeholder

	}
}