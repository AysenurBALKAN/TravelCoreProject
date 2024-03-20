using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class APIExchangeController : Controller
    {
        public async  Task<IActionResult> Index()
        {

			List<BookingExchangeModel2> exchangeViewModels=new List<BookingExchangeModel2>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=AED"),
				Headers =
	{
		{ "X-RapidAPI-Key", "24b9c0a891msh13b52917d0163b2p1fc7dfjsn2c5b2db451c1" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<BookingExchangeModel2>(body);
				return View(values.exchange_rates);
			}
		}
    }
}
