namespace MauiNavInheritance;

public partial class SelectionPage : ContentPage
{
	public SelectionPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    private void Button2_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new CNavigationPage(new MainPage());

    }
}