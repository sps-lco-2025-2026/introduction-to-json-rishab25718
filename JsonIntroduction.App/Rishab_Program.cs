using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net;
using System.IO;

using System;

class Rishab_Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running Rishab Program!");
        string json = @"{""craft"":""value1"",""name"":""value2""}";

        string data = File.ReadAllText("JSON NASA Data.json");

        JObject obj = JObject.Parse(data);

        Console.WriteLine($"Message: {obj["message"].ToObject<string>()}");
        Console.WriteLine($"Number: {obj["number"].ToObject<int>()}");

        Console.WriteLine("The people onboard are");

        JArray people = (JArray)obj["people"];

        foreach (dynamic person in people)
        {
            Console.WriteLine($"{person["name"]}  ({person["craft"]})");
        }

        Console.Read();

        Console.WriteLine("hello world");
    }
}

