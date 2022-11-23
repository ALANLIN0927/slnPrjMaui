namespace PrjMaui.View;

public partial class PgPreferencesDemo : ContentPage
{
	public PgPreferencesDemo()
	{
		InitializeComponent();
	}

	private void btnSave_Clicked(object sender, EventArgs e)
	{
		Preferences.Default.Set("KK", txtSet.Text);
	}

	private void btnRead_Clicked(object sender, EventArgs e)
	{
		lblGet.Text = Preferences.Default.Get("KK", "---");
	}
}