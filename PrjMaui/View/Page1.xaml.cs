using PrjMaui.Model;

namespace PrjMaui.View;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page2());
	}

	private void btnStatic_Clicked(object sender, EventArgs e)
	{
		CDictionary.USERNAME = "Marco";
        Navigation.PushAsync(new Page2());
    }

	private void btnProperty_Clicked(object sender, EventArgs e)
	{
		App a = Application.Current as App;
		a.userName = "Marco";
        Navigation.PushAsync(new Page2());
    }
}