﻿using SwissTransport.Core;
using SwissTransport.Models;
using System.ComponentModel;

namespace SwissTransportGUI.Controller
{
    public class StationSearch
    {
        private ITransport Transport { get; set; }
        public BindingList<Station> StationSuggestions { get; internal set; }

        public StationSearch()
        {
            Transport = new Transport();

            StationSuggestions = new BindingList<Station>();
        }

        public void GetNewStationSuggestions(string stationNameQuery)
        {
            StationSuggestions.Clear();
            List<Station> stations = Transport.GetStations(stationNameQuery).StationList;
            foreach(Station station in stations)
            {
                StationSuggestions.Add(station);
            }
        }
    }

}
