using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TwitterListenerPlus
{
    [Serializable]
    public class Tweet
    {
        public Tweet() { }

        
        public Tweet(DateTime created_at, string idStr, string text, string lang)
        {
            this.created_at = created_at;
            this.idStr = idStr;
            this.text = text;
            this.lang = lang;
        }

        [BsonElement("created_at")]
        public DateTime created_at { get; set; }

        [BsonElement("idStr")]
        public string idStr { get; set; }

        [BsonElement("text")]
        public string text { get; set; }

        [BsonElement("lang")]
        public string lang { get; set; }
    }
}
