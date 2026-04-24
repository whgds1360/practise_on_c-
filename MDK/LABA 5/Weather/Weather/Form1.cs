using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Web;

namespace Weather
{
    public partial class MainForm : Form
    {
        private HttpClient client = new HttpClient();

        private static readonly string URL_CITY_COORD = "https://geocoding-api.open-meteo.com/v1/search";
        private static readonly string URL_GET_WEATHER = "https://api.open-meteo.com/v1/forecast";

        private StringBuilder lat = new StringBuilder();
        private StringBuilder lon = new StringBuilder();

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void ExecuteHandler(object sender, EventArgs e)
        {
            await GetCityCoord();
            await GetWeather();
        }

        private async Task GetCityCoord()
        {
            UriBuilder urlBuilder = new UriBuilder(URL_CITY_COORD);

            var parametrs = HttpUtility.ParseQueryString(urlBuilder.Query);
            parametrs["name"] = this.InPutTextBox.Text;

            var readyParametrs = parametrs.ToString();

            string query = $"{URL_CITY_COORD}?{readyParametrs}";

            var response = await client.GetAsync(query);
            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);
            lat.Append(doc.RootElement.GetProperty("results")[0].GetProperty("latitude").GetDouble().ToString());
            lon.Append(doc.RootElement.GetProperty("results")[0].GetProperty("longitude").GetDouble().ToString());

            Debug.WriteLine($"Широта: {lat}, Долгота: {lon}");
        }

        private async Task GetWeather()
        {
            UriBuilder urlBuilder = new UriBuilder(URL_GET_WEATHER);

            var parametrs = HttpUtility.ParseQueryString(urlBuilder.Query);
            parametrs["latitude"] = lat.Replace(",", ".").ToString();
            parametrs["longitude"] = lon.Replace(",", ".").ToString();
            parametrs["current_weather"] = "true";

            var readyParametrs = parametrs.ToString();

            string query = $"{URL_GET_WEATHER}?{readyParametrs}";

            var response = await client.GetAsync(query);
            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);

            double temperature = doc.RootElement.GetProperty("current_weather").GetProperty("temperature").GetDouble();

            string result = $"Температура {temperature} °C";

            OutPutLabel.Text = result;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
