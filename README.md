## 🎮 CS2 Clantags

Extremely simple plugin to set admin/vip tag to scoreboard. It has english language available for now, but if you want you can translate it to any language.
Tested on Windows, but should work on Linux aswell.

![GitHub tag (with filter)](https://img.shields.io/github/v/tag/asapverneri/CS2-Clantags?style=for-the-badge&label=Version)

> [!NOTE]  
> This plugin is in early state and it's not perfect.

---

## 📦 Installion
> [!CAUTION]
> CSSharp v253 required.

- Install [CounterStrike Sharp](https://github.com/roflmuffin/CounterStrikeSharp) & [Metamod:Source](https://www.sourcemm.net/downloads.php/?branch=master)
- Download the latest release from the releases tab and copy it into the counterstrikesharp plugins folder.
The config is generated after the first start of the plugin.

---

## 💻 Usage

Using this plugin is quite simple and straight forward.
To edit tags, commands and permissions please edit config file.
Located in the folder `counterstrikesharp/configs/plugins/CS2Clantags`

**Commands**
- !tagon - Enable scoreboard tag
- !tagoff - Disable scoreboard tag

**Example config:**
```json

  "Version": 1,
  "TAG_ON_COMMANDS": "css_tagon",
  "TAG_OFF_COMMANDS": "css_tagoff",
  "DEFAULT_TAG": "[PLAYER]", // Make it blank if you dont want default tag
  "VIP_TAG": "[VIP]",
  "VIP_FLAG": "@css/vip",
  "ADMIN_TAG": "[ADMIN]",
  "ADMIN_FLAG": "@css/ban",
  "HEADADMIN_TAG": "[HEAD-ADMIN]",
  "HEADADMIN_FLAG": "@css/cheats",
  "OWNER_TAG": "[OWNER]",
  "OWNER_FLAG": "@css/root",
  "ConfigVersion": 1
  
```
---

## 📫 Contact

<div align="center">
  <a href="https://discordapp.com/users/367644530121637888">
    <img src="https://img.shields.io/badge/Discord-7289DA?style=for-the-badge&logo=discord&logoColor=white" alt="Discord" />
  </a>
  <a href="https://steamcommunity.com/id/vvernerii/">
    <img src="https://img.shields.io/badge/Steam-000000?style=for-the-badge&logo=steam&logoColor=white" alt="Steam" />
  </a>
</div>

---
