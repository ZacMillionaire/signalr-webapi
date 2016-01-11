using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Web.Http;

namespace signalr_webapi.Controllers {

	public abstract class ApiControllerWithHub<THub> : ApiController 	where THub : IHub {
		Lazy<IHubContext> hub = new Lazy<IHubContext>(
			() => GlobalHost.ConnectionManager.GetHubContext<THub>()
		);

		protected IHubContext Hub {
			get { return hub.Value; }
		}
	}

	public class ChatHubWebApiController : ApiControllerWithHub<HubHubHub> {

		[HttpGet]
		[Route("~/MessageClients")]
		public void Message(string IgnoreId = null,string Message = "default message") {
			var subscribed = Hub.Clients;
			if(IgnoreId != null) {
				subscribed.AllExcept(IgnoreId).getMessage(Message);
			} else {
				subscribed.All.getMessage(Message);
			}
		}
	}
}