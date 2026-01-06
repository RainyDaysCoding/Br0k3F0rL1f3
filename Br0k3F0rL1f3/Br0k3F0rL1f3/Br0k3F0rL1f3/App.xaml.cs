namespace Br0k3F0rL1f3;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage()) { Title = "Br0k3F0rL1f3" };
    }
}
