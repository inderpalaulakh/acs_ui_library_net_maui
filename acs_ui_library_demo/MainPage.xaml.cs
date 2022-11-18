using acs_ui_library_demo.Platforms.Android;
using System;

namespace acs_ui_library_demo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        OnStartCall(sender, e);
    }

    private void OnStartCall(object sender, EventArgs e)
    {
        Composite composite = new Composite();
        string name = "";
        string acsToken = "";
        string callID = "";
        bool isTeamsCall = false;

        composite.joinCall(name, acsToken, callID, isTeamsCall);
    }
}


