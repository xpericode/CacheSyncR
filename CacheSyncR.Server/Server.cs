using System;
using Microsoft.AspNet.SignalR;
using XperiCode.CacheSyncR.Core;

namespace XperiCode.CacheSyncR
{
    public class Server : IServer
    {
        private readonly IHubContext _hubContext;

        public Server() : this(GlobalHost.ConnectionManager.GetHubContext<CacheSyncRHub>())
        {
        }

        public Server(IHubContext hubContext)
        {
            this._hubContext = hubContext;
        }

        public void NotifyDataChanged(DataChange dataChange)
        {
            _hubContext.Clients.All.DataChanged(dataChange);
        }

        public void NotifyDataChanged<T>(string key, string group)
        {
            NotifyDataChanged(new DataChange(typeof(T), key, group));
        }

        public void NotifyDataChanged(string type, string key, string group)
        {
            NotifyDataChanged(new DataChange(type, key, group));
        }
    }
}
