using System.Collections.Generic;

namespace LinkerUi.Data
{
    public class Link
    {
        public LinkEdge Origin { get; set; }
        public LinkEdge Destination { get; set; }
        public IList<LinkFilter> Filters { get; set; }
        public bool StartWhenReady { get; set; }
        public string Name => $"From {Origin} To {Destination}";
    }
}
