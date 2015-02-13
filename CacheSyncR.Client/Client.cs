using Microsoft.AspNet.SignalR.Client;
using System;
using System.Threading;
using XperiCode.CacheSyncR.Core;

namespace XperiCode.CacheSyncR
{
    public class Client
    {
        public static void Connect(string url, Action<DataChange> onDataChanged)
        {
            var hubConnection = new HubConnection(url);
            hubConnection.Closed += () =>
                {
                    Thread.Sleep(5000);
                    hubConnection.Start();
                };

            var configHubProxy = hubConnection.CreateHubProxy("CacheSyncRHub");
            configHubProxy.On("DataChanged", onDataChanged);

            hubConnection.Start();
        }
    }
}
