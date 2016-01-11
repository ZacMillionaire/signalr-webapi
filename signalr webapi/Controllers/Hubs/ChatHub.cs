using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace signalr_webapi.Controllers {
	//[HubName("ChatHub")]
	public class HubHubHub : Hub {
		public void Connect() {
			Clients.Caller.onConnected(Context.ConnectionId + " has connected."); // clientside JS listener
		}
	}
}