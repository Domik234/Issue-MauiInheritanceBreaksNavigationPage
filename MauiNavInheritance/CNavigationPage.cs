namespace MauiNavInheritance
{
    public class CNavigationPage : NavigationPage
    {
        public CNavigationPage() : base()
        {
            Init();
        }

        public CNavigationPage(Microsoft.Maui.Controls.Page page) : base(page)
        {
            Init();
        }

        public void Init()
        {
            //this.On<iOS>().HideNavigationBarSeparator();
        }
    }
}
