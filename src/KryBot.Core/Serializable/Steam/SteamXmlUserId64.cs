﻿using System.Xml.Serialization;

namespace KryBot.Core.Serializable.Steam
{
    [XmlRoot(ElementName = "profile")]
    public class Profile
    {
        [XmlElement(ElementName = "steamID64")]
        public string SteamId64 { get; set; }
    }
}