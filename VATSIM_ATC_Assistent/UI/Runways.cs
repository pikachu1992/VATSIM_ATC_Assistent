using System;

namespace VATSIM_ATC_Assistent.UI
{
    class Runways
    {

        public static void GetRunways()
        {
            App.mainFrm.cboxRunways.Items.Clear();

            switch (App.ATCPosition.Split("_".ToCharArray())[0])
            {
                case "LPPT":
                    App.mainFrm.cboxRunways.Items.Add("03");
                    App.mainFrm.cboxRunways.Items.Add("21");

                    if (Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection != "VRB")
                    {
                        if (Convert.ToInt32(Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection) > 120 && Convert.ToInt32(Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection) < 300)
                            App.mainFrm.cboxRunways.SelectedIndex = 1;
                        else
                            App.mainFrm.cboxRunways.SelectedIndex = 0;
                    }
                    else
                    {
                        App.mainFrm.cboxRunways.SelectedIndex = 0;
                    }
                    break;
            }
        }
    }
}
