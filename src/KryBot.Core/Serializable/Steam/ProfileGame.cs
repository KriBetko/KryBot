﻿/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
*/
using System.Xml.Serialization;

namespace KryBot.Core.Serializable.Steam
{
    [XmlRoot(ElementName = "game")]
    public class ProfileGame
    {
        [XmlElement(ElementName = "appID")]
        public string AppId { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }
}