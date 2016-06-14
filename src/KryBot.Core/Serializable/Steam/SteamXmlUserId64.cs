﻿using System.Xml.Serialization;

namespace KryBot.Core.Json.Steam
{
	[XmlRoot(ElementName = "profile")]
	public class Profile
	{
		[XmlElement(ElementName = "steamID64")]
		public string SteamID64 { get; set; }
	}
}