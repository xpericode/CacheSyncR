using System;
using Newtonsoft.Json;

namespace XperiCode.CacheSyncR.Core
{
    public class DataChange
    {
        [JsonConstructor]
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

        [JsonProperty]
        public string Type { get; private set; }
        [JsonProperty]
        public string Key { get; private set; }
        [JsonProperty]
        public string Group { get; private set; }
    }
}
