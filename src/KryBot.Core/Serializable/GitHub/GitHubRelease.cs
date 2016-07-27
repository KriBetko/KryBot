﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace KryBot.Core.Serializable.GitHub
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    [SuppressMessage("ReSharper", "CollectionNeverUpdated.Global")]
    public class GitHubRelease
    {
        [JsonProperty(PropertyName = "tag_name", Required = Required.Always)]
        internal string Tag { get; set; }

        [JsonProperty(PropertyName = "assets", Required = Required.Always)]
        internal List<GitHunReleaseAssets> Assets { get; set; }
    }
}