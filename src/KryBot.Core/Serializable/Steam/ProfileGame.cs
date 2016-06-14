﻿using System.Xml.Serialization;

namespace KryBot.Core.Json.Steam
{
	[XmlRoot(ElementName = "game")]
	public class ProfileGame
	{
		[XmlElement(ElementName = "appID")]
		public string AppID { get; set; }

		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
	}
}