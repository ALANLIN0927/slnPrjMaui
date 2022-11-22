namespace PrjMaui.View;

public partial class PgKeyword : ContentPage
{
	public PgKeyword()
	{
		InitializeComponent();
	}

	private void btnOk_Clicked(object sender, EventArgs e)
	{
		App a = Application.Current as App;
		a.keyword = txtKeyword.Text;
		Navigation.PopAsync();
	}
}