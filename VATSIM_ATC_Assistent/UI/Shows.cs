﻿using System;
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
                    App.mainFrm.tabMain.TabPages.Remove(App.mainFrm.tabArrivals);
                    break;
                case "LPPT_GND":
                    GNDShows();
                    break;
                case "LPPT_TWR":
                    GNDShows();
                    TWRShows();
                    break;

                default:
                    break;
            }
        }

        protected void GNDShows()
        {
            App.mainFrm.btnGenerateTaxi.Visible = true;
            App.mainFrm.btnPushAndStart.Visible = true;
            App.mainFrm.cboxPushStart.Visible = true;
            App.mainFrm.btnAliasSendPushAndStart.Visible = true;
        }

        protected void TWRShows()
        {
            App.mainFrm.btnClearedTakeOff.Visible = true;
        }
    }
}
