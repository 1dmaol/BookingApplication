public class App : Xamarin.Forms.Application
{
    public App ()
    {
        MainPage = new ContentPage
        {
            Content = new Label
                {
                    Text = "Indra Studios Application",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
        };
    }
}