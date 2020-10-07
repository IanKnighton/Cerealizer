# Cerealizer

![Publish to GitHub Packages](https://github.com/IanKnighton/Cerealizer/workflows/Publish%20to%20GitHub%20Packages/badge.svg)

I was sitting in a meeting one day with a person named "Jason" and someone made a comment about whether or not they were `serialized`, which then turned into a joke about cereal.

So in the course of a meeting I put together a wrapper on top of the Newtonsoft.Json `JsonConvert` class that keeps all of the same functionality, but changes the word to `Cereal` instead of `Serial`.

It really provides no value other than that. 

## Usage

You can either download the source and reference the `Cerealizer.csproj` file in your project or download it from the GitHub package manager. 

```console
dotnet add PROJECT package Cerealizer
```

Once you have it referenced, it's pretty straight forwared. You can pass or retrieve objects just like you would use Newtonsoft. 

```csharp
string serializedObject = JsonCerealizer.CerealizeObject(YourObject)
```

That's pretty much all there is to it. 
