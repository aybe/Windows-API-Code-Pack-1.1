@echo off
cls
call clean.bat
echo Building NuGet packages ...
nuget pack WindowsAPICodePack-Core.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-ExtendedLinguisticServices.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-Sensors.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-Shell.nuspec -NoPackageAnalysis
nuget pack WindowsAPICodePack-ShellExtensions.nuspec -NoPackageAnalysis
copy WindowsAPICodePack-DirectX.readme readme.txt
nuget pack WindowsAPICodePack-DirectX.nuspec -NoPackageAnalysis
del readme.txt
