﻿using Eve;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Threading.Tasks;
using VATSIM_ATC_Assistent.UI;

namespace VATSIM_ATC_Assistent
{
    class GetTrafficFromPosition
    {

        public static List<Pilots> pilotsList { get; set; }

        public delegate void OnClient(List<Pilots> pilots, GeoCoordinate location);
        public static event OnClient onClient;

        public static readonly EveClient FaStatusServer = new EveClient("http://snet.flyatlantic-va.com:5001");

        public static async Task GetClientsByPositionAsync(string position)
        {
            List<Pilots> pilots = await FaStatusServer.GetAsync<Pilots>("clients", false, "{\"clienttype\":\"PILOT\"}");
            List<Pilots> output = new List<Pilots>();

            switch (position)
            {
                case "LPPT_DEL":
                    GeoCoordinate location = new GeoCoordinate(38.7751313, -9.1437917);

                    foreach(var pilot in pilots)
                    {

                        double pilot_lat = Convert.ToDouble(pilot.location[1].Replace(".", ","));
                        double pilot_lng = Convert.ToDouble(pilot.location[0].Replace(".", ","));
                        GeoCoordinate pilot_location = new GeoCoordinate(pilot_lat, pilot_lng);
                        var distance = location.GetDistanceTo(pilot_location) * 0.000539956803;

                        if (distance <= 1000)
                            output.Add(pilot);

                    }

                    onClient(output, location);
                        
                    break;

                default:
                    break;

            }
        }

    }
}