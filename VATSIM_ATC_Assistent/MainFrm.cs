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
            Console.WriteLine("Populate Departure List...");
            PopulatePilotsList(App.Pilots);
            cboxTransferATC.SelectedIndex = 0;
            lblMetar.Text = Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).RawReport;


        }

        public void PopulatePilotsList(List<Pilots> pilots)
        {
            lstDeparturePilots.Items.Clear();
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
                    else
                    {
                        lstArrivalPilots.Items.Add(new ListViewItem(new string[]{
                                        pilot.callsign.ToString()
                                         }));
                        lstArrivalPilots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lstArrivalPilots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
        }

        private void DisableAliasBtns()
        {
            btnAliasSendClearance.Enabled = false;
            btnAliasSendPushAndStart.Enabled = false;
            btnAliasSendFIXALT.Visible = false;
            btnAliasSendTransferATC.Enabled = false;
            btnAliasSendTaxi.Enabled = false;
            btnARRAliasTransferATC.Enabled = false;
        }

        private void lstDeparturePilots_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.mainFrm.gboxDepartures.Visible = true;
            cboxSID.SelectedIndex = 0;
            lblTransfer.Text = "";
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
            string ATISmessage = "";
         
            bool haveATIS = false;

            if (txtSquawk.Text.Length != 4)
                MessageBox.Show("Squawk Invalid");
            else
            {
                btnGenerateClearance.Enabled = false;
                string dest = lblDestination.Text;
                string sid = "";
                string squawk = txtSquawk.Text;
                string infoATIS = "";

                if (cboxSID.SelectedItem != "NONE")
                {
                    sid = cboxSID.SelectedItem.ToString();
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
                        ATISmessage = atc.atis_message;
                    }
                }

                if (haveATIS)
                {
                    infoATIS = ManageStringCommands.GetAtisInfoLetter(ATISmessage);

                    lblTransfer.Text = String.Format("Information {0} is current. Cleared to {1}, {2}, initial climb FL60, squawk {3}.", infoATIS, dest, sid, squawk);
                }
                else
                {
                    string wind_info = ManageStringCommands.GetWindsString();

                    string rwy_suggested = ManageStringCommands.GetSuggestedRunway();

                    string initial_FL = ManageStringCommands.GetInitialFL();

                    string qnh = Metars.Metar(App.ATCPosition.Split("_".ToCharArray())[0]).Altimeter;

                    lblTransfer.Text = String.Format("{0}, {1}, QNH{2}. Cleared to {3}, {4}, {5}, squawk {6}.", wind_info, rwy_suggested, qnh, dest, sid, initial_FL, squawk);
                }

                btnGenerateClearance.Enabled = true;
                btnAliasSendClearance.Enabled = true;
            }
        }

        private void btnAliasSendClearance_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, App.ESVersion);
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(lblTransfer.Text);
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
                btnAliasSendClearance.Enabled = false;
                lblTransfer.Text = "Sended to EuroScope";
            }
        }

        private void btnPushStart_Click(object sender, EventArgs e)
        {
            lblTransfer.Text = String.Format("Push and Start approved facing {0}, Squawk mode C", cboxPushStart.SelectedItem);
            btnAliasSendPushAndStart.Enabled = true;
        }

        private void btnAliasSendPushAndStart_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, App.ESVersion);
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(lblTransfer.Text);
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
                btnPushAndStart.Enabled = false;
                lblTransfer.Text = "Sended to EuroScope";
            }
            
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            switch (cboxTransferATC.SelectedItem)
            {
                case "UNICOM":
                    switch (App.ATCPosition)
                    {
                        case "LPPT_DEL":
                            lblTransfer.Text = "No More Available ATC, Monitor UNICOM on frequency 122.800, Have a nice flight!";
                            break;

                        case "LPPT_GND":
                            lblTransfer.Text = "No More Available ATC, Monitor UNICOM on frequency 122.800, Have a nice flight!";
                            break;

                        case "LPPT_TWR":
                            lblTransfer.Text = "No More Available ATC, Monitor UNICOM on frequency 122.800, Have a nice flight!";
                            break;

                        default:
                            lblTransfer.Text = "No More Available ATC, Radar Services terminated. Monitor UNICOM on frequency 122.800, Have a nice flight!";
                            break;
                    }
                    break;
            }

            btnAliasSendTransferATC.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            GetTrafficFromPosition.GetClientsByPositionAsync(App.ATCPosition);
            GetATCs.GetClientsByPositionAsync();
        }

        private void btnAliasSendTransferATC_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, App.ESVersion);
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(lblTransfer.Text);
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
                btnPushAndStart.Enabled = false;
                lblTransfer.Text = "Sended to EuroScope";
            }

            btnAliasSendTransferATC.Enabled = false;
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainFrm_VisibleChanged(object sender, EventArgs e)
        {
            StartFuncs();      
        }

        private void StartFuncs()
        {
            Taxiways.AddTaxiways();
            Runways.GetRunways();
        }

        private void btnGenFIXALT_Click(object sender, EventArgs e)
        {
            lblTransfer.Text = String.Format("For your destination we need {0} altitude to approve your flight plan. Suggest FL{1} or FL{2}, report altitude requested",
                                        ManageStringCommands.getBetween(lblFlightLevelIsValid.Text, "be ", "!"),
                                        (Convert.ToInt32(lblFlightLevel.Text.Split("FL".ToCharArray())[lblFlightLevel.Text.Split("FL".ToCharArray()).Count() - 1]) - 10),
                                        (Convert.ToInt32(lblFlightLevel.Text.Split("FL".ToCharArray())[lblFlightLevel.Text.Split("FL".ToCharArray()).Count() - 1]) + 10));

            btnAliasSendFIXALT.Visible = true;
        }

        private void lblTransfer_TextChanged(object sender, EventArgs e)
        {
            DisableAliasBtns();
        }

        private void btnAliasSendFIXALT_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, App.ESVersion);
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(lblTransfer.Text);
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
                btnPushAndStart.Enabled = false;
                lblTransfer.Text = "Sended to EuroScope";
            }

            btnAliasSendFIXALT.Visible = false;
        }

        private void btnGenerateTaxi_Click(object sender, EventArgs e)
        {
            List<string> taxies = new List<string>();
            string output = "";

            foreach(CheckBox item in layPanelTaxiways.Controls)
            {
                if(item.Checked)
                    taxies.Add(item.Text);
            }

            foreach(var item in taxies)
            {
                if (item == taxies[taxies.Count - 1])
                    output += "and " + item;
                else
                    output += item + ", ";
            }

            if(chkbox35.Checked)
                lblTransfer.Text = String.Format("Taxi holding point runway {0}, via {1}, cross runway 35 approved.", cboxRunways.SelectedText, output);
            else
                lblTransfer.Text = String.Format("Taxi holding point runway {0}, via {1}.", cboxRunways.SelectedText, output);
        }

        private void btnAliasSendTaxi_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, App.ESVersion);
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(lblTransfer.Text);
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
                btnPushAndStart.Enabled = false;
                lblTransfer.Text = "Sended to EuroScope";
            }

            btnAliasSendTaxi.Enabled = false;
        }

        private void genTransferATCARR_Click(object sender, EventArgs e)
        {
            switch (cboxTransferATC.SelectedItem)
            {
                case "UNICOM":
                    switch (App.ATCPosition)
                    {
                        case "LPPT_GND":
                            lblARRTransfer.Text = "Frequency changed approved, thank you for your flight!";
                            break;

                        case "LPPT_TWR":
                            lblARRTransfer.Text = "Frequency changed approved, thank you for your flight!";
                            break;

                    }
                    break;
            }

            btnARRAliasTransferATC.Enabled = true;
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            DisableAliasBtns();
        }

        private void btnARRAliasTransferATC_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, App.ESVersion);
            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait(lblARRTransfer.Text);
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
                btnPushAndStart.Enabled = false;
                lblARRTransfer.Text = "Sended to EuroScope";
            }

            btnAliasSendTransferATC.Enabled = false;
        }

        private void lstArrivalPilots_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.mainFrm.gboxArrivals.Visible = true;
            lblARRTransfer.Text = "";
            DisableAliasBtns();

            if (lstArrivalPilots.SelectedItems.Count > 0)
            {
                foreach (var pilot in App.Pilots)
                {


                    if (pilot.callsign == lstArrivalPilots.SelectedItems[0].Text)
                    {
                        lblARRCallsign.Text = pilot.callsign;
                        lblARRRoute.Text = pilot.planned_route;

                        if (pilot.planned_depairport != null)
                            lblArrDEP.Text = pilot.planned_depairport;
                        else
                            lblArrDEP.Text = "";

                        if (pilot.planned_destairport != null)
                            lblArrARR.Text = pilot.planned_destairport;
                        else
                            lblArrARR.Text = "";

                    }

                }
            }
        }
    }
}
