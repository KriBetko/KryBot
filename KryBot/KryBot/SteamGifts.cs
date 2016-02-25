﻿namespace KryBot
{
    public class SteamGifts
    {
        public class SgGiveaway
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Code { get; set; }
            public string Token { get; set; }
            public string Link { get; set; }
        }

        public class JsonResponse
        {
            public string Type { get; set; }
            public string EntryCount { get; set; }
            public int Points { get; set; }
        }
    }
}