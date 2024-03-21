using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using TravelCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    public class BookingHotelController : Controller
    {
		[AllowAnonymous]
		[Area("Admin")]
        public async Task<IActionResult> Index()
        {

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?locale=en-gb&filter_by_currency=AED&checkin_date=2024-09-14&dest_type=city&dest_id=-1456928&adults_number=2&checkout_date=2024-09-15&order_by=popularity&room_number=1&units=metric&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&include_adjacency=true&page_number=0"),
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

				var values = JsonConvert.DeserializeObject<BookingHotelViewModel>(body);
				return View(values.results);
			}
		}
		[HttpGet]
		public IActionResult GetCityDestId()
        {
			return View();
        }

		[HttpPost]
		public async Task<IActionResult> GetCityDestId(string p)
        {
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={p}&locale=en-gb"),
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

				return View();
			}
		}
    }

}
