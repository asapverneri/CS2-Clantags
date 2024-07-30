using CounterStrikeSharp.API.Core;
using System.Text.Json.Serialization;

namespace Clantags
{
    public class ClantagsConfig : BasePluginConfig
    {
        public override int Version { get; set; } = 1;

        [JsonPropertyName("TAG_ON_COMMANDS")]
        public string Tagoncommands { get; set; } = "css_tagon";

        [JsonPropertyName("TAG_OFF_COMMANDS")]
        public string Tagoffcommands { get; set; } = "css_tagoff";

        [JsonPropertyName("DEFAULT_TAG")]
		public string Defaulttag { get; set; } = "[PLAYER]";

        [JsonPropertyName("VIP_TAG")]
        public string Viptag { get; set; } = "[VIP]";

        [JsonPropertyName("VIP_FLAG")]
        public string Vipflag { get; set; } = "@css/vip";

        [JsonPropertyName("ADMIN_TAG")]
        public string Admintag { get; set; } = "[ADMIN]";

        [JsonPropertyName("ADMIN_FLAG")]
        public string Adminflag { get; set; } = "@css/ban";

        [JsonPropertyName("HEADADMIN_TAG")]
        public string Headadmintag { get; set; } = "[HEAD-ADMIN]";

        [JsonPropertyName("HEADADMIN_FLAG")]
        public string Headadminflag { get; set; } = "@css/cheats";

        [JsonPropertyName("OWNER_TAG")]
        public string Ownertag { get; set; } = "[OWNER]";

        [JsonPropertyName("OWNER_FLAG")]
        public string Ownerflag { get; set; } = "@css/root";

    }
}
