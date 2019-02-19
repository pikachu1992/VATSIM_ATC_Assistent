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

        public static string ESVersion { get; set; }

        public App()
        {
            
            startFrm.onStartConn += StartFrm_onStartConn;
            startFrm.Show();

            GetATCs.onATCS += GetATCs_onATCS;

            updateClients.Interval = 180000;
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
            Console.WriteLine("Started, GetGlients...");
            ATCPosition = position;

            GetTrafficFromPosition.onClient += GetTrafficFromPosition_onClient;
            GetTrafficFromPosition.GetClientsByPositionAsync(position);
            GetATCs.GetClientsByPositionAsync();

            updateClients.Start();
        }

        private void GetTrafficFromPosition_onClient(List<UI.Pilots> pilots, GeoCoordinate location)
        {
            Console.WriteLine("GetGlients Received...");
            Pilots = pilots;
            ATCLocation = location;

            
            
            if (mainFrm == null)
            {
                Console.WriteLine("Prepare Form...");
                mainFrm = new MainFrm();

                mainFrm.Show();

                new Shows();
            }
            else
            {
                mainFrm.lblMetar.Text = Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).RawReport;
                Console.WriteLine("Update Departure List...");
                mainFrm.PopulatePilotsList(pilots);
            }
        }
    }
}
