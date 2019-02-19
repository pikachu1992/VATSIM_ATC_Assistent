using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIM_ATC_Assistent.UI
{
    class DELCheckFlightLevelRequested
    {
        public static string GetFlightDirectionFromAltitude(Pilots pilot)
        {
            var pilot_dest = pilot.planned_destairport;

            var airports = Encoding.UTF8.GetString(Properties.Resources.airports).Split("\n".ToCharArray());

            string output = "";

            foreach(var airport in airports)
            {
                var parse_airport = airport.Split(",".ToCharArray());

                if (airport != "")
                {
                    if (parse_airport[5].Replace("\"", "") == pilot_dest)
                    {
                        if (Convert.ToDouble(parse_airport[6].Replace("\"", "").Replace(".", ",")) > App.ATCLocation.Latitude)
                        {
                            try
                            {
                                bool isFloat = Convert.ToInt32(pilot.planned_altitude.Replace(".0", "")).ToString("F0").All(char.IsDigit);
                                if (isFloat)
                                {
                                    if ((Convert.ToInt32(pilot.planned_altitude.Replace(".0", "")) % 2000) != 0)
                                    {
                                        output = "FL have to be EVEN!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.Red;
                                        App.mainFrm.btnGenFIXALT.Visible = true;
                                    }
                                    else
                                    {
                                        output = "FL Correct!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.ForestGreen;
                                        App.mainFrm.btnGenFIXALT.Visible = false;
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                var parse_alt = pilot.planned_altitude.Split("FL".ToCharArray());

                                bool isFloat = (Convert.ToInt32(parse_alt[parse_alt.Count()-1]) * 100).ToString("F0").All(char.IsDigit);
                                if (isFloat)
                                {
                                    if (((Convert.ToInt32(parse_alt[parse_alt.Count()-1]) * 100) % 2000) != 0)
                                    {
                                        output = "FL have to be EVEN!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.Red;
                                        App.mainFrm.btnGenFIXALT.Visible = true;
                                    }
                                    else
                                    {
                                        output = "FL Correct!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.ForestGreen;
                                        App.mainFrm.btnGenFIXALT.Visible = false;
                                    }

                                }
                            }
                        }
                        else
                        {
                            try
                            {
                                bool isFloat = Convert.ToInt32(pilot.planned_altitude.Replace(".0", "")).ToString("F0").All(char.IsDigit);
                                if (isFloat)
                                {
                                    if ((Convert.ToInt32(pilot.planned_altitude.Replace(".0", "")) % 2000) == 0)
                                    {
                                        output = "FL have to be ODD!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.Red;
                                        App.mainFrm.btnGenFIXALT.Visible = true;
                                    }
                                    else
                                    {
                                        output = "FL Correct!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.ForestGreen;
                                        App.mainFrm.btnGenFIXALT.Visible = false;
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                var parse_alt = pilot.planned_altitude.Split("FL".ToCharArray());

                                bool isFloat = (Convert.ToInt32(parse_alt[parse_alt.Count()-1]) * 100).ToString("F0").All(char.IsDigit);
                                if (isFloat)
                                {
                                    if (((Convert.ToInt32(parse_alt[parse_alt.Count() - 1]) * 100) % 2000) == 0)
                                    {
                                        output = "FL have to be ODD!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.Red;
                                        App.mainFrm.btnGenFIXALT.Visible = true;
                                    }
                                    else
                                    {
                                        output = "FL Correct!";
                                        App.mainFrm.lblFlightLevelIsValid.ForeColor = Color.ForestGreen;
                                        App.mainFrm.btnGenFIXALT.Visible = false;
                                    }
                                }
                            }
                        }

                    }
                }

            }
            

            return output;
        }
    }
}
