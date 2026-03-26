
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net;

string json = @"{""key1"": ""value1"", ""key2"": ""value2""}";

IDictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

string data = File.ReadAllText("NASA Data.json");

Console.WriteLine(data);