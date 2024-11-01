using Microsoft.Maui.Controls;

namespace SftpInstrument;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}