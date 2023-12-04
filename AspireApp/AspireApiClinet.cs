namespace AspireApp.Components
{
    using System.Net.Http;
    using AspireAPI;

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

