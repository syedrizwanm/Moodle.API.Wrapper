using System;
using System.Net.Http;
using System.Threading.Tasks;
using Moodle.Api.Models;
using Newtonsoft.Json;

namespace Moodle.Api.Controllers
{
    public class BaseController
    {
        private readonly HttpClient _moodleClient;
        private readonly string _token;

        public BaseController()
        {
        }

        public BaseController(string token, string url)
        {
            _moodleClient = new HttpClient { BaseAddress = new Uri(url + "/webservice/rest/") };
            _token = token;
        }

        protected async Task<TModel> Post<TModel, TInputModel>(string functionName, TInputModel inputModel)
            where TInputModel : IModel
        {
            var inputPairs = inputModel.ToKeyValuePairs();
            var inputContent = new FormUrlEncodedContent(inputPairs);
            var response = await _moodleClient
                .PostAsync("server.php?wstoken=" + _token + "&moodlewsrestformat=json&wsfunction=" + functionName,
                    inputContent).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                if (responseText.Contains("\"exception\":"))
                {
                    throw new InvalidOperationException(responseText);
                }

                return JsonConvert.DeserializeObject<TModel>(responseText);
            }

            throw new InvalidOperationException(responseText);
        }

        protected async Task Post<TInputModel>(string functionName, TInputModel inputModel)
            where TInputModel : IModel
        {
            var inputPairs = inputModel.ToKeyValuePairs();
            var inputContent = new FormUrlEncodedContent(inputPairs);
            var response = await _moodleClient
                .PostAsync("server.php?wstoken=" + _token + "&moodlewsrestformat=json&wsfunction=" + functionName,
                    inputContent).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!response.IsSuccessStatusCode || responseText.Contains("\"exception\":"))
                throw new InvalidOperationException(responseText);
        }

        protected async Task<TModel> Post<TModel>(string functionName)
        {
            var response = await _moodleClient.PostAsync("&wsfunction=" + functionName, null).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                if (responseText.Contains("\"exception\":"))
                {
                    throw new InvalidOperationException(responseText);
                }

                return JsonConvert.DeserializeObject<TModel>(responseText);
            }

            throw new InvalidOperationException(responseText);
        }
    }
}