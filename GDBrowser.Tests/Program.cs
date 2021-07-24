using System;
using System.Reflection;
using System.Threading.Tasks;
using GDBrowser;

using Microsoft.VisualStudio.TestTools.UnitTesting;

class Program
{
    static void Main(string[] args)
    {
        Test();
        Console.ReadLine();
    }

    static async void Test()
    {
        GDBrowserClient gd = new GDBrowserClient();
        var result = await gd.GetProfileAsync("Starpelly");
        Assert.AreEqual(149, result.Coins); // will return an error if not the same.
        Console.WriteLine(result.Stars);

        var boole = await gd.GetSongVerificationAsync(1);

        Console.WriteLine(boole);

    }
}
