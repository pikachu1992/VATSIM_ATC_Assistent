using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIM_ATC_Assistent.UI
{
    class ManageStringCommands
    {
        public static string GetAtisInfoLetter(string message)
        {
            string info = "";

            info = ManageStringCommands.getBetween(message.ToUpper(), "ATIS ", " ");

            return info;

        }

            public static string GetWindsString()
        {
            string wind_info = "";

             
            if (Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection != "VRB")
            {
                if (Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindVariableDir.Count == 0)
                {
                    if (Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindGust != "")
                        wind_info = String.Format("Winds {0} degrees {1} knots gusts {2} knots", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection, Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindSpeed, Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindGust);
                    else
                        wind_info = String.Format("Winds {0} degrees {1} knots", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection, Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindSpeed);
                }
                else
                {
                    if (Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindGust != "")
                        wind_info = String.Format("Winds variables between {0} and {1} degrees {2} knots gusts {3} knots", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindVariableDir[0], Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindVariableDir[1], Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindSpeed, Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindGust);
                    else
                        wind_info = String.Format("Winds variables between {0} and {1} degrees {2} knots", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindVariableDir[0], Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindVariableDir[1], Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindSpeed);
                }
            }
            else
                wind_info = String.Format("Winds variables {0} knots", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindSpeed);


            return wind_info;
        }

        public static string GetSuggestedRunway()
        {
            string rwy_suggested = "";

            switch (App.ATCPosition.Split("_".ToCharArray())[0])
            {
                case "LPPT":
                    if (Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection != "VRB")
                    {
                        if (Convert.ToInt32(Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection) > 120 && Convert.ToInt32(Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection) < 300)
                            rwy_suggested = "suggest Runway 21";
                        else
                            rwy_suggested = "suggest Runway 03";
                    }
                    else
                        rwy_suggested = "suggest Runway 03";

                    break;
            }

            return rwy_suggested;
        }

        public static string GetInitialFL()
        {
            string initial_FL = "";

            switch (App.ATCPosition.Split("_".ToCharArray())[0])
            {
                case "LPPT":
                    initial_FL = "initial FL60";

                    break;
            }

            return initial_FL;
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }
}
