﻿- Compile project under Release mode.
- Copy the output NWN.Plugin.Framework.dll from bin/Release to the lib/net461 folder.
- Update NWN.Plugin.Framework.nuspec version number.
- Open cmd line
- cd to the NWNPluginFramework/NWN.Plugin.Framework folder
- Run command: nuget pack NWN.Plugin.Framework.nuspec
- Upload to nuget.org via their online GUI