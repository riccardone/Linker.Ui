namespace LinkerUi.Data
{
    public class LinkFilter
    {
        public FilterType FilterType { get; set; }
        public string Value { get; set; }
        public FilterOperation FilterOperation { get; set; }
    }
    public enum FilterOperation
    {
        Include,
        Exclude
    }

    public enum FilterType
    {
        Stream,
        EventType
    }
}
