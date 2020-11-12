using RestSharp;
using System.IO;
using Newtonsoft.Json;

namespace ServeRest.Rest
{
    public class Requests
    {
        public RestClient _restClient;
        public RestRequest _restRequest;
        public string _baseURL = "https://serverest.dev/";


        public RestClient SetUrl(string url)
        {
            var fullUrl = Path.Combine(_baseURL, url);
            var _restClient = new RestClient(fullUrl);
            return _restClient;
        }

        public RestRequest CreateGetRequest()
        {
            _restRequest = new RestRequest(Method.GET);
            return _restRequest;
        }

        public IRestResponse SendGet(string url)
        {
            var restUrl = SetUrl(url);
            var restRequest = CreateGetRequest();
            var response = GetResponse(restUrl, restRequest);
            return response;
        }
        public IRestResponse GetResponse(RestClient restClient, RestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }

        public DTO GetContent<DTO>(IRestResponse response)
        {
            DTO deseiralizeObject = JsonConvert.DeserializeObject<DTO>(response.Content);
            return deseiralizeObject;
        }
    }
}
