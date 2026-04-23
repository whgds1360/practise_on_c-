using System.Web;

namespace Weather
{
    public partial class Form1 : Form
    {   
        private HttpClient client = new HttpClient();
        private static readonly string URL_CITY_COORD = "https://geocoding-api.open-meteo.com/v1/search";

        public Form1()
        {
            InitializeComponent();
        }

        private static async Task GetCityCoord()
        {
            UriBuilder urlBuilder = new UriBuilder(URL_CITY_COORD);

            var query = HttpUtility.ParseQueryString(urlBuilder.Query);
            //query["name"] = 
        }
    }
}
