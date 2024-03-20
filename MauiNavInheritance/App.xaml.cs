namespace MauiNavInheritance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SelectionPage();
        }
    }
}
