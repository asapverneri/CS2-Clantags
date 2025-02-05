using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using Microsoft.Extensions.Logging;
using CSSharpUtils.Extensions;
using CounterStrikeSharp.API.Modules.Admin;

namespace Clantags;

[MinimumApiVersion(292)]
public class Clantags : BasePlugin, IPluginConfig<ClantagsConfig>
{
    public override string ModuleName => "Clantags";
    public override string ModuleDescription => "Set clantags using flags & steamid";
    public override string ModuleAuthor => "verneri";
    public override string ModuleVersion => "1.1";

    private HashSet<ulong> Tagtoggle = new HashSet<ulong>();
    public ClantagsConfig Config { get; set; } = new();

    public void OnConfigParsed(ClantagsConfig config)
	{
        Config = config;
    }

    public override void Load(bool hotReload)
    {
        Logger.LogInformation($"Loaded (version {ModuleVersion})!");
        AddCommand($"{Config.ToggleTagCommand}", "Toggle tags on command", ToggleTag);
    }

    [GameEventHandler]
    public HookResult OnPlayerConnectFull(EventPlayerConnectFull @event, GameEventInfo info)
    {
        if (@event == null) return HookResult.Continue;
        var player = @event.Userid;
        if(player == null || !player.IsValid) return HookResult.Continue;

        Setclantags(player);
        Tagtoggle.Add(player.SteamID);

        return HookResult.Continue;
    }

    private void Setclantags(CCSPlayerController player)
    {
        foreach (var clantag in Config.ClanTags)
        {
            if (!string.IsNullOrEmpty(clantag.SteamID64) && player.SteamID.ToString() == clantag.SteamID64)
            {
                //Logger.LogInformation($"Player {player.SteamID} matches SteamID64 tag: {clantag.Tag}. Leave it.");
                player.SetClantag(clantag.Tag);
                break;
            }
            else if (!string.IsNullOrEmpty(clantag.Flag) && AdminManager.PlayerHasPermissions(player, clantag.Flag))
            {
                //Logger.LogInformation($"Player {player.SteamID} matches flag tag: {clantag.Tag}. Leave it.");
                player.SetClantag(clantag.Tag);
                break;
            }
        }
    }

    public void ToggleTag(CCSPlayerController? player, CommandInfo command)
    {
        if (!player.IsPlayer())
            return;
        if (player == null) return;

        if (Tagtoggle.Contains(player.SteamID))
        {
            player.SetClantag();
            Tagtoggle.Remove(player.SteamID);
            player.PrintToChat($"{Localizer["clantag.off"]}");
            //Logger.LogInformation($"Player {player.PlayerName} disabled clantag.");
        }
        else
        {
            Setclantags(player);
            Tagtoggle.Add(player.SteamID);
            player.PrintToChat($"{Localizer["clantag.on"]}");
            //Logger.LogInformation($"Player {player.PlayerName} enabled clantag.");
        }

    }
}