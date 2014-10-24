@echo off
cls
call clean.bat
echo Building NuGet packages ...
nuget pack WindowsAPICodePack-Core.1.1.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-ExtendedLinguisticServices.1.1.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-Sensors.1.1.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-Shell.1.1.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-ShellExtensions.1.1.nuspec -NoPackageAnalysis