using Missile_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Missile_Project.ViewModels
{
    public class GeoCoordinateApi
    {
        public const string API_KEY = "AIzaSyDiSEvb5lEtA1qouymyM29eUJ3Fz-o3HZk";
        // public const string BASE_URL = "https://maps.googleapis.com/maps/api/geocode/json?address=1600+Amphitheatre+Parkway,+Mountain+View,+CA&key=YOUR_API_KEY";
        public const string BASE_URL = "https://maps.googleapis.com/maps/api/geocode/json?address={1}&key={0}";

        public static async Task<GeoCoordinate> GetGeoCoordinateAsync(string address)
        {
            GeoCoordinate result = new GeoCoordinate();

            string url = string.Format(BASE_URL, API_KEY, address);

            using (HttpClient client = new HttpClient())
            {

                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<GeoCoordinate>(json);
            }

            return result;
        }
    }
}
