using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace RGR_int
{
    class ShikimoriApiClient
    {
        private readonly HttpClient httpClient;

        public ShikimoriApiClient()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://shikimori.org/api/");
        }

        public async Task<string> GetAnimeDetails(int animeId)
        {
            string url = $"animes/{animeId}";
            HttpResponseMessage response = await httpClient.GetAsync(url);
            string responseContent = await response.Content.ReadAsStringAsync();

            // Пример обработки ответа в формате JSON
            dynamic animeData = JsonConvert.DeserializeObject(responseContent);
            string animeTitle = animeData.title;

            return animeTitle;
        }
        public static async Task<AnimeData> SearchAnimeByTitle(string animeTitle)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://shikimori.one/api/animes?search={Uri.EscapeDataString(animeTitle)}";
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0"); // Установка User-Agent заголовка для обхода ограничений
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    AnimeData[] animeDataArray = System.Text.Json.JsonSerializer.Deserialize<AnimeData[]>(jsonResponse);
                    AnimeData animeData = animeDataArray.Length > 0 ? new AnimeData(animeDataArray[0].Russian, new Image(animeDataArray[0].Image)) : null;
                    return animeData;
                }
                else
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {response.StatusCode}");
                    return null;
                }
            }
        }


        public static async Task<AnimeData> Main(string animeTitle)
        {
            return await SearchAnimeByTitle(animeTitle);
        }





    }
}
