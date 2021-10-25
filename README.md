# AutoPostX
 A simple utility to streamline plugin testing.

# Installing
 Simply extract the zip from the latest release to your NeosVR install folder.

# Using
 Add the following lines to your Visual Studio post build commands:

``start /w /d "C:\Program Files (x86)\Steam\steamapps\common\NeosVR\AutoPostX" AutoPostX.exe "C:\Users\YOURNAME\source\repos\NeosTweaks\NeosTweaks\bin\Debug\NeosTweaks.dll"``

``copy "$(TargetDir)$(TargetFileName)" "C:\Program Files (x86)\Steam\steamapps\common\NeosVR\Libraries"``

# Known bugs
 Ideally I could use %UserProfile% instead of explicitly setting it to a name but for some reason it's considered an invalid format so this will have to do for now.
