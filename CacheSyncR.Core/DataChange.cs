using System;

namespace XperiCode.CacheSyncR.Core
{
    public class DataChange
    {
        public DataChange(string type, string key, string group)
        {
            this.Type = type;
            this.Key = key;
            this.Group = group;
        }

        public DataChange(Type type, string key, string group)
        {
            this.Type = type.FullName;
            this.Key = key;
            this.Group = group;
        }

        public string Type { get; private set; }
        public string Key { get; private set; }
        public string Group { get; private set; }
    }
}
