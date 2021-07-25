# GDBrowser.NET
A (work in progress) GDBrowser API implementation for .NET

[![youtube.com/starpelly](https://img.shields.io/badge/youtube-youtube.com%2Fstarpelly-red)](https://youtube.com/starpelly)

## Features

1. Get level info
2. Get user info
3. Get global leaderboard and creator leaderboard info (accurate leaderboard W.I.P)
4. Get if a song is available for use or not.

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
