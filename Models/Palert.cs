﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Palert
    {
        /*return item.Id + ' ' + item.Timestring + ' ' + item.Stations + ' ' + item.Hhz + ' ' +
    item.Hhn + ' ' + item.Hhe + ' ' + item.Kztime + ' ' + item.Lat + ' ' + item.Lng + ' ' +
    item.Depth + ' ' + item.Magnitude + ' ' + item.Type + ' ' + item.id + ' ' + item.Date;*/

        public string Id { get; set; }
        public string Timestring { get; set; }
        public string Stations { get; set; }
        public string Hhz { get; set; }
        public string Hhn { get; set; }
        public string Hhe { get; set; }
        public string Kztime { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Depth { get; set; }
        public string Magnitude { get; set; }
        public string Type { get; set; }
        public string id { get; set; }
        public string Date { get; set; }

    }
}