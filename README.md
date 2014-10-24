Windows-API-Code-Pack-1.1
=========================

Windows API Code Pack 1.1

**Notes:**

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
**TODO:**

Provide NuGet packages for DirectX assemblies.


