﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codaxy.Dextop.Showcase.Models
{
    public class DextopAppConfig
    {
        public String[] JsFiles { get; set; }
        public String[] CssFiles { get; set; }		
        public HtmlString SessionConfig { get; set; }
    }
}