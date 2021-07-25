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
        var test = await gd.GetLeaderboardAsync(false);
        Console.WriteLine(test[0].Icon.Colour1);
    }
}
