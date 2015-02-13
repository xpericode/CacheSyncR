using XperiCode.CacheSyncR.Core;

namespace XperiCode.CacheSyncR
{
    public interface IServer
    {
        void NotifyDataChanged(DataChange dataChange);
        void NotifyDataChanged<T>(string key, string group);
        void NotifyDataChanged(string type, string key, string group);
    }
}