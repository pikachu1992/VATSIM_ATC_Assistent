using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using VATSIM_ATC_Assistent.UI;

namespace VATSIM_ATC_Assistent
{
    public partial class MainFrm : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public MainFrm()
        {
            InitializeComponent();
            Start();
            PopulatePilotsList(App.Pilots);

        }

        private void PopulatePilotsList(List<Pilots> pilots)
        {
            foreach(var pilot in pilots)
            {
                if (pilot.planned_destairport != null)
                {
                    if (pilot.planned_destairport.Replace("\"", "") != App.ATCPosition.Split("_".ToCharArray())[0])
                    {
                        lstDeparturePilots.Items.Add(new ListViewItem(new string[]{
                                        pilot.callsign.ToString()
                                         }));
                        lstDeparturePilots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lstDeparturePilots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
        }

        public void Start()
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, "EuroScope V3.1d");
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                //SendKeys.SendWait("^+({HOME})");
                //SendKeys.SendWait("{DEL}");
                //SendKeys.SendWait(".vis2 lppt");
                //SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
            }
        }

        private void DisableAliasBtns()
        {
            btnAliasSendClearance.Enabled = false;
        }

        private void lstDeparturePilots_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.mainFrm.gboxDepartures.Visible = true;
            cboxSID.SelectedIndex = 0;
            lblClearance.Text = "";
            DisableAliasBtns();

            if (lstDeparturePilots.SelectedItems.Count > 0) {
                foreach(var pilot in App.Pilots)
                {
                    
                    
                    if (pilot.callsign == lstDeparturePilots.SelectedItems[0].Text)
                    {
                        lblCallsign.Text = pilot.callsign;
                        lblRoute.Text = pilot.planned_route;
                        if (pilot.planned_altitude != null)
                        {
                            try
                            {
                                bool isFloat = Convert.ToInt32(pilot.planned_altitude.Replace(".0", "")).ToString("F0").All(char.IsDigit);
                                if (isFloat)
                                    lblFlightLevel.Text = String.Format("FL{0}", (Convert.ToInt32(pilot.planned_altitude.Replace(".0", "")) / 100).ToString("F0"));
                            }
                            catch (Exception ex)
                            {
                                lblFlightLevel.Text = pilot.planned_altitude;
                            }
                        }
                        else
                            lblFlightLevel.Text = "";

                        if (pilot.planned_depairport != null)
                            lblDeparture.Text = pilot.planned_depairport;
                        else
                            lblDestination.Text = "";

                        if (pilot.planned_destairport != null)
                            lblDestination.Text = pilot.planned_destairport;
                        else
                            lblDestination.Text = "";

                        lblFlightLevelIsValid.Text = DELCheckFlightLevelRequested.GetFlightDirectionFromAltitude(pilot);
                    }
                    
                }
            }
        }

        private void btnGenerateClearance_Click(object sender, EventArgs e)
        {
            bool haveATIS = false;

            if (txtSquawk.Text.Length != 4)
                MessageBox.Show("Squawk Invalid");
            else
            {
                string dest = lblDestination.Text;
                string sid = "";
                string squawk = txtSquawk.Text;

                if(cboxSID.SelectedItem != "NONE")
                {
                    
                }
                else
                {
                    sid = "After departure fly runway HDG";
                }

                foreach (var atc in App.ATCS)
                {
                    if(atc.callsign == App.ATCPosition.Split("_".ToCharArray())[0] + "_ATIS")
                    {
                        haveATIS = true;
                    }
                }

                if (haveATIS)
                    lblClearance.Text = String.Format("Information XX is current, Cleared to {0}, {1}, initial climb FL60, squawk {2}.", dest, sid, squawk);
                else
                {
                    string wind_info = "";

                    if(Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindGust != "")
                        wind_info = String.Format("Winds {0} degrees {1} knots gusts {2} knots", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection, Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindSpeed, Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindGust);
                    else
                        wind_info = String.Format("Winds {0} degrees {1} knots", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection, Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindSpeed);

                    string rwy_suggested = "";

                    string initial_FL = "";

                    switch (App.ATCPosition.Split("_".ToCharArray())[0])
                    {
                        case "LPPT":
                            if (Convert.ToInt32(Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection) > 120 && Convert.ToInt32(Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).WindDirection) < 300)
                                rwy_suggested = "suggest Runway 21";
                            else
                                rwy_suggested = "suggest Runway 03";

                            initial_FL = "initial climb FL60";
                            break;
                    }

                    string qnh = Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).Altimeter;

                    lblClearance.Text = String.Format("{0}, {1}, QNH{2}. Cleared to {3}, {4}, {5}, squawk {6}.", wind_info, rwy_suggested, qnh, dest, sid, initial_FL, squawk);
                }

                btnAliasSendClearance.Enabled = true;
            }
        }

        private void btnAliasSendClearance_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, "EuroScope V3.1d");
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(lblClearance.Text);
                SendKeys.Flush();
            }
        }

        private void btnPushStart_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Metars.GetMetars(App.ATCPosition.Split("_".ToCharArray())[0]));
            lblPushStart.Text = String.Format("Push and Start approved facing {0}, {0}", Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).Altimeter);
        }
    }
}
