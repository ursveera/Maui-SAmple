using System.Collections.ObjectModel;

namespace mauiDemo
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<string> Products { get; set; } = new ObservableCollection<string>();
		private readonly HttpClient _httpClient = new HttpClient();
		// Parameterless constructor
		public MainPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		

		protected override void OnAppearing()
		{
			base.OnAppearing();
			LoadProducts();
		}

		private async void LoadProducts()
		{
			try
			{

				string apiUrl = "https://reqres.in/api/users/2";
				HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
				response.EnsureSuccessStatusCode();

				string content = await response.Content.ReadAsStringAsync();
				helloLabel.Text = content;
			}
			catch (Exception e)
			{

				throw;
			}
		}
	}

}