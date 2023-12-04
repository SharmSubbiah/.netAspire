namespace AspireApp.Components
{
    using AspireAPI;
    using System.Net.Http;

    public class AspireApiClinet
    {
        private readonly HttpClient _httpClient;

        public AspireApiClinet(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetWeatherForecastsAsync()
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("weatherforecast");
        }
    }
}

