# Introduction to JSON / NuGet packages

[JSON](https://www.w3schools.com/js/js_json_intro.asp) is a way of storing structured data, e.g. as lists, dictionaries or even potentially as objects, in text files. This is called "[serialisation](https://en.wikipedia.org/wiki/Serialization)". 

The *de facto* way to work with JSON in C# is to use the Newtonsoft JSON.net library, which is not written by Microsoft but available via the NuGet package manager. 

These examples can come from any text - a string, a local text file or, more exotically, a network connection to a remote API or (potentially RESTful) [webserver](https://github.com/jdorfman/Awesome-JSON-Datasets) (linked to, somewhat riskily, without fully checking the contents). 

## VS.Code

The C# project shown in the subdirectory `JsonIntroduction` is VS Code.   

### Using NuGet 

From the command palette, `Add NuGet package' and search for 'Newtonsoft'. 

As outlined on [Stack Overflow](https://stackoverflow.com/a/42218729/2902), open the terminal and type `dotnet add package Newtonsoft.Json`. 

Notice the new XML `ItemGroup` in the `csproj` file. 

(Other JSON libraries are available, but this is the best.)

