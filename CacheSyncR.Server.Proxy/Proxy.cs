using System;
using XperiCode.CacheSyncR.Core;

namespace XperiCode.CacheSyncR
{
    public class Proxy
    {
        public static void Connect(string url)
        {
            Client.Connect(url, (DataChange dataChange) =>
                {
                    IServer server = new Server();
                    server.NotifyDataChanged(dataChange);
                });
        }
    }
}
