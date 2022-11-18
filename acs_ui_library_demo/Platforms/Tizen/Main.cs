using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace acs_ui_library_demo;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}

