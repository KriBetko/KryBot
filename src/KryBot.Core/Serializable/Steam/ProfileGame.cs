﻿using System.Xml.Serialization;

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