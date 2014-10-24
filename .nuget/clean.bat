@echo off
cls
echo Cleaning NuGet packages ...
IF EXIST *.nupkg (del *.nupkg)
