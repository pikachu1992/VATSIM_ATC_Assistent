using System.Windows.Forms;

namespace VATSIM_ATC_Assistent.UI
{
    class Taxiways
    {
        public static void AddTaxiways()
        {
            App.mainFrm.CreateControl();
            App.mainFrm.layPanelTaxiways.FlowDirection = FlowDirection.LeftToRight;

            switch (App.ATCPosition.Split("_".ToCharArray())[0])
            {
                case "LPPT":
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "A", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "B", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "C", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "D", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "E", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "F", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "G", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "J", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "K", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "L", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "M", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "N", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "P", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "Q", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "R", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "S", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "V", Dock = DockStyle.Top, Width = 32 });
                    App.mainFrm.layPanelTaxiways.Controls.Add(new CheckBox { Text = "Z", Dock = DockStyle.Top, Width = 32 });
                    break;
            }
        }
    }
}
