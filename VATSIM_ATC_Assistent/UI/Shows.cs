using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIM_ATC_Assistent.UI
{
    class Shows
    {
        public Shows()
        {
            switch (App.ATCPosition)
            {
                case "LPPT_DEL":
                    App.mainFrm.tabArrivals.Hide();
                    break;
                case "LPPT_GND":
                    GNDShows();
                    break;

                default:
                    break;
            }
        }

        protected void GNDShows()
        {
            App.mainFrm.btnAliasSendPushStart.Visible = true;
            App.mainFrm.cboxPushStart.Visible = true;
            App.mainFrm.btnPushAndStart.Visible = true;
        }
    }
}
