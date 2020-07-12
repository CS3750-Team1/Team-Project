﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class WebAPIEvent
    {
        public int id { get; set; }
        public string text { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }

        public static explicit operator WebAPIEvent(CalenderModel ev)
        {
            return new WebAPIEvent
            {
                id = ev.ID,
                text = ev.Name,
                start_date = ev.StartDate.ToString("yyyy-MM-dd HH:mm"),
                end_date = ev.EndDate.ToString("yyyy-MM-dd HH:mm")
            };

        }

        public static explicit operator CalenderModel(WebAPIEvent ev)
        {
            return new CalenderModel
            {
                ID = ev.id,
                Name = ev.text,
                StartDate = DateTime.Parse(ev.start_date,
                    System.Globalization.CultureInfo.InvariantCulture),
                EndDate = DateTime.Parse(ev.end_date,
                    System.Globalization.CultureInfo.InvariantCulture)
            };
        }
    }
}
