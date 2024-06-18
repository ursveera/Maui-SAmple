namespace Maui_SAmple.ClientService
{
	public class httpClientService
	{
		private readonly HttpClient _httpClient;

		public httpClientService(HttpClient httpclient) {

			_httpClient = httpclient;
		}
		public async Task<string> getname()
		{
			string apiUrl = "https://reqres.in/api/users/2";
			HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
			response.EnsureSuccessStatusCode();
			string content = await response.Content.ReadAsStringAsync();
			return content;
		}
	}
}
