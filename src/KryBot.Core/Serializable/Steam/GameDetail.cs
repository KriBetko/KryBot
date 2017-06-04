﻿/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
*/
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace KryBot.Core.Serializable.Steam
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class GameDetail
    {
        [JsonProperty(PropertyName = "success", Required = Required.Always)]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "data", Required = Required.Always)]
        public GameDetailData Data { get; set; }
    }
}