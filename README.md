## 🎮 CS2 Clantags

Extremely simple plugin to set admin/vip tag to scoreboard. It has english language available for now, but if you want you can translate it to any language.

![GitHub tag (with filter)](https://img.shields.io/github/v/tag/asapverneri/CS2-Clantags?style=for-the-badge&label=Version)

---

## 📦 Installion

- Install [CounterStrike Sharp](https://github.com/roflmuffin/CounterStrikeSharp) & [Metamod:Source](https://www.sourcemm.net/downloads.php/?branch=master)
- Download the latest release from the releases tab and copy it into the counterstrikesharp plugins folder.
The config is generated after the first start of the plugin.

---

## 💻 Usage

Using this plugin is quite simple and straight forward.
To edit tags, commands and permissions please edit config file.
Located in the folder `counterstrikesharp/configs/plugins/Clantags`

**Commands**
- !clantag - Enable/disable clantag

**Example config:**
```json
{
  "ToggleTagEnabled": true,
  "ToggleTagCommand": "css_clantag",
  "ClanTags": [
    {
      "SteamID64": "76561198134597930",
      "Tag": "[SteamID64]"
    },
    {
      "Group": "#css/group",
      "Tag": "[Group]"
    },
    {
      "Flag": "@css/admin",
      "Tag": "[Admin]"
    },
    {
      "Flag": "@css/vip",
      "Tag": "[VIP]"
    },
    {
      "Flag": "",
      "Tag": "[Default]"
    }
  ],
  "ConfigVersion": 1
} 
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

## 💖 Support My Work

<div align="center">
  <a href="https://www.paypal.com/paypalme/PeliluolaCS2">
    <img src="https://img.shields.io/badge/Donate-PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white" alt="Donate via PayPal" />
  </a>
  <a href="https://buy.stripe.com/cN2dThbavflW05G7sz">
    <img src="https://img.shields.io/badge/Donate-Stripe-635BFF?style=for-the-badge&logo=stripe&logoColor=white" alt="Donate via Stripe" />
  </a>
</div>
