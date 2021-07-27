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
        client.SetAPIRootUrl("http://localhost:2000"); // eg. https://gdbrowser.com, used to set a custom api root url

        var analysis = await client.GetLevelAnalysisAsync(58079690); // Object ID's by Colon
        Console.WriteLine(analysis.DataLength); // Result: 128745
    }
}
