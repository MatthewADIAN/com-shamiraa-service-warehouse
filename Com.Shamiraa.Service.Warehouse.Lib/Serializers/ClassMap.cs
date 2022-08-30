﻿using MongoDB.Bson.Serialization;

namespace Com.Shamiraa.Service.Warehouse.Lib.Serializers
{
    public class ClassMap<TViewModel>
    {
        public static void Register()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(TViewModel)))
            {
                BsonClassMap.RegisterClassMap<TViewModel>(cm =>
                {
                    cm.AutoMap();
                    cm.SetIgnoreExtraElements(true);
                });
            }
        }
    }
}
