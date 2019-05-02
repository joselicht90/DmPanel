using DungeonsDragons.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace DungeonsDragons.Services
{
    public static class ApiService
    {
        // GET: Api
        public static IList<ItemsDTO> GetRaces()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://www.dnd5eapi.co/api/races").Result;
                response.EnsureSuccessStatusCode();
                ResponseDTO items = JsonConvert.DeserializeObject<ResponseDTO>(response.Content.ReadAsStringAsync().Result);
                return items.Results;
            }
        }

        public static string GetRaceTraits(string url)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                Race race = JsonConvert.DeserializeObject<Race>(response.Content.ReadAsStringAsync().Result);
                string traits = race.GetTraits();
                return traits;
            }
        }
    }
}