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
    }
}
