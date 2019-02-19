using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Windows.Forms;
using VATSIM_ATC_Assistent.UI;

namespace VATSIM_ATC_Assistent
{

    class App : ApplicationContext
    {
        ConnFrm startFrm = new ConnFrm();

        public static MainFrm mainFrm;

        public static List<UI.Pilots> Pilots;

        public static List<UI.ATCs> ATCS;

        public static string ATCPosition { get; set; }

        public static GeoCoordinate ATCLocation { get; set; }

        Timer updateClients = new Timer();

        public App()
        {
            GetATCs.GetClientsByPositionAsync();
            startFrm.onStartConn += StartFrm_onStartConn;
            startFrm.Show();

            GetATCs.onATCS += GetATCs_onATCS;

            updateClients.Interval = 60000;
            updateClients.Tick += UpdateClients_Tick;
            
        }

        private void UpdateClients_Tick(object sender, EventArgs e)
        {
            GetTrafficFromPosition.GetClientsByPositionAsync(ATCPosition);
            GetATCs.GetClientsByPositionAsync();
        }

        private void GetATCs_onATCS(List<UI.ATCs> atcs)
        {
            ATCS = atcs;
        }

        private void StartFrm_onStartConn(string position)
        {
            ATCPosition = position;
            GetTrafficFromPosition.GetClientsByPositionAsync(position);
            GetTrafficFromPosition.onClient += GetTrafficFromPosition_onClient;

            updateClients.Start();
        }

        private void GetTrafficFromPosition_onClient(List<UI.Pilots> pilots, GeoCoordinate location)
        {
            Pilots = pilots;
            ATCLocation = location;

            
            if (mainFrm == null)
            {    

                mainFrm = new MainFrm();

                mainFrm.Show();

                new Shows();
            }
        }
    }
}
