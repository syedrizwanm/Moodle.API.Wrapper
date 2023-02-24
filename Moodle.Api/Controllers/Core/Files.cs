using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Files : BaseController
	{

		public Files() : base()
		{
		}

		public Files(string token, string url) : base(token, url)
		{
		}

		public Task<FilesModel> GetFiles(FilesInputModel filesInputModel)
		{
			return Post<FilesModel,FilesInputModel>("core_files_get_files", filesInputModel);
		}

		public Task<UploadModel> Upload(UploadInputModel uploadInputModel)
		{
			return Post<UploadModel,UploadInputModel>("core_files_upload", uploadInputModel);
		}

		//Function Placeholder

	}
}