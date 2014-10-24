Windows-API-Code-Pack-1.1
=========================

Windows API Code Pack 1.1

NuGet packages (recommended)
----------------------------

https://www.nuget.org/packages/WindowsAPICodePack-Core/

https://www.nuget.org/packages/WindowsAPICodePack-Shell/

https://www.nuget.org/packages/WindowsAPICodePack-ShellExtensions/

https://www.nuget.org/packages/WindowsAPICodePack-DirectX/

https://www.nuget.org/packages/WindowsAPICodePack-ExtendedLinguisticServices/

https://www.nuget.org/packages/WindowsAPICodePack-Sensors/

Release notes
-------------

- availability of the documentation through IntelliSense
- availability of the DirectX package
- bug fix for `TaskDialog` icon not shown unless defined in `Opened` event (x86/x64)

Usage notes
-----------

**TaskDialog**

If you get the following exception when you instantiate a `TaskDialog`:

```
An unhandled exception of type 'System.NotSupportedException' occurred in Microsoft.WindowsAPICodePack.dll

Additional information: TaskDialog feature needs to load version 6 of comctl32.dll but a different version is current loaded in memory.
```

To fix it, create an application manifest and uncomment the following block section:

```
  <!-- Enable themes for Windows common controls and dialogs (Windows XP and later) -->
  <!-- <dependency>
    <dependentAssembly>
      <assemblyIdentity
          type="win32"
          name="Microsoft.Windows.Common-Controls"
          version="6.0.0.0"
          processorArchitecture="*"
          publicKeyToken="6595b64144ccf1df"
          language="*"
        />
    </dependentAssembly>
  </dependency>-->
```
**DirectX**

The DirectX package will work under x86 and x64 configuration platforms but not for AnyCPU platform (because there is no such platform for C++/CLI projects). Consequently, the package will purposefully fail the build and tell you why it did.
