@echo off
del nugets /s /q
SET version=1.6.1
set outputFolder=nugets
echo Output folder: %outputFolder%
echo Version: %version%
dotnet pack ..\Metapsi.Runtime -o %outputFolder% /p:Version=%version% -c Release
dotnet pack ..\Metapsi.Module -o %outputFolder% /p:Version=%version% -c Release
dotnet pack ..\Metapsi.Hyperapp -o %outputFolder% /p:Version=%version% -c Release
dotnet pack ..\Metapsi.Web -o %outputFolder% /p:Version=%version% -c Release
dotnet pack ..\Metapsi.Redis -o %outputFolder% /p:Version=%version% -c Release
dotnet pack ..\Metapsi.Sqlite -o %outputFolder% /p:Version=%version% -c Release
dotnet pack ..\Metapsi.Timer -o %outputFolder% /p:Version=%version% -c Release
