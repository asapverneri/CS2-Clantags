using CounterStrikeSharp.API.Core;
using System.Text.Json.Serialization;

namespace Clantags
{
    public class ClantagsConfig : BasePluginConfig
    {
        [JsonPropertyName("ToggleTagEnabled")]
        public bool ToggleTagEnabled { get; set; } = true;
        [JsonPropertyName("ToggleTagCommand")]
        public string ToggleTagCommand { get; set; } = "css_clantag";

        [JsonPropertyName("ClanTags")]
        public List<ClanTag> ClanTags { get; set; } = new List<ClanTag>
        {
        new ClanTag
        {
            SteamID64 = "76561198134597930",
            Tag = "[SteamID64]"
        },
        new ClanTag
        {
            Group = "#css/group",
            Tag = "[Group]"
        },
        new ClanTag
        {
            Flag = "@css/admin",
            Tag = "[Admin]"
        },
        new ClanTag
        {
            Flag = "@css/vip",
            Tag = "[VIP]"
        },
        new ClanTag
        {
            Flag = "",
            Tag = "[Default]"
        }
        };

    }

    public class ClanTag
    {
        [JsonPropertyName("Flag")]
        public string Flag { get; set; } = string.Empty;


        [JsonPropertyName("Group")]
        public string Group { get; set; } = string.Empty;

        [JsonPropertyName("SteamID64")]
        public string SteamID64 { get; set; } = string.Empty;

        [JsonPropertyName("Tag")]
        public string Tag { get; set; } = string.Empty;
    }
}
