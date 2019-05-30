using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SviGufo.WebApi.Domains
{
    public class LocalizacaoDomain
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("latitude")] // Define como vai ser chamada a chave no mongoDB
        [BsonRequired]
        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}
