namespace MauiRepro.RequestedThemeChanged;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Application.Current.RequestedThemeChanged += OnRequestedThemeChanged;
    }

    private void OnRequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
    {
        Application.Current.UserAppTheme = e.RequestedTheme;
    }
}