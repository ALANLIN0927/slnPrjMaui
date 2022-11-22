using PrjMaui.Model;

namespace PrjMaui.View;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
		if(!string.IsNullOrEmpty(CDictionary.USERNAME))
			lblMessage.Text="Hello"+CDictionary.USERNAME;
		else
		{
			App a = Application.Current as App;
			if (!string.IsNullOrEmpty(a.userName))
			lblMessage.Text=a.userName;
		}
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}