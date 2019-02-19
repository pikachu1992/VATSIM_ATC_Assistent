using Eve;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Threading.Tasks;
using VATSIM_ATC_Assistent.UI;

namespace VATSIM_ATC_Assistent
{
    class GetATCs
    {

        public static List<ATCs> atcsList { get; set; }

        public delegate void OnATCS(List<UI.ATCs> ATCS);
        public static event OnATCS onATCS;

        public static readonly EveClient FaStatusServer = new EveClient("http://snet.flyatlantic-va.com:5001");

        public static async Task GetClientsByPositionAsync()
        {
            List<ATCs> atcs = await FaStatusServer.GetAsync<ATCs>("clients", false, "{\"clienttype\":\"ATC\"}");
            List<ATCs> output = new List<ATCs>();

            

            foreach(var atc in atcs)
            {

                output.Add(atc);

            }

            onATCS(output);

        }

    }
}
