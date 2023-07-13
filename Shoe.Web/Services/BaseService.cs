using Newtonsoft.Json;
using Shoe.Web.Models;
using Shoe.Web.Services.IServices;

namespace Shoe.Web.Services
{
	public class BaseService : IBaseService
	{
		public ResponseDto responseModel { get; set; }
		public IHttpClientFactory httpClient { get; set; }

		public BaseService(IHttpClientFactory httpClient) 
		{ 
			this.responseModel = new ResponseDto();
			this.httpClient = httpClient;
		}


		public Task<T> SendAsync<T>(ApiRequest apiRequest)
		{
			try
			{
				var client = httpClient.CreateClient("ShoeAPI");
				HttpRequestMessage message = new HttpRequestMessage();
				message.Headers.Add("Accept", "application/json");
				message.RequestUri = new Uri(apiRequest.Url);
				client.DefaultRequestHeaders.Clear();
				if(apiRequest.Data!= null)
				{
					message.Content = new StringContent(JsonConvert)
				}

			}
			catch(Exception e)
			{

			}
		}

		public void Dispose()
		{
			GC.SuppressFinalize(true);
		}
	}
}
