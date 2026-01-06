using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Br0k3F0rL1f3;

class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}
