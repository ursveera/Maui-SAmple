using Microsoft.AspNetCore.Mvc;

namespace Maui_SAmple.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		[HttpGet(Name = "GetData")]
		public string getdata()
		{
			return "Veeramani";
		}
	}
}