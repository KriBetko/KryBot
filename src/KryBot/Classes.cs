﻿using System.Collections.Generic;
using System.Drawing;
using System.Net;
using RestSharp;

namespace KryBot
{
    public class Classes
    {
        public class Bot
        {
            public bool Enabled { get; set; }
            public string Name { get; set; }
            public string UserAgent { get; set; }

            // Steam //
            public bool SteamEnabled { get; set; }
            public string SteamSessid { get; set; }
            public string SteamLogin { get; set; }
            public string SteamRememberLogin { get; set; }
            // Steam //

            // GameMiner //
            public bool GameMinerEnabled { get; set; }
            public string GameMinerToken { get; set; }
            public string GameMinerxsrf { get; set; }
            public int GameMinerCoal { get; set; }
            public int GameMinerLevel { get; set; }
            public int GameMinerJoinCoalLimit { get; set; } = 50;
            public int GameMinerCoalReserv { get; set; }
            public bool GameMinerSandbox { get; set; } = true;
            public bool GameMinerRegular { get; set; } = true;
            public bool GameMinerFreeGolden { get; set; } = true;
            public bool GameMinerOnlyGifts { get; set; }
            public bool GameMinerNoRegion { get; set; }
            // GameMiner //

            // SteamGifts //
            public bool SteamGiftsEnabled { get; set; }
            public bool SteamGiftsGroup { get; set; }
            public bool SteamGiftsRegular { get; set; } = true;
            public bool SteamGiftsWishList { get; set; }
            public bool SteamGiftsSortLevel { get; set; }
            public bool SteamGiftsSortToLessLevel { get; set; }
            public string SteamGiftsPhpSessId { get; set; }
            public int SteamGiftsPoint { get; set; }
            public int SteamGiftsLevel { get; set; }
            public int SteamGiftsJoinPointLimit { get; set; } = 300;
            public int SteamGiftsPointsReserv { get; set; }
            public int SteamGiftsMinLevel { get; set; }
            // StemGifts //

            // SteamCompanion //
            public bool SteamCompanionEnabled { get; set; }
            public bool SteamCompanionRegular { get; set; } = true;
            public bool SteamCompanionWishList { get; set; }
            public bool SteamCompanionGroup { get; set; }
            public bool SteamCompanionAutoJoin { get; set; }
            public string SteamCompanionPhpSessId { get; set; }
            public string SteamCompanionUserId { get; set; }
            public string SteamCompanionUserC { get; set; }
            public string SteamCompanionUserT { get; set; }
            public string SteamCompanionProfileLink { get; set; }
            public int SteamCompanionPoint { get; set; }
            public int SteamCompanionJoinPointLimit { get; set; } = 1500;
            public int SteamCompanionPointsReserv { get; set; }
            // SteamCompanion //

            // SteamPortal //
            public bool SteamPortalEnabled { get; set; }
            public string SteamPortalPhpSessId { get; set; }
            public string SteamPortalProfileLink { get; set; }
            public int SteamPortalPoints { get; set; }
            public int SteamPortalMaxJoinValue { get; set; } = 30;
            public int SteamPortalPointsReserv { get; set; }
            // SteamPortal //

            // GameAways //
            public bool GameAwaysEnabled { get; set; }
            public bool GameAwaysWishList { get; set; }
            public bool GameAwaysGroup { get; set; }
            public string GameAwaysPhpSessId { get; set; }
            public string GameAwaysProfileLink { get; set; }
            public int GameAwaysPoints { get; set; }
            public int GameAwaysMaxJoinValue { get; set; } = 10000;
            public int GameAwaysPointsReserv { get; set; }
            // GameAways //

            // SteamTrade //
            public bool SteamTradeEnabled { get; set; }
            public string SteamTradePhpSessId { get; set; }
            public string SteamTradeDleUserId { get; set; }
            public string SteamTradeDlePassword { get; set; }
            public string SteamTradePassHash { get; set; }
            // SteamTrade //

            // PlayBlink //
            public bool PlayBlinkEnabled { get; set; }
            public string PlayBlinkPhpSessId { get; set; }
            public int PlayBlinkPoints { get; set; }
            public int PlayBlinkLevel { get; set; }
            public int PlayBlinkMaxJoinValue { get; set; } = 50;
            public int PlayBlinkPointReserv { get; set; } = 0;
            // PlayBlink //
        }

        public class Response
        {
            public CookieContainer Cookies { get; set; }
            public IRestResponse RestResponse { get; set; }
        }

        public class Log
        {
            public string Content { get; set; }
            public Color Color { get; set; }
            public bool Success { get; set; }
            public bool Echo { get; set; }
        }

        public class Settings
        {
            public bool LogActive { get; set; }
            public string Lang { get; set; }
            public bool Sort { get; set; }
            public bool SortToMore { get; set; }
            public bool SortToLess { get; set; }
            public bool Timer { get; set; }
            public bool Autorun { get; set; }
            public bool ShowWonTip { get; set; }
            public bool ShowFarmTip { get; set; }
            public bool FullLog { get; set; }
            public bool WishlistSort { get; set; }
            public int TimerInterval { get; set; }
            public int TimerLoops { get; set; }
        }

        // GitHub //
        public class GitHubRelease
        {
            public string tag_name { get; set; }
            public bool prerelease { get; set; }
            public List<GitHunReleaseAssets> assets { get; set; }
            public string body { get; set; }
        }

        public class GitHunReleaseAssets
        {
            public string name { get; set; }
            public int size { get; set; }
            public string browser_download_url { get; set; }
        }
        // GitHub//
    }
}