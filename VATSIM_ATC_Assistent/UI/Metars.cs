using Eve;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace VATSIM_ATC_Assistent.UI
{
    class Metars
    {
        public static readonly EveClient FaStatusServer = new EveClient("https://avwx.rest/api/metar/");

        [JsonProperty("Altimeter")]
        public string Altimeter { get; set; }

        [JsonProperty("Wind-Direction")]
        public string WindDirection { get; set; }

        [JsonProperty("Wind-Speed")]
        public string WindSpeed { get; set; }

        [JsonProperty("Wind-Gust")]
        public string WindGust { get; set; }

        public static Metars Metar(string ICAO)
        {
            WebRequest request = WebRequest.Create("https://avwx.rest/api/metar/" + ICAO);


            using (WebResponse responseWeb = request.GetResponse())
            {
                using (StreamReader readerStream = new StreamReader(responseWeb.GetResponseStream()))
                {
                    string response = readerStream.ReadToEnd().Trim();

                    return JsonConvert.DeserializeObject<Metars>(response);
                }
            }
        }
    }

}
