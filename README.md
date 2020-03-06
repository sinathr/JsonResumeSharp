# JsonResumeSharp

An open source library for creating and manipulating [Json Resume](http://jsonresume.org/scheme "Json Resume") object in C#

## Getting Started



### Prerequisites

.NET Standard 2.0 or higher

### Installing

To install JsonResumeSharp just execute the following command in your nuget CLI :

```bash
Install-Package JsonResumeSharp -Version 1.0.0-b1
```
###Usage
To use the JsonResumeSharp do these steps: 
1. import JsonResumeSharp namespaces to your project:
```C#
using using JsonResumeSharp;
using JsonResumeSharp.Utils.Extentions;
```
2. Create a new instance of JsonResume:
```C#
 JsonResume jsonResume = new JsonResume();
```
3. Add your background to it:
```C#
jsonResume.AddAward(new Award())
                .AddWork(new Work())
                .AddEducation(new Education())
                .AddPublication(new Publication)
                ...
```
4. Convert your object easily to a json string:
```C#
string jsonString = jsonResume.ToJson();
```
And now every thing is done.
###Other features
You can also create the JsonResume object from a jsonString:
```C#
JsonResume jsonResume = JsonResume.FromJson(jsonString);
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

