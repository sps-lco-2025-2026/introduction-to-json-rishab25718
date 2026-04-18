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

        List<string> Crafts = new List<string>();
        List<List<string>> PeopleByCraft = new List<List<string>>();

        foreach (dynamic person in people)
        {
            
            bool inCrafts = false;
            bool inPeople = false;

            foreach (string craft in Crafts)
            {
                if (craft == person["craft"].ToString())
                {
                    inCrafts = true;
                }

            }
            if (inCrafts == false)
            {
                Crafts.Add(person["craft"].ToString());
                PeopleByCraft.Add(new List<string>());
            }

            foreach (List<string> personByCraft in PeopleByCraft)
            {
                foreach (string Person in personByCraft)
                {
                    if (Person == person["name"].ToString())
                    {
                        inPeople = true;
                    }
                }
            }
            if (inPeople == false)
            {
                PeopleByCraft[PeopleByCraft.Count - 1].Add(person["name"].ToString());
            }
        }

        for (int i = 0; i < PeopleByCraft.Count; i++)
        {
            Console.WriteLine($"In {Crafts[i]}, people are:");

            foreach (var person in PeopleByCraft[i])
            {
                Console.WriteLine($" - {person}");
            }
        }
    }
}

