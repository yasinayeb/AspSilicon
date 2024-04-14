using AspSilicon.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AspSilicon.Controllers
{
    public class SubscribeController(HttpClient http) : Controller
    {
        private readonly HttpClient _http = http;

        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscribeViewModel form)
        {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(form), Encoding.UTF8, "application/json");
                var response = await _http.PostAsync("https://localhost:7263/api/Subscribe", content);
                if (response.IsSuccessStatusCode)
                {
                    TempData["Status"] = "Your are now subscribed";
                    return RedirectToAction("Home", "Default", "subscribe");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    TempData["Status"] = "Your are already subscribed";
                    return RedirectToAction("Home", "Default", "subscribe");
                }

         
            }
            TempData["Status"] = "Something went wrong";
            return RedirectToAction("Home", "Default", "subscribe");
        }
    }
}
