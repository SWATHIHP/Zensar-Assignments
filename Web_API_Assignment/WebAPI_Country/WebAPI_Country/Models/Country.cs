﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Country.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Capital { get; set; }
    }
}