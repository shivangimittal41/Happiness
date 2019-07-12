using System;
using System.Collections.Generic;
using System.Text;

namespace PanCardViewSample.Models
{
    class HappinessTools
    {      
        public string image_path { get; set; }
        public int oid { get; set; }
        public List<LinksStructr> LinksStructr { get; set; }
    }

    class LinksStructr
    {
        public string DisplayText { get; set; }
        public string Link { get; set; }
    }
}