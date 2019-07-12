using System;
using System.Collections.Generic;
using System.Text;

namespace PanCardViewSample.Models
{
    class TipsToHappinessModel
    {
        public string image_path { get; set; }
        public int oid { get; set; }
        public List<LinksStruct> LinksStruct { get; set; }
    }

    class LinksStruct
    {
        public string DisplayText { get; set; }
        public string Link { get; set; }
    }
}
