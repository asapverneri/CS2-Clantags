using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Core.Translations;
using CounterStrikeSharp.API.Modules.Commands;
using Microsoft.Extensions.Logging;
using CSSharpUtils.Extensions;
using CounterStrikeSharp.API.Modules.Admin;
using System.Xml.Linq;

namespace Clantags;

[MinimumApiVersion(253)]
public class Clantags : BasePlugin, IPluginConfig<ClantagsConfig>
{
    public override string ModuleName => "CS2 Clantags";
    public override string ModuleDescription => "Set clantags using css flags";
    public override string ModuleAuthor => "verneri";
    public override string ModuleVersion => "1.0.0";

    public ClantagsConfig Config { get; set; } = new();

    public void OnConfigParsed(ClantagsConfig config)
	{
        Config = config;
    }

    public override void Load(bool hotReload)
    {
        Logger.LogInformation($"[{ModuleName}] Loaded (version {ModuleVersion})!");
        AddCommand($"{Config.Tagoncommands}", "Toggle tags on command", OnCommandtags);
        AddCommand($"{Config.Tagoffcommands}", "Toggle tags off command", OnCommandremovetag);
    }

    private void SetDefaultTag(CCSPlayerController playerController)
    {
        if (!playerController.IsPlayer())
            return;
        playerController.SetClantag(Config.Defaulttag);
    }
    private void SetVipTag(CCSPlayerController playerController)
    {
        if (!playerController.IsPlayer())
            return;
        playerController.SetClantag(Config.Viptag);
    }
    private void SetAdminTag(CCSPlayerController playerController)
    {
        if (!playerController.IsPlayer())
            return;
        playerController.SetClantag(Config.Admintag);
    }
    private void SetHeadadminTag(CCSPlayerController playerController)
    {
        if (!playerController.IsPlayer())
            return;
        playerController.SetClantag(Config.Headadmintag);
    }
    private void SetOwnerTag(CCSPlayerController playerController)
    {
        if (!playerController.IsPlayer())
            return;
        playerController.SetClantag(Config.Ownertag);
    }

    private void Removetag(CCSPlayerController playerController)
    {
        if (!playerController.IsPlayer())
            return;
        playerController.SetClantag();
    }


    public void OnCommandtags(CCSPlayerController? playerController, CommandInfo command)
    {
        if (!playerController.IsPlayer()) return;

        if (!AdminManager.PlayerHasPermissions(playerController, Config.Vipflag))
        {
            SetDefaultTag(playerController);
            command.ReplyToCommand($"{Localizer["default.tag", Config.Defaulttag]}");
            return;
        }else if (!AdminManager.PlayerHasPermissions(playerController, Config.Adminflag))
        {
            SetVipTag(playerController);
            command.ReplyToCommand($"{Localizer["vip.tag", Config.Viptag]}");
            return;
        }
        else if (!AdminManager.PlayerHasPermissions(playerController, Config.Headadminflag))
        {
            SetAdminTag(playerController);
            command.ReplyToCommand($"{Localizer["admin.tag", Config.Admintag]}");
            return;
        }
        else if (!AdminManager.PlayerHasPermissions(playerController, Config.Ownerflag))
        {
            SetHeadadminTag(playerController);
            command.ReplyToCommand($"{Localizer["headadmin.tag", Config.Headadmintag]}");
            return;
        }else
        {
            SetOwnerTag(playerController);
            command.ReplyToCommand($"Ownertag applied");
            command.ReplyToCommand($"{Localizer["owner.tag", Config.Ownertag]}");
            return;
        }


    }

    public void OnCommandremovetag(CCSPlayerController? playerController, CommandInfo command)
    {
        if (!playerController.IsPlayer()) return;
        Removetag(playerController);
        command.ReplyToCommand($"{Localizer["tag.removed"]}");

    }
}