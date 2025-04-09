﻿using System.Text.Json.Serialization;
using ZepLaoSharp.Auth;

namespace ZaloBot
{
    [JsonSerializable(typeof(List<ZaloCookie>))]
    [JsonSerializable(typeof(Config))]
    [JsonSerializable(typeof(AIMessage))]
    [JsonSerializable(typeof(List<AIMessage>))]
    internal partial class SourceGenerationContext : JsonSerializerContext
    {
    }
}
