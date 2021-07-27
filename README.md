# GDBrowser.NET
A (work in progress) GDBrowser API implementation for .NET

[![youtube.com/starpelly](https://img.shields.io/badge/youtube-youtube.com%2Fstarpelly-red)](https://youtube.com/starpelly)

## Features

1. Get level info
2. Get user info
3. Get global leaderboard and creator leaderboard info (accurate leaderboard W.I.P)
4. Get Map Packs and Gauntlets
5. Level Analysis
7. Get if a song is available for use or not.

## Demo

Profile:

```CSharp
// generate client
var client = new GDBrowserClient();

// https://gdbrowser.com/api/profile/starpelly
var result = await client.GetProfileAsync("Starpelly");

// Result: 149
Console.WriteLine(result.Coins);
```

Leaderboard:

```CSharp
// generate client
var client = new GDBrowserClient();

// https://gdbrowser.com/api/leaderboard?creator&count=16
var result = await client.GetLeaderboardAsync(true, 16);

// Result: 278 (unless it changes)
Console.WriteLine(result[0].CreatorPoints);
```

MapPacks + Gauntlets:

```CSharp
var client = new GDBrowserClient();

// https://gdbrowser.com/api/mappacks
var mappack = await client.GetMapPacksAsync();

// https://gdbrowser.com/api/gauntlets
var gauntlet = await client.GetGauntletsAsync();

// Result: Alpha Pack
Console.WriteLine(mappack[0].Name);
Console.WriteLine();

for (int i = 0; i < gauntlet.Count; i++)
	Console.WriteLine(gauntlet[i].Name); // Result: A list with all the current gauntlet names in the game
```

Level Analysis (only works on custom or local servers atm)

Since level analysis wont work on gdbrowser.com, this function will only work by setting a custom api root url.

```CSharp
var client = new GDBrowserClient();
client.SetAPIRootUrl("http://localhost:2000"); // eg. https://gdbrowser.com, used to set a custom api root url, you can run it locally by forking the gdbrowser github repo and running it locally.

var analysis = await client.GetLevelAnalysisAsync(58079690); // Object ID's by Colon
Console.WriteLine(analysis.DataLength); // Result: 128745
```
