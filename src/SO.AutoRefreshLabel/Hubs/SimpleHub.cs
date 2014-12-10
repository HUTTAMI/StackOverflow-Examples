using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SO.AutoRefreshLabel.Hubs
{
    /// <summary>
    /// You could create server-side methods here, but we're simply defining this so we
    /// can access it within the ~/Jobs/SimpleJob.cs file.
    /// </summary>
    [HubName("SimpleHub")]
    public class SimpleHub : Hub
    {
    }
}