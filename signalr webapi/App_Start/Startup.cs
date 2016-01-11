using Microsoft.Owin;
using Owin;
using signalr_webapi.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(Startup))]
namespace signalr_webapi.App_Start {
	public class Startup {
		public void Configuration(IAppBuilder app) {
			app.MapSignalR();
		}
	}
}