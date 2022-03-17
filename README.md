<p align="right">
  Ler em <a href="README.pt-br.md"> Português do Brasil </a>
</p>

# GLogger - A handy logger for Unity

The GLogger package allows you to add and object into your hierarchy wich will handle logging messages for you allowing you to turn logging On and Off as well as choosing messages colors.

## How to video

Checkout the youtube video i've made to explain you how to use it (Pt-BR spoken)

[![IMAGE ALT TEXT HERE](https://i.ibb.co/HttVn5Q/thumbnail.png)](https://www.youtube.com/watch?v=UGMKJ--jRqQ)

## Installing

1. Open package manager
2. Click on plus button and "Add package from git URL"
3. Paste https://github.com/indiegabo/GLogger.git and click Add
4. Wait for Package manager install package

## How to Use

1. Right click on Hierarchy panel and chose GLogger -> GLog
2. Choose your colors
3. Log a message through code!

##### Turn On and OFF

## Logging Messages

##### Default Message

```csharp
GLog.I?.Log("Less boring log message. But still boring");
```

##### Success Message

```csharp
GLog.I?.Success("Hurray! It is good");
```

##### Warning Message

```csharp
GLog.I?.Warning("Carefull! Something is going bad");
```

##### Danger Message

```csharp
GLog.I?.Danger("Ooops. Not good =/");
```

## Snippets

Well let me give you some handy snippets so you can tell your code editor how to help you using this in your code

##### For VSCode

```json
{
  "GLog": {
    "scope": "csharp",
    "prefix": ["glog", "log"],
    "body": ["GLog.I?.Log(\\$\"\");"],
    "description": "A default GLog message"
  },
  "Success GLog": {
    "scope": "csharp",
    "prefix": ["success", "log"],
    "body": ["GLog.I?.Success(\\$\"\");"],
    "description": "A success GLog message"
  },
  "Warning GLog": {
    "scope": "csharp",
    "prefix": ["warning", "log"],
    "body": ["GLog.I?.Warning(\\$\"\");"],
    "description": "A warning GLog message"
  },
  "Danger GLog": {
    "scope": "csharp",
    "prefix": ["danger", "log"],
    "body": ["GLog.I?.Danger(\\$\"\");"],
    "description": "A danger GLog message"
  }
}
```

##### Other editors / IDEs

For the moment i do not aknowledge other editors or IDEs snippets crafting. If you can help me sending me some so i can improve this document i'll be very very glad!

## Where to find me

https://indiegabo.com

## Thanks and references

Huge thanks to [GabrielBigardi](https://github.com/GabrielBigardi) and [RicardoQLG](https://github.com/RicardoQLG) who created packages wich i've modeled to learn how to make my own.
