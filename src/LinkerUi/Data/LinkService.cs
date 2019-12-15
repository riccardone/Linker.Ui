using System.Threading.Tasks;

namespace LinkerUi.Data
{
    public class LinkService
    {
        public async Task<Link[]> GetLinksAsync()
        {
            return await Task.FromResult(new Link[]
            {
                new Link
                {
                    Destination = new LinkEdge
                    {
                        ConnectionName = "test-destination", ConnectionString = "tcp://localhost:2112",
                        Pass = "changeit", User = "admin"
                    },
                    Origin = new LinkEdge
                    {
                        ConnectionName = "test-origin", ConnectionString = "tcp://localhost:1112", Pass = "changeit",
                        User = "admin"
                    },
                    Filters = null,
                    StartWhenReady = true
                }
            });
        }

        public async Task CreateLink(CreateLinkRequest request)
        {
            // TODO
        }
    }
}
