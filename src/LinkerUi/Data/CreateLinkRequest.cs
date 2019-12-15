namespace LinkerUi.Data
{
    public class CreateLinkRequest
    {
        public LinkEdge Origin { get; }
        public LinkEdge Destination { get; }
        public LinkFilter[] Filters { get; }

        public CreateLinkRequest(LinkEdge origin, LinkEdge destination, LinkFilter[] filters)
        {
            Origin = origin;
            Destination = destination;
            Filters = filters;
        }
    }
}
