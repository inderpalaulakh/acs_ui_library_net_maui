# ACS Calling UI Library .NET MAUI Demo app

This project demonstrate the bindings, .NET MAUI sample app for [calling-communication-ui-library-android](https://github.com/Azure/communication-ui-library-android/tree/develop).

### Guide
To setup Azure Communication Services, follow instructions at [QuickStart](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/ui-library/get-started-composites?tabs=kotlin&pivots=platform-android).

### Getting Started

1) Open `acs_ui_library_net_maui/acs_ui_library_demo` in `Visual Studio 2022`

```C#
private void OnStartCall(object sender, EventArgs e)
    {
        Composite composite = new Composite();
        string name = ""; // Display name
        string acsToken = ""; // ACS Token
        string callID = ""; // call ID (GUID)
        bool isTeamsCall = false;

        composite.joinCall(name, acsToken, callID, isTeamsCall);
    }
```

2) Open `MainPage.xaml.cs` and enter call details in  `OnStartCall`
3) Launch App and Press `Start ACS Call` 