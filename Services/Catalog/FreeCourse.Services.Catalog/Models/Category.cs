﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] //Id olduğunu mongoDb'ye bu şekilde aktarıyoruz.
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
