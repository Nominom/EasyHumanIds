# EasyHumanIds
Just a simple F# library for generating human readable ids.

This library is not yet suited for generating human readable GUID's, because of the (relatively) small id-space of about 1.3 million combinations.
But it's perfect for simple things like roguelike seed generation.


## Unity integration (Tested with Unity 2019.1.3f1)

Open the project in Visual Studio (With F# tools installed) and
make sure the target framework is set to net45 in the .fsproj file like this:

    <TargetFramework>net45</TargetFramework>
    
Publish the project, and drag and drop the EasyHumandIds-Standard.dll and Fsharp.Core.dll libraries to your unity Assets in a folder called "Plugins".
After that you should be ready to go.
