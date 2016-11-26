using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FamilyPapers.Core
{    
    public class Asset
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string[] Labels { get; set; }
        public bool Tracked { get; set; }
        public string Category { get; set; }
        public string Thumbnail { get; set; }
    }
}
