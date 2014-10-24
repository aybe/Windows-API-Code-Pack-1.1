@echo off
cls
call clean.bat
echo Building NuGet packages ...
nuget pack WindowsAPICodePack-Core.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-ExtendedLinguisticServices.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-Sensors.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-Shell.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-ShellExtensions.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-DirectX.nuspec -NoPackageAnalysis
REM nuget pack WindowsAPICodePack-DirectX.1.1-x64.nuspec -NoPackageAnalysis
REM nuget pack WindowsAPICodePack-DirectX.1.1-x86.nuspec -NoPackageAnalysis